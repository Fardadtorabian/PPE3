using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using LibDao;
using Dispatcher.refWsSms;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Net;
using System.Configuration;

namespace Dispatcher
{
    public partial class EnvoiSMSForm : Form
    {
        private List<Technicien> listTechnicien = null;
        private List<Materiel> listMateriel = null; // nécessaire pour récupérer le matériel affecté au technicien (téléphone)
        Technicien technicienSelectionne = null;
        Sms sms = null; // réference sur un objet sms à envoyer     
        String passwordEnvoiSMS = ""; // mot de passe commun à tous et lu dans le fichier de configuration

        //**************************************************************************************************
        // le constructeur
        public EnvoiSMSForm()
        {
            InitializeComponent();
            btnEnvoyerMessage.Enabled = false; // bouton envoi sms désactivé
            // récupération du mot de passe de connexion dans app.config
            passwordEnvoiSMS = ConfigurationManager.AppSettings["PASS_SMS"].ToString();
            InitialiserDGV();
        }
        //**************************************************************************************************
        private void InitialiserDGV()
        {
            using (Manager manager = new Manager())
            {
                // récupère les techniciens et les matériels stockés en BDD
                manager.getListe(ref listTechnicien, "technicien");
                manager.getListe(ref listMateriel, "materiel");
            }

            foreach (Technicien chaqueTechnicien in listTechnicien)
            {
                dgvTechnicien.Rows.Add(chaqueTechnicien.Nom,
                    chaqueTechnicien.Prenom,
                    chaqueTechnicien.LoginT);
            }
            // trie pae Nom
            dgvTechnicien.Sort(dgvTechnicien.Columns[0], ListSortDirection.Ascending);
        }
        //***********************************************************************************************
        private void viderChamps()
        {
            // vide les champs
            textBoxNom.ResetText();
            textBoxPrenom.ResetText();
            mTxtBoxNumtel.ResetText();
            btnEnvoyerMessage.Enabled = false;
        }

        //**************************************************************************************************
        // envoi de la requête vers le web service en https https://domy59efficom.eu/WebServiceSms.asmx
        // l'utilisateur avec son login est envoyé dans l'entête
        // le corps du sms est envoyé dans le corps de la requête

        private void btnEnvoyerMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if ((UtilisateurConnecte.Login != String.Empty) &&
                    (mTxtBoxNumtel.Text != String.Empty))// && (txtBoxMdpEnvoi.Text != String.Empty))
                {
                    // On prépare l'objet utilisateur transmis via l'entete soap
                    AuthentificationEnteteSoap authentication = new AuthentificationEnteteSoap();
                    Utilisateur utilisateur = new Utilisateur();
                    utilisateur.Login = UtilisateurConnecte.Login;
                    utilisateur.Password = passwordEnvoiSMS; // mot de passe standard pour l'envoi sms
                    authentication.user = utilisateur; // On passe l'utilisateur dans l'entête soap
                    AccesWebServices.ProxySMS.AuthentificationEnteteSoapValue = authentication; // on transmet l'authentification via l'entete http
                    // Envoi du SMS
                    sms = new Sms();
                    sms.NumDestinataire = mTxtBoxNumtel.Text;
                    sms.TextMessage = richTextBoxMessage.Text;
                    MessageToast.Show(AccesWebServices.ProxySMS.envoyerSms(sms), "Message du webService SMS", 10);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de joindre le serveur d'envoi SMS");
            }
        }

        //***********************************************************************************************
        private void dgvTechnicien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdxLigneActuelle = e.RowIndex;
            Materiel materiel = new Materiel();
            viderChamps();

            if (IdxLigneActuelle >= 0)
            {
                // On récupère le login du technicien de la ligne sélectionnée dans le dgvTechnicien
                string loginTechnicien = (string)dgvTechnicien.Rows[IdxLigneActuelle].Cells[2].Value;
                // On récupère l'indice de ce technicien dans la listTechnicien
                int indiceDansListTechnicien = listTechnicien.FindIndex(item => item.LoginT == loginTechnicien);
                // On récupère le technicien complet
                technicienSelectionne = listTechnicien[indiceDansListTechnicien];
                // On affiche les données du Technicien
                textBoxNom.Text = technicienSelectionne.Nom;
                textBoxPrenom.Text = technicienSelectionne.Prenom;
                // recherche du matériel affecté au technicien pour récupérer son numéro de téléphone
                int indiceDansListMateriel = listMateriel.FindIndex(materielRecherché => materielRecherché.IdMateriel == technicienSelectionne.FkIdMateriel);
                if (indiceDansListMateriel >= 0) // matériel trouvé si >=0
                {
                    materiel = listMateriel[indiceDansListMateriel];
                    mTxtBoxNumtel.Text = materiel.NumeroTel;
                }
                else
                {
                    mTxtBoxNumtel.ResetText();
                    MessageBox.Show("Ce technicien n'a pas de matériel affecté, rentrer manuellement un numéro");
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
        // Au chargement de la page on déselectionne la première cellule du dataGridView
        // Un try catch permet d'éviter attrape une exception rarissime si la table technicien est vide (Row null)
        private void EnvoiSMSForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvTechnicien.Rows[0].Selected = false;
            }
            catch { }
        }
        //**************************************************************************************************
        // validation du bouton envoyer sms s'il y a du texte qui est entré dans le textbox
        private void richTextBoxMessage_TextChanged(object sender, EventArgs e)
        {
            if ((mTxtBoxNumtel.Text != String.Empty) && (AccesWebServices.ConnexionDomy59Valid == true))
            {
                btnEnvoyerMessage.Enabled = true;
            }
        }
        //**************************************************************************************************
    }
}
