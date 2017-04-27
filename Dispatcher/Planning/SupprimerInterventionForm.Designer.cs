namespace Dispatcher
{
    partial class SupprimerInterventionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Calendar.DrawTool drawTool1 = new Calendar.DrawTool();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange1 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange2 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange3 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange4 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange5 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            this.dayView = new Calendar.DayView();
            this.dgvTechnicien = new System.Windows.Forms.DataGridView();
            this.ColNomTech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrenomTech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLoginTech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSelectionTechnicien = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calendar1 = new System.Windows.Forms.Calendar.Calendar();
            this.lblValDureeInterv = new System.Windows.Forms.Label();
            this.lblDureeInterv = new System.Windows.Forms.Label();
            this.lblValFinInterv = new System.Windows.Forms.Label();
            this.lblFinInterv = new System.Windows.Forms.Label();
            this.lblValDebInter = new System.Windows.Forms.Label();
            this.lblHeureDdebutInter = new System.Windows.Forms.Label();
            this.BtnSupprimerIntervention = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicien)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dayView.HalfHourHeight = 17;
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
            this.dgvTechnicien.Location = new System.Drawing.Point(12, 47);
            this.dgvTechnicien.Name = "dgvTechnicien";
            this.dgvTechnicien.ReadOnly = true;
            this.dgvTechnicien.RowHeadersVisible = false;
            this.dgvTechnicien.Size = new System.Drawing.Size(205, 158);
            this.dgvTechnicien.TabIndex = 46;
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
            // lblSelectionTechnicien
            // 
            this.lblSelectionTechnicien.AutoSize = true;
            this.lblSelectionTechnicien.Location = new System.Drawing.Point(18, 21);
            this.lblSelectionTechnicien.Name = "lblSelectionTechnicien";
            this.lblSelectionTechnicien.Size = new System.Drawing.Size(127, 13);
            this.lblSelectionTechnicien.TabIndex = 45;
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
            this.panel1.Controls.Add(this.BtnSupprimerIntervention);
            this.panel1.Controls.Add(this.monthCalendar);
            this.panel1.Location = new System.Drawing.Point(232, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 421);
            this.panel1.TabIndex = 47;
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
            // BtnSupprimerIntervention
            // 
            this.BtnSupprimerIntervention.Location = new System.Drawing.Point(34, 344);
            this.BtnSupprimerIntervention.Name = "BtnSupprimerIntervention";
            this.BtnSupprimerIntervention.Size = new System.Drawing.Size(159, 23);
            this.BtnSupprimerIntervention.TabIndex = 2;
            this.BtnSupprimerIntervention.Text = "Supprimer intervention";
            this.BtnSupprimerIntervention.UseVisualStyleBackColor = true;
            this.BtnSupprimerIntervention.Click += new System.EventHandler(this.BtnSupprimerIntervention_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(9, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // SupprimerInterventionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTechnicien);
            this.Controls.Add(this.lblSelectionTechnicien);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(674, 466);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(674, 466);
            this.Name = "SupprimerInterventionForm";
            this.Text = "Supprimer intervention";
            this.Load += new System.EventHandler(this.SupprimerInterventionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTechnicien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomTech;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrenomTech;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLoginTech;
        private System.Windows.Forms.Label lblSelectionTechnicien;
        private System.Windows.Forms.Panel panel1;
        private Calendar.DayView dayView;
        private System.Windows.Forms.Calendar.Calendar calendar1;
        private System.Windows.Forms.Label lblValDureeInterv;
        private System.Windows.Forms.Label lblDureeInterv;
        private System.Windows.Forms.Label lblValFinInterv;
        private System.Windows.Forms.Label lblFinInterv;
        private System.Windows.Forms.Label lblValDebInter;
        private System.Windows.Forms.Label lblHeureDdebutInter;
        private System.Windows.Forms.Button BtnSupprimerIntervention;
        private System.Windows.Forms.MonthCalendar monthCalendar;
    }
}