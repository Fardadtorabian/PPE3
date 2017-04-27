using System;
using System.Windows.Forms;
using System.IO;
using LibDao;

namespace Dispatcher
{
    public partial class AjouterMaterielForm : Form
    {
        public AjouterMaterielForm()
        {
            InitializeComponent();
            comBoxEtatMateriel.SelectedItem = "stock";
        }
        //**************************************************************************************************
        private void btnViderChamps_Click(object sender, EventArgs e)
        {
            // vide les champs
            textBoxNumSerie.ResetText();
            textBoxTypeMateriel.ResetText();
            mTxtBoxNumtel.ResetText();
            textBoxCodeIMEI.ResetText();
            textBoxIdGoogle.ResetText();
        }
        //**************************************************************************************************
        private void btnAjouterMateriel_Click(object sender, EventArgs e)
        {
            // créer un matériel et lui affecte les champs remplis 
            // Ajoute le matériel en BDD       
            using (MaterielManager materielManager = new MaterielManager()) // appel automatique de la methode dispose qui ferme la connexion
            {
                Materiel materiel = new Materiel();
                materiel.TypeMateriel = textBoxTypeMateriel.Text.Trim();
                materiel.NumeroSerie = textBoxNumSerie.Text.Trim();
                materiel.NumeroTel = mTxtBoxNumtel.Text.Trim();
                materiel.Imei = textBoxCodeIMEI.Text.Trim();
                materiel.IdGoogle = textBoxIdGoogle.Text.Trim();
                materiel.EtatMateriel = comBoxEtatMateriel.SelectedItem.ToString();

                materiel.FkLoginE = UtilisateurConnecte.Login;

               if( materielManager.insertUpdateMateriel(ref materiel)==true)
               {
                   MessageToast.Show("Materiel ajouté avec succès");
                   btnViderChamps_Click(this, null);
               }
            }
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
