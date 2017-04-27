using Calendar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using LibDao;

namespace Dispatcher
{
    public partial class SupprimerInterventionForm : Form
    {
        List<Appointment> listRdv = null; // liste des rendez-vous utilisée pour l'affichage calendar
        List<Intervention> listIntervention = null;
        private List<Technicien> listTechniciens = null;
        Technicien technicienSelectionne = null;

        DateTime debutRdv, finRdv;
        //**************************************************************************************************
        public SupprimerInterventionForm()
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
        }
        //**************************************************************************************************
        // methode appelée lorsqu'on sélectionne un autre jour sur le calendrier
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {       
            if(monthCalendar.SelectionStart< DateTime.Now.Date)
            {
                // On ne modifie pas le dayView.StartDate 
                // On sinterdir de supprimer un rendez vous antérier à la date du jour
                MessageToast.Show("Erreur de sélection de jour");
            }
            else
            {
                dayView.StartDate = monthCalendar.SelectionStart;
                if (technicienSelectionne != null)
                {
                    affichePlanningTechnicien(technicienSelectionne);
                }
                else
                {
                    MessageToast.Show("Sélectionner un technicien");
                }
            }           
        }
        //**************************************************************************************************
        // méthode appelée lorsqu'on change la sélection d'heure sur le calendar
        private void dayView_SelectionChanged(object sender, EventArgs e)
        {
            if (dayView.Selection == SelectionType.Appointment) // on selectionne un rdv existant
            {
                debutRdv = dayView.SelectedAppointment.StartDate;
                finRdv = dayView.SelectedAppointment.EndDate;
                lblValDebInter.Text = debutRdv.ToString("HH:mm");
                lblValFinInterv.Text = finRdv.ToString("HH:mm");
                TimeSpan dureeIntervention = finRdv - debutRdv;
                lblValDureeInterv.Text = dureeIntervention.ToString(@"h\:mm");
            }

        }

        //**************************************************************************************************
        private void affichePlanningTechnicien(Technicien technicien)
        {
            // RAZ des listes de rendez-vous et d'interventions
            listRdv.Clear();
            // Raz affichage
            lblValDebInter.ResetText();
            lblValFinInterv.ResetText();
            lblValDureeInterv.ResetText();

            // Chargement des interventions du jour d'un technicien et peuplement de la liste des rdv à afficher
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
                            listRdv.Add(rdv);
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
                    dayView.Invalidate(); // On force le conrole à ce redessiner
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
        private void BtnSupprimerIntervention_Click(object sender, EventArgs e)
        {
            Intervention interventionASupprimer = new Intervention();
            if ((debutRdv != DateTime.Now.Date) && (technicienSelectionne != null))
            {
                interventionASupprimer.FkLoginT = technicienSelectionne.LoginT;
                interventionASupprimer.DebutIntervention = debutRdv;

                using (InterventionManager interventionManager = new InterventionManager())
                {
                    interventionManager.supprimerIntervention(interventionASupprimer);
                }
                affichePlanningTechnicien(technicienSelectionne);
            }
            else
            {
                MessageToast.Show("Sélectionner technicien et rendez-vous");
            }
        }
        //**************************************************************************************************
        // Au chargement de la page on déselectionne la première cellule du dataGridView
        // Un try catch permet d'éviter attrape une exception rarissime si la table client est vide (Row null)
        private void SupprimerInterventionForm_Load(object sender, EventArgs e)
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

