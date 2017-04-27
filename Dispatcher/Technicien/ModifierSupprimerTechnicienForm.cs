using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibDao;

namespace Dispatcher
{
    public partial class ModifierSupprimerTechnicienForm : Form
    {
        private List<Technicien> listTechnicien = null;
        Technicien technicienSelectionne = null;
        public ModifierSupprimerTechnicienForm()
        {
            InitializeComponent();
            btnSupprimerTechnicien.Enabled = false;
            if (InitialiserDGV())
            {
                btnModifierTechnicien.Enabled = true;
                if (UtilisateurConnecte.Groupe == "Administration")
                {
                    btnSupprimerTechnicien.Enabled = true;
                }

            }
        }
        //**************************************************************************************************

        private bool InitialiserDGV()
        {
            bool bRequete = false; // vrai si des techniciens ont été récupérés
            try
            {
                using (Manager manager = new Manager())
                {
                    // récupère la liste des techniciens de la BDD
                    manager.getListe(ref listTechnicien, "technicien");
                }
                foreach (Technicien chaqueTechnicien in listTechnicien)
                {
                    dgvTechnicien.Rows.Add(chaqueTechnicien.Nom,
                        chaqueTechnicien.Prenom,
                        chaqueTechnicien.LoginT);
                }
                dgvTechnicien.Sort(dgvTechnicien.Columns[0], ListSortDirection.Ascending);
                bRequete = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return bRequete;
        }

        //**************************************************************************************************
        private void btnModifierTechnicien_Click(object sender, EventArgs e)
        {
            if ((technicienSelectionne != null) && (textBoxNom.Text.Trim() != String.Empty) &&
                (textBoxPrenom.Text.Trim() != String.Empty) &&
                (textBoxLoginT.Text.Trim() != String.Empty) &&
                (txtBoxMdp.Text.Trim() != String.Empty))
            {
                using (TechnicienManager technicienManager = new TechnicienManager())
                {
                    technicienSelectionne.Nom = textBoxNom.Text.Trim();
                    technicienSelectionne.Prenom = textBoxPrenom.Text.Trim();
                    technicienSelectionne.LoginT = textBoxLoginT.Text.Trim();
                    technicienSelectionne.PasswdT = Utils.getMd5Hash(txtBoxMdp.Text.Trim());
                    bool resultat = technicienManager.ajoutModifTechnicien(ref technicienSelectionne);

                    if (resultat) // Test si tout s'est bien passé
                    {
                        MessageToast.Show("Technicien modifié avec succès");
                        RafraichirIHM();
                    }
                    else
                    {
                        MessageToast.Show("Problème accès BDD ?");
                    }
                }
            }
            else
            {
                MessageBox.Show("Sélectionner un technicien et remplir tous les champs");
            }
        }
        //**************************************************************************************************
        private void btnSupprimerTechnicien_Click(object sender, EventArgs e)
        {
            // A CODER, Nécessite d'ajouter un champ "valid" à la table technicien
        }
        //**************************************************************************************************
        private void viderChamps()
        {
            // vide les champs
            textBoxLoginT.ResetText();
            textBoxNom.ResetText();
            textBoxPrenom.ResetText();
            txtBoxMdp.ResetText();
            dgvTechnicien.Rows.Clear();
        }
        //**************************************************************************************************
        private void RafraichirIHM()
        {
            viderChamps();
            InitialiserDGV();
        }
        //**************************************************************************************************
        private void btnResetSelectionTechnciens_Click(object sender, EventArgs e)
        {
            RafraichirIHM();
        }

        //**************************************************************************************************        
        private void dgvTechnicien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdxLigneActuelle = e.RowIndex;

            if (IdxLigneActuelle >= 0)
            {
                string loginTechnicien = (string)dgvTechnicien.Rows[IdxLigneActuelle].Cells[2].Value;
                int indiceDansListTechnicien = listTechnicien.FindIndex(indice => indice.LoginT == loginTechnicien);
                technicienSelectionne = listTechnicien[indiceDansListTechnicien];
                // recupère les données du Technicien
                textBoxNom.Text = technicienSelectionne.Nom;
                textBoxPrenom.Text = technicienSelectionne.Prenom;
                textBoxLoginT.Text = technicienSelectionne.LoginT;
            }
        }
        //**************************************************************************************************        
        private void ModifierSupprimerTechnicienForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.dgvTechnicien.Rows[0].Selected = false;
            }
            catch { }
        }
        //**************************************************************************************************        
    }
}
