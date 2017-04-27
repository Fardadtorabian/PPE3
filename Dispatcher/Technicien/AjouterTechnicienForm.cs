using System;
using System.Windows.Forms;
using LibDao;

namespace Dispatcher
{
    public partial class AjouterTechnicienForm : Form
    {
        public AjouterTechnicienForm()
        {
            InitializeComponent();
        }

        //**************************************************************************************************
        private void btnAjouterTechnicien_Click(object sender, EventArgs e)
        {
            // créer un technicien et lui affecte les champs remplis 
            Technicien monTechnicien = new Technicien();
            if ((textBoxNom.Text != String.Empty) && (textBoxPrenom.Text != String.Empty) &&
                (textBoxLoginT.Text != String.Empty) && (txtBoxMdp.Text != String.Empty))
            {
                using (TechnicienManager technicienManager = new TechnicienManager())
                {
                    monTechnicien.Nom = textBoxNom.Text.Trim();
                    monTechnicien.Prenom = textBoxPrenom.Text.Trim();
                    monTechnicien.LoginT = textBoxLoginT.Text.Trim();
                    monTechnicien.PasswdT = Utils.getMd5Hash(txtBoxMdp.Text.Trim());
                    bool resultat = technicienManager.ajoutModifTechnicien(ref monTechnicien);
                    // On ajoute le technicien en BDD

                    if (resultat)  // si l'ajout s'est bien passé
                    {
                       MessageToast.Show("Technicien ajouté avec succès");
                    }
                    else
                    {
                        MessageToast.Show("Les champs remplis sont incorrectes");
                    }
                }
            }
            else
            {
                MessageBox.Show("Merci de remplir tous les champs");
            }
        }
        //**************************************************************************************************
        private void btnViderChamps_Click(object sender, EventArgs e)
        {
            textBoxNom.ResetText();
            textBoxPrenom.ResetText();
            textBoxLoginT.ResetText();
            txtBoxMdp.ResetText();
        }
        //**************************************************************************************************
    }
}
