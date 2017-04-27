namespace Dispatcher
{
    partial class DispatcherForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStripDispatcher = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemClient = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemIntervention = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItemIntervention = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItemIntervention = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aperçuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envoiSMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionMatérielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterMaterielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierMatérielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affecterMaterielAUnTechnicienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TechnicienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjoutTechnicienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierTechnicienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestataireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gMapDispatcher = new GMap.NET.WindowsForms.GMapControl();
            this.dgvListeTechniciens = new System.Windows.Forms.DataGridView();
            this.ColLoginT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrenomTech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNomTech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudeT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudeT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.IdAbonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntreprise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudeC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudeC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblValDistance = new System.Windows.Forms.Label();
            this.lblDureeTransport = new System.Windows.Forms.Label();
            this.lblValDureeTransport = new System.Windows.Forms.Label();
            this.btnChargementDonnees = new System.Windows.Forms.Button();
            this.menuStripDispatcher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeTechniciens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripDispatcher
            // 
            this.menuStripDispatcher.Enabled = false;
            this.menuStripDispatcher.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemClient,
            this.toolStripMenuItemIntervention,
            this.envoiSMSToolStripMenuItem,
            this.gestionMatérielToolStripMenuItem,
            this.TechnicienToolStripMenuItem,
            this.prestataireToolStripMenuItem});
            this.menuStripDispatcher.Location = new System.Drawing.Point(0, 0);
            this.menuStripDispatcher.Name = "menuStripDispatcher";
            this.menuStripDispatcher.Size = new System.Drawing.Size(804, 24);
            this.menuStripDispatcher.TabIndex = 0;
            this.menuStripDispatcher.Text = "menuStripDispatcher";
            // 
            // toolStripMenuItemClient
            // 
            this.toolStripMenuItemClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterClientToolStripMenuItem,
            this.modifierClientToolStripMenuItem});
            this.toolStripMenuItemClient.Enabled = false;
            this.toolStripMenuItemClient.Name = "toolStripMenuItemClient";
            this.toolStripMenuItemClient.Size = new System.Drawing.Size(93, 20);
            this.toolStripMenuItemClient.Text = "Gestion Client";
            // 
            // ajouterClientToolStripMenuItem
            // 
            this.ajouterClientToolStripMenuItem.Enabled = false;
            this.ajouterClientToolStripMenuItem.Name = "ajouterClientToolStripMenuItem";
            this.ajouterClientToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ajouterClientToolStripMenuItem.Text = "Ajouter";
            this.ajouterClientToolStripMenuItem.Click += new System.EventHandler(this.ajouterClientToolStripMenuItem_Click);
            // 
            // modifierClientToolStripMenuItem
            // 
            this.modifierClientToolStripMenuItem.Enabled = false;
            this.modifierClientToolStripMenuItem.Name = "modifierClientToolStripMenuItem";
            this.modifierClientToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.modifierClientToolStripMenuItem.Text = "Modifier/Supprimer";
            this.modifierClientToolStripMenuItem.Click += new System.EventHandler(this.modifierClientToolStripMenuItem_Click);
            // 
            // toolStripMenuItemIntervention
            // 
            this.toolStripMenuItemIntervention.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItemIntervention,
            this.supprimerToolStripMenuItemIntervention,
            this.modifierToolStripMenuItem,
            this.aperçuToolStripMenuItem});
            this.toolStripMenuItemIntervention.Enabled = false;
            this.toolStripMenuItemIntervention.Name = "toolStripMenuItemIntervention";
            this.toolStripMenuItemIntervention.Size = new System.Drawing.Size(134, 20);
            this.toolStripMenuItemIntervention.Text = "Gestion  interventions";
            // 
            // ajouterToolStripMenuItemIntervention
            // 
            this.ajouterToolStripMenuItemIntervention.Enabled = false;
            this.ajouterToolStripMenuItemIntervention.Name = "ajouterToolStripMenuItemIntervention";
            this.ajouterToolStripMenuItemIntervention.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItemIntervention.Text = "Ajouter";
            this.ajouterToolStripMenuItemIntervention.Click += new System.EventHandler(this.ajouterToolStripMenuItemIntervention_Click);
            // 
            // supprimerToolStripMenuItemIntervention
            // 
            this.supprimerToolStripMenuItemIntervention.Enabled = false;
            this.supprimerToolStripMenuItemIntervention.Name = "supprimerToolStripMenuItemIntervention";
            this.supprimerToolStripMenuItemIntervention.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItemIntervention.Text = "Supprimer";
            this.supprimerToolStripMenuItemIntervention.Click += new System.EventHandler(this.supprimerToolStripMenuItemIntervention_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Enabled = false;
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // aperçuToolStripMenuItem
            // 
            this.aperçuToolStripMenuItem.Enabled = false;
            this.aperçuToolStripMenuItem.Name = "aperçuToolStripMenuItem";
            this.aperçuToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.aperçuToolStripMenuItem.Text = "Aperçu";
            this.aperçuToolStripMenuItem.Click += new System.EventHandler(this.aperçuToolStripMenuItem_Click);
            // 
            // envoiSMSToolStripMenuItem
            // 
            this.envoiSMSToolStripMenuItem.Enabled = false;
            this.envoiSMSToolStripMenuItem.Name = "envoiSMSToolStripMenuItem";
            this.envoiSMSToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.envoiSMSToolStripMenuItem.Text = "Envoi SMS";
            this.envoiSMSToolStripMenuItem.Click += new System.EventHandler(this.envoiSMSToolStripMenuItem_Click);
            // 
            // gestionMatérielToolStripMenuItem
            // 
            this.gestionMatérielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterMaterielToolStripMenuItem,
            this.modifierMatérielToolStripMenuItem,
            this.affecterMaterielAUnTechnicienToolStripMenuItem});
            this.gestionMatérielToolStripMenuItem.Enabled = false;
            this.gestionMatérielToolStripMenuItem.Name = "gestionMatérielToolStripMenuItem";
            this.gestionMatérielToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.gestionMatérielToolStripMenuItem.Text = "Gestion Matériel";
            // 
            // ajouterMaterielToolStripMenuItem
            // 
            this.ajouterMaterielToolStripMenuItem.Enabled = false;
            this.ajouterMaterielToolStripMenuItem.Name = "ajouterMaterielToolStripMenuItem";
            this.ajouterMaterielToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ajouterMaterielToolStripMenuItem.Text = "Ajouter";
            this.ajouterMaterielToolStripMenuItem.Click += new System.EventHandler(this.ajouterMaterielToolStripMenuItem_Click);
            // 
            // modifierMatérielToolStripMenuItem
            // 
            this.modifierMatérielToolStripMenuItem.Enabled = false;
            this.modifierMatérielToolStripMenuItem.Name = "modifierMatérielToolStripMenuItem";
            this.modifierMatérielToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.modifierMatérielToolStripMenuItem.Text = "Modifier";
            this.modifierMatérielToolStripMenuItem.Click += new System.EventHandler(this.modifierMatérielToolStripMenuItem_Click);
            // 
            // affecterMaterielAUnTechnicienToolStripMenuItem
            // 
            this.affecterMaterielAUnTechnicienToolStripMenuItem.Enabled = false;
            this.affecterMaterielAUnTechnicienToolStripMenuItem.Name = "affecterMaterielAUnTechnicienToolStripMenuItem";
            this.affecterMaterielAUnTechnicienToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.affecterMaterielAUnTechnicienToolStripMenuItem.Text = "Affecter matériel";
            this.affecterMaterielAUnTechnicienToolStripMenuItem.Click += new System.EventHandler(this.affecterMaterielAUnTechnicienToolStripMenuItem_Click);
            // 
            // TechnicienToolStripMenuItem
            // 
            this.TechnicienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAjoutTechnicienToolStripMenuItem,
            this.modifierTechnicienToolStripMenuItem});
            this.TechnicienToolStripMenuItem.Enabled = false;
            this.TechnicienToolStripMenuItem.Name = "TechnicienToolStripMenuItem";
            this.TechnicienToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.TechnicienToolStripMenuItem.Text = "Gestion techniciens";
            // 
            // mAjoutTechnicienToolStripMenuItem
            // 
            this.mAjoutTechnicienToolStripMenuItem.Enabled = false;
            this.mAjoutTechnicienToolStripMenuItem.Name = "mAjoutTechnicienToolStripMenuItem";
            this.mAjoutTechnicienToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.mAjoutTechnicienToolStripMenuItem.Text = "Ajouter technicien";
            this.mAjoutTechnicienToolStripMenuItem.Click += new System.EventHandler(this.mAjoutTechnicienToolStripMenuItem_Click);
            // 
            // modifierTechnicienToolStripMenuItem
            // 
            this.modifierTechnicienToolStripMenuItem.Enabled = false;
            this.modifierTechnicienToolStripMenuItem.Name = "modifierTechnicienToolStripMenuItem";
            this.modifierTechnicienToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.modifierTechnicienToolStripMenuItem.Text = "Modifier";
            this.modifierTechnicienToolStripMenuItem.Click += new System.EventHandler(this.modifierTechnicienToolStripMenuItem_Click);
            // 
            // prestataireToolStripMenuItem
            // 
            this.prestataireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem});
            this.prestataireToolStripMenuItem.Name = "prestataireToolStripMenuItem";
            this.prestataireToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.prestataireToolStripMenuItem.Text = "Prestataire";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // gMapDispatcher
            // 
            this.gMapDispatcher.Bearing = 0F;
            this.gMapDispatcher.CanDragMap = true;
            this.gMapDispatcher.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapDispatcher.GrayScaleMode = false;
            this.gMapDispatcher.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapDispatcher.LevelsKeepInMemmory = 5;
            this.gMapDispatcher.Location = new System.Drawing.Point(208, 59);
            this.gMapDispatcher.MarkersEnabled = true;
            this.gMapDispatcher.MaxZoom = 2;
            this.gMapDispatcher.MinZoom = 2;
            this.gMapDispatcher.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapDispatcher.Name = "gMapDispatcher";
            this.gMapDispatcher.NegativeMode = false;
            this.gMapDispatcher.PolygonsEnabled = true;
            this.gMapDispatcher.RetryLoadTile = 0;
            this.gMapDispatcher.RoutesEnabled = true;
            this.gMapDispatcher.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapDispatcher.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapDispatcher.ShowTileGridLines = false;
            this.gMapDispatcher.Size = new System.Drawing.Size(553, 466);
            this.gMapDispatcher.TabIndex = 1;
            this.gMapDispatcher.Zoom = 0D;
            this.gMapDispatcher.Load += new System.EventHandler(this.gMapDispatcher_Load);
            // 
            // dgvListeTechniciens
            // 
            this.dgvListeTechniciens.AllowUserToAddRows = false;
            this.dgvListeTechniciens.AllowUserToDeleteRows = false;
            this.dgvListeTechniciens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListeTechniciens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListeTechniciens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeTechniciens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColLoginT,
            this.ColPrenomTech,
            this.ColNomTech,
            this.latitudeT,
            this.longitudeT});
            this.dgvListeTechniciens.Location = new System.Drawing.Point(12, 59);
            this.dgvListeTechniciens.MultiSelect = false;
            this.dgvListeTechniciens.Name = "dgvListeTechniciens";
            this.dgvListeTechniciens.ReadOnly = true;
            this.dgvListeTechniciens.RowHeadersVisible = false;
            this.dgvListeTechniciens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListeTechniciens.Size = new System.Drawing.Size(169, 213);
            this.dgvListeTechniciens.TabIndex = 80;
            this.dgvListeTechniciens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeTechniciens_CellClick);
            // 
            // ColLoginT
            // 
            this.ColLoginT.HeaderText = "LoginT";
            this.ColLoginT.Name = "ColLoginT";
            this.ColLoginT.ReadOnly = true;
            this.ColLoginT.Visible = false;
            // 
            // ColPrenomTech
            // 
            this.ColPrenomTech.FillWeight = 81.21828F;
            this.ColPrenomTech.HeaderText = "Prénom";
            this.ColPrenomTech.MinimumWidth = 80;
            this.ColPrenomTech.Name = "ColPrenomTech";
            this.ColPrenomTech.ReadOnly = true;
            // 
            // ColNomTech
            // 
            this.ColNomTech.FillWeight = 118.7817F;
            this.ColNomTech.HeaderText = "Nom";
            this.ColNomTech.MinimumWidth = 100;
            this.ColNomTech.Name = "ColNomTech";
            this.ColNomTech.ReadOnly = true;
            // 
            // latitudeT
            // 
            this.latitudeT.HeaderText = "latitude";
            this.latitudeT.Name = "latitudeT";
            this.latitudeT.ReadOnly = true;
            this.latitudeT.Visible = false;
            // 
            // longitudeT
            // 
            this.longitudeT.HeaderText = "longitude";
            this.longitudeT.Name = "longitudeT";
            this.longitudeT.ReadOnly = true;
            this.longitudeT.Visible = false;
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.AllowUserToResizeRows = false;
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
            this.colNom,
            this.latitudeC,
            this.longitudeC});
            this.dgvClient.Location = new System.Drawing.Point(12, 278);
            this.dgvClient.MultiSelect = false;
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
            this.dgvClient.RowTemplate.ReadOnly = true;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.ShowEditingIcon = false;
            this.dgvClient.Size = new System.Drawing.Size(169, 227);
            this.dgvClient.TabIndex = 81;
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
            // colNom
            // 
            this.colNom.HeaderText = "Nom";
            this.colNom.MinimumWidth = 100;
            this.colNom.Name = "colNom";
            this.colNom.ReadOnly = true;
            // 
            // latitudeC
            // 
            this.latitudeC.HeaderText = "latitude";
            this.latitudeC.Name = "latitudeC";
            this.latitudeC.ReadOnly = true;
            this.latitudeC.Visible = false;
            // 
            // longitudeC
            // 
            this.longitudeC.HeaderText = "longitude";
            this.longitudeC.Name = "longitudeC";
            this.longitudeC.ReadOnly = true;
            this.longitudeC.Visible = false;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(208, 546);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(58, 13);
            this.lblDistance.TabIndex = 82;
            this.lblDistance.Text = "Distance : ";
            // 
            // lblValDistance
            // 
            this.lblValDistance.AutoSize = true;
            this.lblValDistance.Location = new System.Drawing.Point(272, 546);
            this.lblValDistance.Name = "lblValDistance";
            this.lblValDistance.Size = new System.Drawing.Size(37, 13);
            this.lblValDistance.TabIndex = 83;
            this.lblValDistance.Text = "xx km ";
            // 
            // lblDureeTransport
            // 
            this.lblDureeTransport.AutoSize = true;
            this.lblDureeTransport.Location = new System.Drawing.Point(366, 546);
            this.lblDureeTransport.Name = "lblDureeTransport";
            this.lblDureeTransport.Size = new System.Drawing.Size(86, 13);
            this.lblDureeTransport.TabIndex = 84;
            this.lblDureeTransport.Text = "Durée transport :";
            // 
            // lblValDureeTransport
            // 
            this.lblValDureeTransport.AutoSize = true;
            this.lblValDureeTransport.Location = new System.Drawing.Point(458, 546);
            this.lblValDureeTransport.Name = "lblValDureeTransport";
            this.lblValDureeTransport.Size = new System.Drawing.Size(48, 13);
            this.lblValDureeTransport.TabIndex = 85;
            this.lblValDureeTransport.Text = "1h 10mn";
            // 
            // btnChargementDonnees
            // 
            this.btnChargementDonnees.Location = new System.Drawing.Point(26, 536);
            this.btnChargementDonnees.Name = "btnChargementDonnees";
            this.btnChargementDonnees.Size = new System.Drawing.Size(139, 23);
            this.btnChargementDonnees.TabIndex = 86;
            this.btnChargementDonnees.Text = "Chargement Données";
            this.btnChargementDonnees.UseVisualStyleBackColor = true;
            this.btnChargementDonnees.Click += new System.EventHandler(this.btnChargementDonnees_Click);
            // 
            // DispatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 571);
            this.Controls.Add(this.btnChargementDonnees);
            this.Controls.Add(this.lblValDureeTransport);
            this.Controls.Add(this.lblDureeTransport);
            this.Controls.Add(this.lblValDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.dgvListeTechniciens);
            this.Controls.Add(this.gMapDispatcher);
            this.Controls.Add(this.menuStripDispatcher);
            this.MainMenuStrip = this.menuStripDispatcher;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 610);
            this.MinimumSize = new System.Drawing.Size(820, 610);
            this.Name = "DispatcherForm";
            this.Text = "Application PPE3";
            this.Load += new System.EventHandler(this.DispatcherForm_Load);
            this.menuStripDispatcher.ResumeLayout(false);
            this.menuStripDispatcher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeTechniciens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripDispatcher;
        private System.Windows.Forms.ToolStripMenuItem TechnicienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAjoutTechnicienToolStripMenuItem;
        //private System.Windows.Forms.StatusStrip statusStripBDD;
        private System.Windows.Forms.ToolStripMenuItem envoiSMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClient;
        private System.Windows.Forms.ToolStripMenuItem ajouterClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionMatérielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterMaterielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierMatérielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affecterMaterielAUnTechnicienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemIntervention;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItemIntervention;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItemIntervention;
        private System.Windows.Forms.ToolStripMenuItem modifierTechnicienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aperçuToolStripMenuItem;
        private GMap.NET.WindowsForms.GMapControl gMapDispatcher;
        private System.Windows.Forms.DataGridView dgvListeTechniciens;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAbonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntreprise;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudeC;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudeC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLoginT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrenomTech;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomTech;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudeT;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudeT;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblValDistance;
        private System.Windows.Forms.Label lblDureeTransport;
        private System.Windows.Forms.Label lblValDureeTransport;
        private System.Windows.Forms.Button btnChargementDonnees;
        private System.Windows.Forms.ToolStripMenuItem prestataireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
    }
}

