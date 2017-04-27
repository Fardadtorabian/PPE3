using System;
using System.Windows.Forms;
using LibDao;
using System.Collections.Generic;
using System.ComponentModel;
using GMap.NET.WindowsForms;
using GMap.NET;
using System.Globalization;
using GMap.NET.WindowsForms.Markers;

namespace Dispatcher
{
    //[System.ComponentModel.DesignerCategory("Form")]
    public partial class DispatcherForm : Form
    {
        const bool VIA_ACTIVE_DIRECTORY = true; // true si application fonctionne sur AD,
        // ATTENTION modification non automatique de la connexion à la BDD
        String VersionProg = "4.1";
        String VersionSql = "1.4";
        //**************************************************************************************************
        // Constructeur
        public DispatcherForm()
        {
            InitializeComponent();

            this.Text = this.Text + "  " + "Version Prog : " + VersionProg + "  Version SQL : " + VersionSql;
            lblValDureeTransport.Text = String.Empty;
            lblValDistance.Text = String.Empty;
        }
        //**************************************************************************************************
        // récupération propriétés utilisateur connecté sur le pc
        //**************************************************************************************************
        void recupererUtilisateurConnecte()
        {
            Employe employe = new Employe();
            // récupération du groupe de l'utilisateur
            if (VIA_ACTIVE_DIRECTORY == false)
            {
                // on est en local
                // Jeu de test
                UtilisateurConnecte.Login = employe.LoginE = "administrateur";
                UtilisateurConnecte.Prenom = employe.Prenom = "Sa";
                UtilisateurConnecte.Nom = employe.Nom = "ROOT";
                //UtilisateurConnecte.Groupe = employe.Groupe = "Inconnu";
                UtilisateurConnecte.Groupe = employe.Groupe = "Administration";
                //UtilisateurConnecte.Groupe = employe.Groupe = "Dispatcher";
                //UtilisateurConnecte.Groupe = employe.Groupe = "Commercial";
                //UtilisateurConnecte.Groupe = employe.Groupe= "Informatique";
                //UtilisateurConnecte.Groupe = employe.Groupe= "Recherche";
            }
            else
            {
                // on est sur l'AD
                // récupération information employé connecté sur AD
                InfoActiveDirectory infoActiveDirectory = new InfoActiveDirectory();
                employe = infoActiveDirectory.getEmployeFromAD(Environment.UserName);
            }
            if (employe != null)
            {
                UtilisateurConnecte.Groupe = employe.Groupe;
                UtilisateurConnecte.Login = employe.LoginE;
                // on persiste cet employé en BDD local
                try
                {
                    using (EmployeManager employeManager = new EmployeManager())
                    {
                        employeManager.ajoutModifEmploye(ref employe);
                        validMenu(employe.Groupe);
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
       
        //**************************************************************************************************
        // On affiche que les clients que l'on peut positionner, c.a.d. lat,long non nulles
        void afficherListeClients()
        {
            List<Client> listClients = null;
            try
            {
                using (Manager manager = new Manager())
                {
                    manager.getListe(ref listClients, "client");
                    // On rempli le dataGridView des clients qui ont des lat long non nulles
                    foreach (Client chaqueClient in listClients)
                    {
                        if (chaqueClient.Latitude != String.Empty && chaqueClient.Longitude != String.Empty)
                        {
                            dgvClient.Rows.Add(
                                chaqueClient.IdClient,
                                chaqueClient.Entreprise,
                                chaqueClient.Nom,
                                chaqueClient.Latitude,
                                chaqueClient.Longitude
                                );
                        }
                    }
                    // Trier le dataGridView par ordre alphabétique des noms d'entreprise 
                    dgvClient.Sort(dgvClient.Columns[1], ListSortDirection.Ascending);
                    dgvClient.Rows[2].Selected = false;
                }
            }
            catch (Exception ex)
            {

            }
        }

        //**************************************************************************************************
        // Vérification des connexions à la fin du chargement du formulaire
        //**************************************************************************************************
        private void DispatcherForm_Load(object sender, EventArgs e)
        {
            bool reponseTest = AccesWebServices.testAccesWS();
            if (!reponseTest)
            {
                MessageToast.Show("Pas de Vérification Email", "Erreur connexion internet", 10);
                MessageToast.Show("Pas d'envoi de SMS Disponible", "Erreur connexion internet", 10);
            }
            // On charge kes listes civilités et etatClient.
            // En cas d'échec à la BDD on ferme l'application
            try
            {
                recupererUtilisateurConnecte();
                ChargementListes.chargementDesListe();          
                afficherListeTechnicienActif();
                afficherListeClients();
                menuStripDispatcher.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit(); // on ferme l'application car pas de connexion BDD
            }
        }
        //**************************************************************************************************
        private void btnChargementDonnees_Click(object sender, EventArgs e)
        {
            overlayOne.Markers.Clear();
            dgvClient.Rows.Clear();
            dgvListeTechniciens.Rows.Clear();
            markerClient = null;
            markerTechnicienEnRouge = null;
            afficherListeTechnicienActif();
            afficherListeClients();
            lblValDureeTransport.Text = String.Empty;
            lblValDistance.Text = String.Empty;
        }

              
    }
}






