using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Calendar;
using LibDao;
using System.IO;

namespace Dispatcher
{
    public partial class ModifierInterventionForm : Form
    {
        List<Appointment> listRdvBdd = null; // liste des rendez-vous récupérés en BDD
        List<Appointment> listRdvAffiche = null; // liste des rendez-vous utilisés pour l'affichage calendar
        List<Intervention> listIntervention = null;
        Intervention interventionRdvSelectionne = null;

        private List<Technicien> listTechniciens = null;
        private List<Client> listClients = null;

        Technicien technicienSelectionne = null;
        DateTime debutRdv, finRdv;

        //**************************************************************************************************
        public ModifierInterventionForm()
        {
            InitializeComponent();
            // paramétrage du calendar
            dayView.Renderer = new Office12Renderer();
            dayView.HalfHourHeight = 17;
            dayView.StartHour = 8;
            dayView.WorkingHourEnd = 18;
            dayView.AllowScroll = false;
            // initialisation des dates du calendar (date d'aujourd'hui et des debut ef fin rdv pour détecter une
            // absence de sélection d'un rendez-vous
            dayView.StartDate = DateTime.Now.Date;
            debutRdv = dayView.StartDate; finRdv = dayView.StartDate;
            // on peut initialiser liste des clients et des techniciens cat non modifiées dans cette classe
            initialisationListeTechClient();
            // initialisation des datagridView
            InitialiserDGV();
            // Initialisation des listes
            listIntervention = new List<Intervention>();
            // liste des rendez-vous construite par lecture de la liste des interventions d'un technicien
            listRdvBdd = new List<Appointment>();
        }
        //**************************************************************************************************
        void initialisationListeTechClient()
        {

            using (Manager manager = new Manager())
            {
                // Récuperation de la liste des techniciens
                manager.getListe(ref listTechniciens, "technicien");
                // Récuperation de la liste des clients
                //listClients = clientManager.getListeClient();
                manager.getListe(ref listClients, "client");
            }

        }
        //**************************************************************************************************
        // Event déclenché lorsque la liste de rendez-vous a été modifiée
        // Cette méthode construit l'affichage des rendes-vous compris entre StartDate et EndDate 
        // à partir de la "listRdv" fournie. Le résultat est transmis à l'attribut "Appointments" de l'objet 
        // args transmis en paramètre (paramètre transmis par l'évènement)
        private void dayView_ResolveAppointments(object sender, ResolveAppointmentsEventArgs args)
        {
            listRdvAffiche = new List<Appointment>();
            foreach (Appointment rdv in listRdvBdd)
                if ((rdv.StartDate >= args.StartDate) &&
                    (rdv.StartDate <= args.EndDate))
                {
                    listRdvAffiche.Add(rdv);
                }
            args.Appointments = listRdvAffiche;
        }
        //**************************************************************************************************
        private void InitialiserDGV()
        {
            technicienSelectionne = null;
            List<int> listIdMaterielDispo = new List<int>();

            dgvTechnicien.Rows.Clear();
            // On rempli le dataGridView des Techniciens 
            foreach (Technicien chaqueTechnicien in listTechniciens)
            {
                dgvTechnicien.Rows.Add(
                    chaqueTechnicien.Nom,
                    chaqueTechnicien.Prenom,
                    chaqueTechnicien.LoginT);
            }
            // Trier par ordre alphabétique des noms le dataGridView
            dgvTechnicien.Sort(dgvTechnicien.Columns[0], ListSortDirection.Ascending);
            // Raz de l'affichage
            clearTextBox();
        }
        //**************************************************************************************************
        void clearTextBox()
        {
            // clear des textBox
            txtBoxPrenomContact.ResetText();
            txtBoxNomContact.ResetText();
            mTxtBoxTelephone.ResetText();
            txtBoxObjetVisite.ResetText();
            txtBoxNomEntreprise.ResetText();
            txtBoxPrenomClient.ResetText();
            txtBoxNomClient.ResetText();
            maskedTextBoxTelClient.ResetText();
            cboxEtatIntervention.ResetText();
            pictureBoxImageIntervention.Image = null;
            lblValDebInter.ResetText();
            lblValFinInterv.ResetText();
            lblValDureeInterv.ResetText();
        }

        //**************************************************************************************************
        // methode appelée lorsqu'on sélectionne un autre jour sur le calendrier
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            dayView.StartDate = monthCalendar.SelectionStart;
            if (technicienSelectionne != null)
            {
                affichePlanningTechnicien(technicienSelectionne);
            }
        }
        //**************************************************************************************************

        //**************************************************************************************************
        // méthode appelée lorque l'on sélectionne un rendez vous 
        private void dayView_SelectionChanged(object sender, EventArgs e)
        {
            if (dayView.Selection == SelectionType.Appointment)
            {
                debutRdv = dayView.SelectedAppointment.StartDate;
                finRdv = dayView.SelectedAppointment.EndDate;
                // affichage des valeurs du rendez-vous
                lblValDebInter.Text = debutRdv.ToString("HH:mm");
                lblValFinInterv.Text = finRdv.ToString("HH:mm");
                // calcul et affichage durée intervention
                TimeSpan dureeIntervention = finRdv - debutRdv;
                lblValDureeInterv.Text = dureeIntervention.ToString(@"h\:mm");
                // Récupération de l'intervention dans la liste des interventions
                // d'abord l'index dans la liste puis la valeur dans la liste
                int indiceDansListIntervention = listIntervention.FindIndex(intervention => intervention.IdIntervention == dayView.SelectedAppointment.Layer);
                interventionRdvSelectionne = listIntervention[indiceDansListIntervention];
                // Affichage des donnes dans les textBox etc...
                if (interventionRdvSelectionne.FkIdClient != 0) // as-t-on trouvé une intervention correspondant au RDV
                { // si oui on affiche les données de l'intervention
                    txtBoxPrenomContact.Text = interventionRdvSelectionne.PrenomContact;
                    txtBoxNomContact.Text = interventionRdvSelectionne.NomContact;
                    mTxtBoxTelephone.Text = interventionRdvSelectionne.TelContact;
                    txtBoxObjetVisite.Text = interventionRdvSelectionne.ObjectifVisite;
                    cboxEtatIntervention.Text = interventionRdvSelectionne.EtatVisite;
                    Byte[] image = interventionRdvSelectionne.PhotoLieu;
                    if (image == null || image.Length == 0)
                    {
                        pictureBoxImageIntervention.Image = null;
                    }
                    else
                    {
                        pictureBoxImageIntervention.Image = Utils.byteArrayToImage(image);
                    }
                    // Récupération du client 
                    Client client = listClients.Find(leClient => leClient.IdClient == interventionRdvSelectionne.FkIdClient);
                    // On affiche les données du client
                    txtBoxNomEntreprise.Text = client.Entreprise;
                    txtBoxPrenomClient.Text = client.Prenom;
                    txtBoxNomClient.Text = client.Nom;
                    maskedTextBoxTelClient.Text = client.NumeroTel;
                }
            }
        }
        //**************************************************************************************************
        // méthode appelée lorsque l'on change les valeurs début ou fin d'un rendez-vous
        //**************************************************************************************************
        private void dayView_AppointmentMove(object sender, AppointmentEventArgs e)
        {
            // On appelle la méthode évènementielle  "dayView_SelectionChanged" pour gérer le changement des heures du rdv
            dayView_SelectionChanged(this, e);
        }
        //**************************************************************************************************
        // Cette méthode récupère les rdv d'un technicien en BDD pour peupler la liste des rendez-vous à afficher
        //**************************************************************************************************      
        private void affichePlanningTechnicien(Technicien technicien)
        {
            // Raz des listes contenant les rdv affichées et les instreventions d'un technicien récupérées en BDD
            listRdvBdd.Clear();

            // Raz de l'affichage
            clearTextBox();

            // On charge la liste des rendez-vous d'un technicien pour un jour donné
            Intervention uneIntervention = new Intervention();
            uneIntervention.DebutIntervention = dayView.StartDate.Date;
            uneIntervention.FkLoginT = technicien.LoginT;
            try
            {
                using (InterventionManager interventionManager = new InterventionManager())
                {
                    listIntervention = interventionManager.listeInterventionsTechnicien(uneIntervention);
                    if (listIntervention != null)
                    {
                        foreach (Intervention chaqueIntervention in listIntervention)
                        {
                            // on peuple la liste des rdv a afficher 
                            Appointment rdv = new Appointment();
                            rdv.StartDate = chaqueIntervention.DebutIntervention;
                            rdv.EndDate = chaqueIntervention.FinIntervention;
                            rdv.BorderColor = Color.Red; // la couleur de l'entourage
                            rdv.Title = chaqueIntervention.ObjectifVisite; // le texte à l'intérieur du rdv
                            listRdvBdd.Add(rdv);
                            // On ajoute un tag (l'IdIntervention sur chaque rdv)
                            // IdIntervention sera récupérer grace à rdv.Layer de chaque rendez-vous
                            rdv.Layer = chaqueIntervention.IdIntervention;
                        }
                    }
                    else
                    {
                        Appointment rdv = new Appointment();
                        rdv.StartDate = dayView.StartDate;
                        rdv.EndDate = dayView.StartDate;
                        rdv.Title = String.Empty;
                    }
                    dayView.Invalidate(); // On force le controle à se redessiner
                }
            }
            catch (Exception ex)
            {

            }
        }
        //**************************************************************************************************
        //**************************************************************************************************
        private void dgvTechnicien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdxLigneActuelle = e.RowIndex;
            if (IdxLigneActuelle >= 0)
            {
                string loginTechnicien = (string)dgvTechnicien.Rows[IdxLigneActuelle].Cells[2].Value;
                int indiceDansListTechnicien = listTechniciens.FindIndex(item => item.LoginT == loginTechnicien);
                technicienSelectionne = listTechniciens[indiceDansListTechnicien];
                affichePlanningTechnicien(technicienSelectionne);
            }
        }
        //**************************************************************************************************
        // Choix d'une image pour l'intervention
        //**************************************************************************************************
        private void btnModifierImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                string CombinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\PhotosIntervention");
                dlg.InitialDirectory = System.IO.Path.GetFullPath(CombinedPath);
                dlg.Title = "Choisir le ficher image de l'intervention";
                dlg.Filter = "Fichers images| *.bmp; *.jpg; *.jpeg; *.gif; *.png"
                           + "|Fichiers bmp| *.bmp"
                           + "|Fichiers jpg/jpeg| *.jpg;*.jpeg"
                           + "|Fichiers gif| *.gif"
                           + "|Fichiers png| *.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                    this.pictureBoxImageIntervention.ImageLocation = dlg.FileName;
            }
        }
        //**************************************************************************************************
        // Enregistrement des nouvelles données de l'intervention
        //**************************************************************************************************
        private void BtnModificationIntervention_Click(object sender, EventArgs e)
        {
            if ((debutRdv != DateTime.Now.Date) && (technicienSelectionne != null) &&
                (interventionRdvSelectionne != null))
            {
                interventionRdvSelectionne.EtatVisite = cboxEtatIntervention.SelectedItem.ToString();
                if (interventionRdvSelectionne.EtatVisite != String.Empty) // EtatVisite doit être renseigné
                {
                    interventionRdvSelectionne.DebutIntervention = debutRdv;
                    interventionRdvSelectionne.FinIntervention = finRdv;
                    interventionRdvSelectionne.ObjectifVisite = txtBoxObjetVisite.Text;
                    // récupération image
                    if (pictureBoxImageIntervention.Image == null)
                        interventionRdvSelectionne.PhotoLieu = new Byte[0];  // tableau de byte vide
                    else
                        interventionRdvSelectionne.PhotoLieu = Utils.imageToByteArray(pictureBoxImageIntervention.Image);
                    // les champs des textBox
                    interventionRdvSelectionne.PrenomContact = txtBoxPrenomContact.Text.Trim();
                    interventionRdvSelectionne.NomContact = txtBoxNomContact.Text.Trim();
                    interventionRdvSelectionne.TelContact = mTxtBoxTelephone.Text.Trim();
                    interventionRdvSelectionne.FkLoginE = UtilisateurConnecte.Login;
                    using (InterventionManager interventionManager = new InterventionManager())
                    {
                        // On persiste l'entité en BDD
                        interventionManager.updateIntervention(interventionRdvSelectionne);
                    }
                    affichePlanningTechnicien(technicienSelectionne);
                    interventionRdvSelectionne = null;
                }
                else
                {
                    MessageToast.Show("Ne pas laisser l'état visite vide");
                }
            }
            else
            {
                MessageToast.Show("sélectionner un rendez-vous, un technicien");
            }
        }
        //**************************************************************************************************
        // permet de placer le curseur de saisie a gauche de la maskTextBox
        //**************************************************************************************************
        private void mTxtBoxTelephone_MouseClick(object sender, MouseEventArgs e)
        {
            mTxtBoxTelephone.SelectionStart = 0;
        }
        //**************************************************************************************************
        // Au chargement de la page on déselectionne la première cellule du dataGridView
        // Un try catch permet d'éviter attrape une exception rarissime si la table client est vide (Row null)
        //**************************************************************************************************
        private void ModifierInterventionForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvTechnicien.Rows[0].Selected = false;
            }
            catch { }
        }

        //**************************************************************************************************
    }
}
