namespace Dispatcher
{
    partial class AjouterPlanningForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            Calendar.DrawTool drawTool1 = new Calendar.DrawTool();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange1 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange2 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange3 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange4 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange5 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dayView = new Calendar.DayView();
            this.lblSelectionClient = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtBoxPrenomContact = new System.Windows.Forms.TextBox();
            this.lblPrenomContact = new System.Windows.Forms.Label();
            this.lblNomContact = new System.Windows.Forms.Label();
            this.txtBoxNomContact = new System.Windows.Forms.TextBox();
            this.lblTelContact = new System.Windows.Forms.Label();
            this.mTxtBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.lblObjetVisite = new System.Windows.Forms.Label();
            this.txtBoxObjetVisite = new System.Windows.Forms.TextBox();
            this.pictureBoxImageIntervention = new System.Windows.Forms.PictureBox();
            this.lblImageLieuIntervention = new System.Windows.Forms.Label();
            this.lblSelectionTechnicien = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calendar1 = new System.Windows.Forms.Calendar.Calendar();
            this.lblValDureeInterv = new System.Windows.Forms.Label();
            this.lblDureeInterv = new System.Windows.Forms.Label();
            this.lblValFinInterv = new System.Windows.Forms.Label();
            this.lblFinInterv = new System.Windows.Forms.Label();
            this.lblValDebInter = new System.Windows.Forms.Label();
            this.lblHeureDdebutInter = new System.Windows.Forms.Label();
            this.BtnValidationIntervention = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.IdAbonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntreprise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTechnicien = new System.Windows.Forms.DataGridView();
            this.ColNomTech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrenomTech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLoginTech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModifierImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageIntervention)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicien)).BeginInit();
            this.SuspendLayout();
            // 
            // dayView
            // 
            drawTool1.DayView = this.dayView;
            this.dayView.ActiveTool = drawTool1;
            this.dayView.AmPmDisplay = false;
            this.dayView.AppHeightMode = Calendar.DayView.AppHeightDrawMode.TrueHeightAll;
            this.dayView.DrawAllAppBorder = false;
            this.dayView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayView.Location = new System.Drawing.Point(248, 8);
            this.dayView.MinHalfHourApp = false;
            this.dayView.Name = "dayView";
            this.dayView.SelectionEnd = new System.DateTime(((long)(0)));
            this.dayView.SelectionStart = new System.DateTime(((long)(0)));
            this.dayView.Size = new System.Drawing.Size(178, 383);
            this.dayView.SlotsPerHour = 2;
            this.dayView.StartDate = new System.DateTime(((long)(0)));
            this.dayView.TabIndex = 12;
            this.dayView.Text = "dayView1";
            this.dayView.SelectionChanged += new System.EventHandler(this.dayView_SelectionChanged);
            this.dayView.ResolveAppointments += new Calendar.ResolveAppointmentsEventHandler(this.dayView_ResolveAppointments);
            this.dayView.AppointmentMove += new System.EventHandler<Calendar.AppointmentEventArgs>(this.dayView_AppointmentMove);
            // 
            // lblSelectionClient
            // 
            this.lblSelectionClient.AutoSize = true;
            this.lblSelectionClient.Location = new System.Drawing.Point(20, 9);
            this.lblSelectionClient.Name = "lblSelectionClient";
            this.lblSelectionClient.Size = new System.Drawing.Size(100, 13);
            this.lblSelectionClient.TabIndex = 1;
            this.lblSelectionClient.Text = "Sélection du client :";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(33, 193);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(146, 13);
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = "Contact lors de l\'intervention :";
            // 
            // txtBoxPrenomContact
            // 
            this.txtBoxPrenomContact.Location = new System.Drawing.Point(112, 225);
            this.txtBoxPrenomContact.Name = "txtBoxPrenomContact";
            this.txtBoxPrenomContact.Size = new System.Drawing.Size(151, 20);
            this.txtBoxPrenomContact.TabIndex = 3;
            // 
            // lblPrenomContact
            // 
            this.lblPrenomContact.AutoSize = true;
            this.lblPrenomContact.Location = new System.Drawing.Point(33, 225);
            this.lblPrenomContact.Name = "lblPrenomContact";
            this.lblPrenomContact.Size = new System.Drawing.Size(52, 13);
            this.lblPrenomContact.TabIndex = 4;
            this.lblPrenomContact.Text = "Prenom : ";
            // 
            // lblNomContact
            // 
            this.lblNomContact.AutoSize = true;
            this.lblNomContact.Location = new System.Drawing.Point(33, 260);
            this.lblNomContact.Name = "lblNomContact";
            this.lblNomContact.Size = new System.Drawing.Size(38, 13);
            this.lblNomContact.TabIndex = 6;
            this.lblNomContact.Text = "Nom : ";
            // 
            // txtBoxNomContact
            // 
            this.txtBoxNomContact.Location = new System.Drawing.Point(112, 260);
            this.txtBoxNomContact.Name = "txtBoxNomContact";
            this.txtBoxNomContact.Size = new System.Drawing.Size(151, 20);
            this.txtBoxNomContact.TabIndex = 5;
            // 
            // lblTelContact
            // 
            this.lblTelContact.AutoSize = true;
            this.lblTelContact.Location = new System.Drawing.Point(33, 295);
            this.lblTelContact.Name = "lblTelContact";
            this.lblTelContact.Size = new System.Drawing.Size(67, 13);
            this.lblTelContact.TabIndex = 8;
            this.lblTelContact.Text = "Téléphone : ";
            // 
            // mTxtBoxTelephone
            // 
            this.mTxtBoxTelephone.BeepOnError = true;
            this.mTxtBoxTelephone.Location = new System.Drawing.Point(112, 290);
            this.mTxtBoxTelephone.Mask = "0000000000";
            this.mTxtBoxTelephone.Name = "mTxtBoxTelephone";
            this.mTxtBoxTelephone.PromptChar = ' ';
            this.mTxtBoxTelephone.Size = new System.Drawing.Size(70, 20);
            this.mTxtBoxTelephone.TabIndex = 16;
            this.mTxtBoxTelephone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mTxtBoxTelephone_MouseClick);
            // 
            // lblObjetVisite
            // 
            this.lblObjetVisite.AutoSize = true;
            this.lblObjetVisite.Location = new System.Drawing.Point(33, 332);
            this.lblObjetVisite.Name = "lblObjetVisite";
            this.lblObjetVisite.Size = new System.Drawing.Size(65, 13);
            this.lblObjetVisite.TabIndex = 17;
            this.lblObjetVisite.Text = "Objet visite :";
            // 
            // txtBoxObjetVisite
            // 
            this.txtBoxObjetVisite.Location = new System.Drawing.Point(112, 332);
            this.txtBoxObjetVisite.Multiline = true;
            this.txtBoxObjetVisite.Name = "txtBoxObjetVisite";
            this.txtBoxObjetVisite.Size = new System.Drawing.Size(151, 66);
            this.txtBoxObjetVisite.TabIndex = 18;
            // 
            // pictureBoxImageIntervention
            // 
            this.pictureBoxImageIntervention.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxImageIntervention.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxImageIntervention.Location = new System.Drawing.Point(298, 210);
            this.pictureBoxImageIntervention.Name = "pictureBoxImageIntervention";
            this.pictureBoxImageIntervention.Size = new System.Drawing.Size(166, 148);
            this.pictureBoxImageIntervention.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImageIntervention.TabIndex = 36;
            this.pictureBoxImageIntervention.TabStop = false;
            // 
            // lblImageLieuIntervention
            // 
            this.lblImageLieuIntervention.AutoSize = true;
            this.lblImageLieuIntervention.Location = new System.Drawing.Point(295, 193);
            this.lblImageLieuIntervention.Name = "lblImageLieuIntervention";
            this.lblImageLieuIntervention.Size = new System.Drawing.Size(119, 13);
            this.lblImageLieuIntervention.TabIndex = 37;
            this.lblImageLieuIntervention.Text = "Image lieu intervention :";
            // 
            // lblSelectionTechnicien
            // 
            this.lblSelectionTechnicien.AutoSize = true;
            this.lblSelectionTechnicien.Location = new System.Drawing.Point(344, 9);
            this.lblSelectionTechnicien.Name = "lblSelectionTechnicien";
            this.lblSelectionTechnicien.Size = new System.Drawing.Size(127, 13);
            this.lblSelectionTechnicien.TabIndex = 39;
            this.lblSelectionTechnicien.Text = "Sélection du technicien : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dayView);
            this.panel1.Controls.Add(this.calendar1);
            this.panel1.Controls.Add(this.lblValDureeInterv);
            this.panel1.Controls.Add(this.lblDureeInterv);
            this.panel1.Controls.Add(this.lblValFinInterv);
            this.panel1.Controls.Add(this.lblFinInterv);
            this.panel1.Controls.Add(this.lblValDebInter);
            this.panel1.Controls.Add(this.lblHeureDdebutInter);
            this.panel1.Controls.Add(this.BtnValidationIntervention);
            this.panel1.Controls.Add(this.monthCalendar);
            this.panel1.Location = new System.Drawing.Point(567, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 394);
            this.panel1.TabIndex = 40;
            // 
            // calendar1
            // 
            this.calendar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            calendarHighlightRange1.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange1.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange1.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange2.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange2.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange2.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange3.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange3.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange3.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange4.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange4.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange4.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange5.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange5.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange5.StartTime = System.TimeSpan.Parse("08:00:00");
            this.calendar1.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange1,
        calendarHighlightRange2,
        calendarHighlightRange3,
        calendarHighlightRange4,
        calendarHighlightRange5};
            this.calendar1.Location = new System.Drawing.Point(0, 0);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(0, 0);
            this.calendar1.TabIndex = 11;
            // 
            // lblValDureeInterv
            // 
            this.lblValDureeInterv.AutoSize = true;
            this.lblValDureeInterv.Location = new System.Drawing.Point(115, 266);
            this.lblValDureeInterv.Name = "lblValDureeInterv";
            this.lblValDureeInterv.Size = new System.Drawing.Size(0, 13);
            this.lblValDureeInterv.TabIndex = 8;
            // 
            // lblDureeInterv
            // 
            this.lblDureeInterv.AutoSize = true;
            this.lblDureeInterv.Location = new System.Drawing.Point(6, 266);
            this.lblDureeInterv.Name = "lblDureeInterv";
            this.lblDureeInterv.Size = new System.Drawing.Size(103, 13);
            this.lblDureeInterv.TabIndex = 7;
            this.lblDureeInterv.Text = "Durée intervention : ";
            // 
            // lblValFinInterv
            // 
            this.lblValFinInterv.AutoSize = true;
            this.lblValFinInterv.Location = new System.Drawing.Point(115, 235);
            this.lblValFinInterv.Name = "lblValFinInterv";
            this.lblValFinInterv.Size = new System.Drawing.Size(0, 13);
            this.lblValFinInterv.TabIndex = 6;
            // 
            // lblFinInterv
            // 
            this.lblFinInterv.AutoSize = true;
            this.lblFinInterv.Location = new System.Drawing.Point(6, 235);
            this.lblFinInterv.Name = "lblFinInterv";
            this.lblFinInterv.Size = new System.Drawing.Size(88, 13);
            this.lblFinInterv.TabIndex = 5;
            this.lblFinInterv.Text = "Fin intervention : ";
            // 
            // lblValDebInter
            // 
            this.lblValDebInter.AutoSize = true;
            this.lblValDebInter.Location = new System.Drawing.Point(115, 206);
            this.lblValDebInter.Name = "lblValDebInter";
            this.lblValDebInter.Size = new System.Drawing.Size(0, 13);
            this.lblValDebInter.TabIndex = 4;
            // 
            // lblHeureDdebutInter
            // 
            this.lblHeureDdebutInter.AutoSize = true;
            this.lblHeureDdebutInter.Location = new System.Drawing.Point(6, 206);
            this.lblHeureDdebutInter.Name = "lblHeureDdebutInter";
            this.lblHeureDdebutInter.Size = new System.Drawing.Size(103, 13);
            this.lblHeureDdebutInter.TabIndex = 3;
            this.lblHeureDdebutInter.Text = "Début intervention : ";
            // 
            // BtnValidationIntervention
            // 
            this.BtnValidationIntervention.Location = new System.Drawing.Point(34, 344);
            this.BtnValidationIntervention.Name = "BtnValidationIntervention";
            this.BtnValidationIntervention.Size = new System.Drawing.Size(159, 23);
            this.BtnValidationIntervention.TabIndex = 2;
            this.BtnValidationIntervention.Text = "Validation intervention";
            this.BtnValidationIntervention.UseVisualStyleBackColor = true;
            this.BtnValidationIntervention.Click += new System.EventHandler(this.BtnValidationIntervention_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(9, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAbonne,
            this.colEntreprise,
            this.colPrenom,
            this.colNom});
            this.dgvClient.Location = new System.Drawing.Point(12, 29);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClient.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClient.RowHeadersVisible = false;
            this.dgvClient.Size = new System.Drawing.Size(320, 157);
            this.dgvClient.TabIndex = 43;
            this.dgvClient.TabStop = false;
            this.dgvClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClient_CellClick);
            // 
            // IdAbonne
            // 
            this.IdAbonne.HeaderText = "Id";
            this.IdAbonne.Name = "IdAbonne";
            this.IdAbonne.ReadOnly = true;
            this.IdAbonne.Visible = false;
            // 
            // colEntreprise
            // 
            this.colEntreprise.HeaderText = "Entreprise";
            this.colEntreprise.MinimumWidth = 100;
            this.colEntreprise.Name = "colEntreprise";
            this.colEntreprise.ReadOnly = true;
            // 
            // colPrenom
            // 
            this.colPrenom.HeaderText = "Prénom";
            this.colPrenom.MinimumWidth = 100;
            this.colPrenom.Name = "colPrenom";
            this.colPrenom.ReadOnly = true;
            // 
            // colNom
            // 
            this.colNom.HeaderText = "Nom";
            this.colNom.MinimumWidth = 100;
            this.colNom.Name = "colNom";
            this.colNom.ReadOnly = true;
            // 
            // dgvTechnicien
            // 
            this.dgvTechnicien.AllowUserToAddRows = false;
            this.dgvTechnicien.AllowUserToDeleteRows = false;
            this.dgvTechnicien.AllowUserToOrderColumns = true;
            this.dgvTechnicien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechnicien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNomTech,
            this.ColPrenomTech,
            this.ColLoginTech});
            this.dgvTechnicien.Location = new System.Drawing.Point(347, 28);
            this.dgvTechnicien.Name = "dgvTechnicien";
            this.dgvTechnicien.ReadOnly = true;
            this.dgvTechnicien.RowHeadersVisible = false;
            this.dgvTechnicien.Size = new System.Drawing.Size(205, 158);
            this.dgvTechnicien.TabIndex = 44;
            this.dgvTechnicien.TabStop = false;
            this.dgvTechnicien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTechnicien_CellClick);
            // 
            // ColNomTech
            // 
            this.ColNomTech.HeaderText = "Nom";
            this.ColNomTech.Name = "ColNomTech";
            this.ColNomTech.ReadOnly = true;
            // 
            // ColPrenomTech
            // 
            this.ColPrenomTech.HeaderText = "Prenom";
            this.ColPrenomTech.Name = "ColPrenomTech";
            this.ColPrenomTech.ReadOnly = true;
            // 
            // ColLoginTech
            // 
            this.ColLoginTech.HeaderText = "Login";
            this.ColLoginTech.Name = "ColLoginTech";
            this.ColLoginTech.ReadOnly = true;
            this.ColLoginTech.Visible = false;
            // 
            // btnModifierImage
            // 
            this.btnModifierImage.Location = new System.Drawing.Point(333, 375);
            this.btnModifierImage.Name = "btnModifierImage";
            this.btnModifierImage.Size = new System.Drawing.Size(92, 23);
            this.btnModifierImage.TabIndex = 45;
            this.btnModifierImage.TabStop = false;
            this.btnModifierImage.Text = "Modifier l\'image";
            this.btnModifierImage.UseVisualStyleBackColor = true;
            this.btnModifierImage.Click += new System.EventHandler(this.btnModifierImage_Click);
            // 
            // AjouterPlanningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 410);
            this.Controls.Add(this.btnModifierImage);
            this.Controls.Add(this.dgvTechnicien);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSelectionTechnicien);
            this.Controls.Add(this.lblImageLieuIntervention);
            this.Controls.Add(this.pictureBoxImageIntervention);
            this.Controls.Add(this.txtBoxObjetVisite);
            this.Controls.Add(this.lblObjetVisite);
            this.Controls.Add(this.mTxtBoxTelephone);
            this.Controls.Add(this.lblTelContact);
            this.Controls.Add(this.lblNomContact);
            this.Controls.Add(this.txtBoxNomContact);
            this.Controls.Add(this.lblPrenomContact);
            this.Controls.Add(this.txtBoxPrenomContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblSelectionClient);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AjouterPlanningForm";
            this.Text = "Ajout Intervention";
            this.Load += new System.EventHandler(this.AjouterPlanningForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageIntervention)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectionClient;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtBoxPrenomContact;
        private System.Windows.Forms.Label lblPrenomContact;
        private System.Windows.Forms.Label lblNomContact;
        private System.Windows.Forms.TextBox txtBoxNomContact;
        private System.Windows.Forms.Label lblTelContact;
        private System.Windows.Forms.MaskedTextBox mTxtBoxTelephone;
        private System.Windows.Forms.Label lblObjetVisite;
        private System.Windows.Forms.TextBox txtBoxObjetVisite;
        private System.Windows.Forms.PictureBox pictureBoxImageIntervention;
        private System.Windows.Forms.Label lblImageLieuIntervention;
        private System.Windows.Forms.Label lblSelectionTechnicien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label lblValDureeInterv;
        private System.Windows.Forms.Label lblDureeInterv;
        private System.Windows.Forms.Label lblValFinInterv;
        private System.Windows.Forms.Label lblFinInterv;
        private System.Windows.Forms.Label lblValDebInter;
        private System.Windows.Forms.Label lblHeureDdebutInter;
        private System.Windows.Forms.Button BtnValidationIntervention;
        private System.Windows.Forms.Calendar.Calendar calendar1;
        private Calendar.DayView dayView;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAbonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntreprise;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom;
        private System.Windows.Forms.DataGridView dgvTechnicien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomTech;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrenomTech;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLoginTech;
        private System.Windows.Forms.Button btnModifierImage;
    }
}

