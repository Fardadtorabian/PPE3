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
    public partial class AjouterPlanningForm : Form
    {
        List<Appointment> listRdv = null; // liste des rendez-vous utilisés pour l'affichage calendar
        List<Intervention> listIntervention = null;
        private List<Technicien> listTechniciens = null;
        Technicien technicienSelectionne = null;
        private List<Client> listClient = null;
        Client clientSelectionne = null;
        DateTime debutRdv, finRdv;

        //**************************************************************************************************
        public AjouterPlanningForm()
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
            // initialisation des datagridView
            InitialiserDGV();
            // Initialisation des listes
            listIntervention = new List<Intervention>();
            listRdv = new List<Appointment>();
        }

        //**************************************************************************************************
        // Event déclenché lorsque un nouveau rdv a été réalisé
        private void dayView_ResolveAppointments(object sender, ResolveAppointmentsEventArgs args)
        {
            List<Appointment> malistRdv = new List<Appointment>();
            foreach (Appointment rdv in listRdv)
                if ((rdv.StartDate >= args.StartDate) &&
                    (rdv.StartDate <= args.EndDate))
                    malistRdv.Add(rdv);
            args.Appointments = malistRdv;
        }
        //**************************************************************************************************
        private void InitialiserDGV()
        {
            technicienSelectionne = null;
            List<int> listIdMaterielDispo = new List<int>();

            dgvTechnicien.Rows.Clear();
            // Récupération de la liste des techniciens et des clients
            using (Manager manager = new Manager())
            {
                // créer un liste de clients et récupère les clients de la BDD
                manager.getListe(ref listClient, "client");
                // Récuperation de la liste des techniciens
                manager.getListe(ref listTechniciens, "technicien");
            }

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
            // On rempli le dataGridView des Clients
            foreach (Client chaqueClient in listClient)
            {
                dgvClient.Rows.Add(
                    chaqueClient.IdClient,
                    chaqueClient.Entreprise,
                    chaqueClient.Prenom,
                    chaqueClient.Nom);
            }
            // Trie par ordre alphabétique des noms
            dgvClient.Sort(dgvClient.Columns[3], ListSortDirection.Ascending);

            // clear des textBox
            txtBoxPrenomContact.ResetText();
            txtBoxNomContact.ResetText();
            mTxtBoxTelephone.ResetText();
            txtBoxObjetVisite.ResetText();
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
        // méthode appelée lorsqu'on change la sélection d'heure sur le calendar
        private void dayView_SelectionChanged(object sender, EventArgs e)
        {
            if (dayView.Selection == SelectionType.DateRange) // on sélectionne une plage horaire
            {
                lblValDebInter.Text = dayView.SelectionStart.ToString("HH:mm");
                lblValFinInterv.Text = dayView.SelectionEnd.ToString("HH:mm");
                debutRdv = dayView.SelectionStart;
                finRdv = dayView.SelectionEnd;
            }
            // détection d'une sélection de rendez-vous existant
            else if (dayView.Selection == SelectionType.Appointment)
            {
                debutRdv = dayView.StartDate;
                lblValDebInter.Text = "";
                finRdv = dayView.StartDate;
                lblValFinInterv.Text = "";
            }
            TimeSpan dureeIntervention = finRdv - debutRdv;
            lblValDureeInterv.Text = dureeIntervention.ToString(@"h\:mm");
        }
        //**************************************************************************************************
        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdxLigneActuelle = e.RowIndex;

            if (IdxLigneActuelle >= 0)
            {
                int idClient = (int)dgvClient.Rows[IdxLigneActuelle].Cells[0].Value;
                int indiceDansListClient = listClient.FindIndex(s => s.IdClient == idClient);
                clientSelectionne = listClient[indiceDansListClient];
                // recupère les données du client
                txtBoxNomContact.Text = clientSelectionne.Nom;
                txtBoxPrenomContact.Text = clientSelectionne.Prenom;
                mTxtBoxTelephone.Text = clientSelectionne.NumeroTel;
                String civilite = dgvClient.Rows[IdxLigneActuelle].Cells[2].Value.ToString();
                Byte[] image = clientSelectionne.Photoent;
                if (image == null || image.Length == 0)
                {
                    pictureBoxImageIntervention.Image = null;
                }
                else
                {
                    pictureBoxImageIntervention.Image = Utils.byteArrayToImage(image);
                }
            }
        }
        //**************************************************************************************************
        private void affichePlanningTechnicien(Technicien technicien)
        {
            listRdv.Clear();

            dayView.Refresh();
            dayView.Invalidate(); // On force le controle à ce redessiner

            if (listIntervention == null)
            {
                listIntervention = new List<Intervention>();
            }
            listIntervention.Clear();
            Intervention uneIntervention = new Intervention();
            uneIntervention.DebutIntervention = dayView.StartDate.Date;
            uneIntervention.FkLoginT = technicien.LoginT;
            try
            {
                using (InterventionManager interventionManager = new InterventionManager())
                {
                    listIntervention = interventionManager.listeInterventionsTechnicien(uneIntervention);

                    foreach (Intervention chaqueIntervention in listIntervention)
                    {
                        Appointment rdv = new Appointment();
                        rdv.StartDate = chaqueIntervention.DebutIntervention;
                        rdv.EndDate = chaqueIntervention.FinIntervention;
                        rdv.BorderColor = Color.Red;
                        rdv.Title = chaqueIntervention.ObjectifVisite;
                        listRdv.Add(rdv);
                    }
                    dayView.Invalidate(); // On force le controle à ce redessiner
                }
            }
            catch (Exception ex)
            {

            }
        }

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
        private void BtnValidationIntervention_Click(object sender, EventArgs e)
        {
            Intervention intervention = new Intervention();
            intervention.CompteRendu = string.Empty;
            if ((debutRdv != DateTime.Now.Date) && (technicienSelectionne != null) && (clientSelectionne != null))
            {
                intervention.DebutIntervention = debutRdv;
                intervention.FinIntervention = finRdv;
                intervention.ObjectifVisite = txtBoxObjetVisite.Text;
                // récupération image
                if (pictureBoxImageIntervention.Image == null)
                    intervention.PhotoLieu = new Byte[0];  // null
                else
                    intervention.PhotoLieu = Utils.imageToByteArray(pictureBoxImageIntervention.Image);
                // les champs des textBox
                intervention.PrenomContact = txtBoxPrenomContact.Text.Trim();
                intervention.NomContact = txtBoxNomContact.Text.Trim();
                intervention.TelContact = mTxtBoxTelephone.Text.Trim();
                intervention.EtatVisite = "planifiée";

                intervention.FkLoginE = UtilisateurConnecte.Login;
                intervention.FkIdClient = clientSelectionne.IdClient;
                intervention.FkLoginT = technicienSelectionne.LoginT;
                using (InterventionManager interventionManager = new InterventionManager())
                {
                    // On persiste l'entité en BDD
                    interventionManager.ajouterIntervention(intervention);
                }
                affichePlanningTechnicien(technicienSelectionne);
            }
            else
            {
                MessageToast.Show("sélectionner l'heure RDV, technicien et client");
            }
        }
        //**************************************************************************************************
        private void dayView_AppointmentMove(object sender, AppointmentEventArgs e)
        {
            MessageBox.Show("ne pas modifier ce rdv, merci");
            affichePlanningTechnicien(technicienSelectionne);
        }
        //**************************************************************************************************
        // permet de placer le curseur de saisie a gauche de la maskTextBox
        private void mTxtBoxTelephone_MouseClick(object sender, MouseEventArgs e)
        {
            mTxtBoxTelephone.SelectionStart = 0;
        }
        //**************************************************************************************************
        // Au chargement de la page on déselectionne la première cellule du dataGridView
        // Un try catch permet d'éviter attrape une exception rarissime si la table client est vide (Row null)
        private void AjouterPlanningForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvClient.Rows[0].Selected = false;
                dgvTechnicien.Rows[0].Selected = false;
            }
            catch { }
        }
        //**************************************************************************************************
    }
}

