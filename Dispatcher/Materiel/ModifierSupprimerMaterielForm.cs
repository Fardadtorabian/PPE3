using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibDao;
using System.ComponentModel;

namespace Dispatcher
{
    public partial class ModifierSupprimerMaterielForm : Form
    {
        private List<Materiel> listMateriel = null;
        Materiel materielSelectionne = null;
        //**************************************************************************************************
        public ModifierSupprimerMaterielForm()
        {
            InitializeComponent();

            if (initialiserDgvMateriel())
            {
                btnModifierMateriel.Enabled = false;
                btnSupprimerMateriel.Enabled = false;
            }
        }
        //**************************************************************************************************
        private bool initialiserDgvMateriel()
        {
            // Récupérer la liste du matériel
            using (Manager manager = new Manager())
            {
                manager.getListe(ref listMateriel, "materiel");
            }
            // peupler le dgvMateriels
            foreach (Materiel chaqueMateriel in listMateriel)
            {
                dgvMateriels.Rows.Add(
                    chaqueMateriel.IdMateriel,
                    chaqueMateriel.TypeMateriel,
                    chaqueMateriel.NumeroSerie);
            }
            // Tri par ordre alphabétique des noms
            dgvMateriels.Sort(dgvMateriels.Columns[1], ListSortDirection.Ascending);
            // On interdit la sélection multique de ligne mais on oblige la sélection totale d'une ligne
            dgvMateriels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMateriels.MultiSelect = false;
            // Cacher le header des lignes
            dgvMateriels.RowHeadersVisible = false;
            return true;
        }

        //**************************************************************************************************
        private void viderChamps()
        {
            // vide les champs
            textBoxNumSerie.ResetText();
            textBoxTypeMateriel.ResetText();
            mTxtBoxNumtel.ResetText();
            textBoxCodeIMEI.ResetText();
            textBoxIdGoogle.ResetText();
            txtBoxAffectationMat.ResetText();
            comBoxEtatMatériel.SelectedItem = "";
            dgvMateriels.Rows.Clear();
        }
        //**************************************************************************************************
        private void RafraichirIHM()
        {
            viderChamps();
            initialiserDgvMateriel();
        }
        //**************************************************************************************************
        private void btnModifierMateriel_Click(object sender, EventArgs e)
        {
            // On récupère Tous les attributs du matériel
            using (MaterielManager materielManager = new MaterielManager())
            {
                materielSelectionne.TypeMateriel = textBoxTypeMateriel.Text.Trim();
                materielSelectionne.NumeroTel = mTxtBoxNumtel.Text.Trim();
                materielSelectionne.Imei = textBoxCodeIMEI.Text.Trim();
                materielSelectionne.IdGoogle = textBoxIdGoogle.Text.Trim();
                // il faut chercher si un technicien a en usage le matériel
                // si oui et si etatMatériel n'est pas égale à enService il faut 
                // l'enlever de l'affectation du technicien                  
                using (TechnicienManager technicienManager = new TechnicienManager())
                {
                    Technicien technicien = new Technicien();
                    technicien.FkIdMateriel = materielSelectionne.IdMateriel;
                    // on recherche le technicien qui possédait le matériel 
                    technicien = technicienManager.getTechnicien(technicien);
                    if ((materielSelectionne.EtatMateriel == "enService") && ((string)comBoxEtatMatériel.SelectedItem != "enService"))
                    {
                        // il faut retirer l'affectation du matériel au technicien
                        technicien.FkIdMateriel = 0;
                        technicienManager.ajoutModifTechnicien(ref technicien);
                    }
                }
                materielSelectionne.EtatMateriel = comBoxEtatMatériel.SelectedItem.ToString();
                materielSelectionne.FkLoginE = UtilisateurConnecte.Login;
                // On persiste les modifications
                materielManager.insertUpdateMateriel(ref materielSelectionne);
                MessageToast.Show("Matériel modifié avec succès");
                RafraichirIHM();
            }
        }
        //**************************************************************************************************
        private void btnSupprimerMateriel_Click(object sender, EventArgs e)
        {
            // A CODER Attention à la cohérence en BDD
        }
        //**************************************************************************************************
        private void btnResetSelectionMateriel_Click(object sender, EventArgs e)
        {
            RafraichirIHM();
        }
        //**************************************************************************************************
        private void dgvMateriels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             int IdxLigneActuelle = e.RowIndex;

             if (IdxLigneActuelle >= 0)
             {
                 int idMateriel = (int)dgvMateriels.Rows[IdxLigneActuelle].Cells[0].Value;
                 int indiceDansListMateriel = listMateriel.FindIndex(unMateriel => unMateriel.IdMateriel == idMateriel);
                 materielSelectionne = listMateriel[indiceDansListMateriel];

                  //On a récupéré l'objet matériel correspondant à la sélection, 
                 // on rempli les différents champs
                     textBoxTypeMateriel.Text = materielSelectionne.TypeMateriel;
                     textBoxNumSerie.Text = materielSelectionne.NumeroSerie;
                     mTxtBoxNumtel.Text = materielSelectionne.NumeroTel;
                     textBoxCodeIMEI.Text = materielSelectionne.Imei;
                     textBoxIdGoogle.Text = materielSelectionne.IdGoogle;
                     comBoxEtatMatériel.SelectedItem = materielSelectionne.EtatMateriel;
                     lblDateEnregistrementMateriel.Text = materielSelectionne.DateEnregistrement.ToString("dd/MM/yyyy");
                     if (materielSelectionne.DateAffectation != DateTime.MinValue)
                     {
                         lblValDateAffectation.Text = materielSelectionne.DateAffectation.ToString("dd/MM/yyyy");
                     }
                     else
                     {
                         lblValDateAffectation.Text = "jamais affecté";
                     }
                     using (TechnicienManager technicienManager = new TechnicienManager())
                     {
                         Technicien technicien = new Technicien();
                         technicien.FkIdMateriel = materielSelectionne.IdMateriel;
                         technicien = technicienManager.getTechnicien(technicien);
                         txtBoxAffectationMat.Text = technicien.Prenom + "  " + technicien.Nom;
                     }
                     btnModifierMateriel.Enabled = true;
             } 
        }

        //**************************************************************************************************
        // permet de placer le curseur de saisie a gauche de la maskTextBox
        private void mTxtBoxNumtel_MouseClick(object sender, MouseEventArgs e)
        {
            mTxtBoxNumtel.SelectionStart = 0;
        }
        //**************************************************************************************************
        private void ModifierSupprimerMaterielForm_Load(object sender, EventArgs e)
        {           
        // Au chargement de la page on déselectionne la première cellule du dataGridView
        // Un try catch permet d'éviter attrape une exception rarissime si la table client est vide (Row null)
            try
            {
                dgvMateriels.Rows[0].Selected = false;
            }
            catch { }
        }      
        //**************************************************************************************************
    }
}
