using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;
using LibDao;

namespace Dispatcher
{
    public partial class AffecterMaterielFormulaire : Form
    {
        private List<Materiel> listMateriel = null;
        private List<Materiel> listMaterielDispo = null;
        private List<Technicien> listTechniciens = null;
        private List<Technicien> listTechniciensSansMateriel = null;
        Materiel materielSelectionne = null;
        Technicien technicienSelectionne = null;
        public AffecterMaterielFormulaire()
        {
            InitializeComponent();
            initialiserDgvMaterielsEtDgvTechniciens();
        }

        //**************************************************************************************************
        private void initialiserDgvMaterielsEtDgvTechniciens()
        {
            this.btnAttribuerMateriel.Enabled = false;
            materielSelectionne = null;
            technicienSelectionne = null;
            List<int> listIdMaterielDispo = new List<int>();
            // RAZ des DGV
            dgvListeTechniciens.Rows.Clear();
            dgvMateriels.Rows.Clear();
            // Récupération de la liste des techniciens et des matériels
            using (Manager manager = new Manager())
            {
                // connexion déjà ouverte on peut la passer en paramètre

                // Récuperation de la liste des matériels
                manager.getListe(ref listMateriel, "materiel");
                // Récuperation de la liste des techniciens
                manager.getListe(ref listTechniciens, "technicien");
                // Récuperation de la liste des techniciens sans matériels
                // Utilisation de Linq
                //var listItem =
                //from technicien in listTechniciens
                //where technicien.FkIdMateriel == 0
                //select technicien;
                //listTechniciensSansMateriel = (List<Technicien>)listItem;

                // Ou utilisation de Linq avec Expression Lamda
                listTechniciensSansMateriel = listTechniciens.FindAll(technicien => technicien.FkIdMateriel == 0);

                // Récuperation de la liste des matériels non affectés (jointure + Différence entre list)
                // On commence par récupérer la liste des matériels affectés
                var result =
                from materiel in listMateriel
                join technicien in listTechniciens on materiel.IdMateriel equals technicien.FkIdMateriel
                select materiel; // On obtient la liste des matériels attribués
                // Grace à la méthode Except on retire de la listMateriel le matériel affecté
                // On injecte le résultat dans la listMaterielDispo via la méthode ToList 
                listMaterielDispo = listMateriel.Except(result).ToList<Materiel>();
            }
            // On rempli le dataGridView des techniciens sans matériel
            foreach (Technicien chaqueTechnicien in listTechniciensSansMateriel)
            {
                dgvListeTechniciens.Rows.Add(chaqueTechnicien.LoginT,
                        chaqueTechnicien.Prenom,
                        chaqueTechnicien.Nom);
            }
            // Trier par ordre alphabétique des noms le dataGridView
            dgvListeTechniciens.Sort(dgvListeTechniciens.Columns[2], ListSortDirection.Ascending);

            textBoxTypeMateriel.ResetText();
            textBoxNumSerie.ResetText();
            mTxtBoxNumtel.ResetText();
            // On affiche dans le dgvMateriel que les matériels trouvé dispo
            foreach (Materiel chaqueMateriel in listMaterielDispo)
            {
                dgvMateriels.Rows.Add(
               chaqueMateriel.IdMateriel,
               chaqueMateriel.TypeMateriel,
               chaqueMateriel.NumeroSerie);
            }

        }
        //**************************************************************************************************
        private void dgvMateriels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdxLigneActuelle = e.RowIndex; // indice de la ligne sélectionnée

            if (IdxLigneActuelle >= 0)
            {
                // IdMatériel est caché dans la première colonne du dgv
                int idMateriel = (int)dgvMateriels.Rows[IdxLigneActuelle].Cells[0].Value;
                // on récupère l'indice dans la liste des matériels le matérielt sélectionné
                int indiceDansListMateriel = listMateriel.FindIndex(unMateriel => unMateriel.IdMateriel == idMateriel);
                // recupère le matériel sélectionné
                materielSelectionne = listMateriel[indiceDansListMateriel];
                // On affiche les attributs principaux du matériel
                textBoxTypeMateriel.Text = materielSelectionne.TypeMateriel;
                textBoxNumSerie.Text = materielSelectionne.NumeroSerie;
                mTxtBoxNumtel.Text = materielSelectionne.NumeroTel;
            }
            if ((materielSelectionne != null) && (technicienSelectionne != null))
            {
                this.btnAttribuerMateriel.Enabled = true;
            }
        }

        //**************************************************************************************************
        private void dgvListeTechniciens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdxLigneActuelle = e.RowIndex; // indice de la ligne sélectionnée

            if (IdxLigneActuelle >= 0)
            {
                // loginT est caché dans la première colonne du dgv
                String logingT = (String)dgvListeTechniciens.Rows[IdxLigneActuelle].Cells[0].Value;
                // on récupère l'indice dans la liste des techniciend de celui qui est sélectionnée
                int indiceDansListTechnicien = listTechniciens.FindIndex(s => s.LoginT == logingT);
                // recupère le technicien sélectionnée
                technicienSelectionne = listTechniciens[indiceDansListTechnicien];
            }
            if ((materielSelectionne != null) && (technicienSelectionne != null))
            {
                this.btnAttribuerMateriel.Enabled = true;
            }
        }
        //**************************************************************************************************
        private void btnAttribuerMateriel_Click(object sender, EventArgs e)
        {
            if ((materielSelectionne != null) && (technicienSelectionne != null))
            {
                using (MaterielManager materielManager = new MaterielManager())
                {
                    materielSelectionne.EtatMateriel = "enService";
                    materielManager.affectationMaterielTechnicien(ref materielSelectionne, ref technicienSelectionne);
                }
                MessageToast.Show("Materiel affecté au technicien");
                initialiserDgvMaterielsEtDgvTechniciens();
            }
            else
            {
                MessageToast.Show("Sélectionner un technicien et un matériel");
            }
        }
        //**************************************************************************************************
        // Au chargement de la page on déselectionne la première cellule du dataGridView
        private void AffecterMaterielFormulaire_Load(object sender, EventArgs e)
        {
            try
            {
                dgvListeTechniciens.Rows[0].Selected = false;
                dgvMateriels.Rows[0].Selected = false;
            }
            catch { }
        }
        //**************************************************************************************************
        // permet de placer le curseur de saisie a gauche de la maskTextBox
        private void mTxtBoxNumtel_MouseClick(object sender, MouseEventArgs e)
        {
            mTxtBoxNumtel.SelectionStart = 0;
        }
        //**************************************************************************************************
    }
}
