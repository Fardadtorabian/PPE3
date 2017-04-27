namespace Dispatcher
{
    partial class ModifierSupprimerClientForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSupprimerImage = new System.Windows.Forms.Button();
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.btnRechargerListeClients = new System.Windows.Forms.Button();
            this.pictureBoxImageClient = new System.Windows.Forms.PictureBox();
            this.txtBoxAdresse2 = new System.Windows.Forms.TextBox();
            this.txtBoxVille = new System.Windows.Forms.TextBox();
            this.txtBoxAdresse = new System.Windows.Forms.TextBox();
            this.txtBoxPrenomClient = new System.Windows.Forms.TextBox();
            this.txtBoxNomClient = new System.Windows.Forms.TextBox();
            this.lblAdresseComplement = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblPrenomClient = new System.Windows.Forms.Label();
            this.lblNomClient = new System.Windows.Forms.Label();
            this.btnModifierImage = new System.Windows.Forms.Button();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.IdAbonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntreprise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCivilité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNomEntreprise = new System.Windows.Forms.Label();
            this.txtBoxNomEntreprise = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.mTxtBoxCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.mTxtBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.mTxtBoxLatitude = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBoxLongitude = new System.Windows.Forms.MaskedTextBox();
            this.cbxEtatClient = new System.Windows.Forms.ComboBox();
            this.lblEtatClient = new System.Windows.Forms.Label();
            this.lblClientEnregistreDepuis = new System.Windows.Forms.Label();
            this.lblDateEnregistrementClient = new System.Windows.Forms.Label();
            this.cbxCivilite = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSupprimerImage
            // 
            this.btnSupprimerImage.Location = new System.Drawing.Point(686, 110);
            this.btnSupprimerImage.Name = "btnSupprimerImage";
            this.btnSupprimerImage.Size = new System.Drawing.Size(102, 23);
            this.btnSupprimerImage.TabIndex = 0;
            this.btnSupprimerImage.TabStop = false;
            this.btnSupprimerImage.Text = "Supprimer l\'image";
            this.btnSupprimerImage.UseVisualStyleBackColor = true;
            this.btnSupprimerImage.Click += new System.EventHandler(this.btnSupprimerImage_Click);
            // 
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.Location = new System.Drawing.Point(690, 357);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(98, 55);
            this.btnSupprimerClient.TabIndex = 0;
            this.btnSupprimerClient.TabStop = false;
            this.btnSupprimerClient.Text = "Supprimer client";
            this.btnSupprimerClient.UseVisualStyleBackColor = true;
            this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.Location = new System.Drawing.Point(650, 201);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(138, 51);
            this.btnModifierClient.TabIndex = 0;
            this.btnModifierClient.TabStop = false;
            this.btnModifierClient.Text = "Modifier client";
            this.btnModifierClient.UseVisualStyleBackColor = true;
            this.btnModifierClient.Click += new System.EventHandler(this.btnModifierClient_Click);
            // 
            // btnRechargerListeClients
            // 
            this.btnRechargerListeClients.Location = new System.Drawing.Point(650, 261);
            this.btnRechargerListeClients.Name = "btnRechargerListeClients";
            this.btnRechargerListeClients.Size = new System.Drawing.Size(138, 57);
            this.btnRechargerListeClients.TabIndex = 0;
            this.btnRechargerListeClients.TabStop = false;
            this.btnRechargerListeClients.Text = "Recharger liste clients";
            this.btnRechargerListeClients.UseVisualStyleBackColor = true;
            this.btnRechargerListeClients.Click += new System.EventHandler(this.btnRechargerListeClients_Click);
            // 
            // pictureBoxImageClient
            // 
            this.pictureBoxImageClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxImageClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxImageClient.Location = new System.Drawing.Point(523, 12);
            this.pictureBoxImageClient.Name = "pictureBoxImageClient";
            this.pictureBoxImageClient.Size = new System.Drawing.Size(157, 157);
            this.pictureBoxImageClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImageClient.TabIndex = 35;
            this.pictureBoxImageClient.TabStop = false;
            // 
            // txtBoxAdresse2
            // 
            this.txtBoxAdresse2.Location = new System.Drawing.Point(400, 320);
            this.txtBoxAdresse2.MaxLength = 128;
            this.txtBoxAdresse2.Name = "txtBoxAdresse2";
            this.txtBoxAdresse2.Size = new System.Drawing.Size(153, 20);
            this.txtBoxAdresse2.TabIndex = 35;
            // 
            // txtBoxVille
            // 
            this.txtBoxVille.Location = new System.Drawing.Point(220, 360);
            this.txtBoxVille.MaxLength = 128;
            this.txtBoxVille.Name = "txtBoxVille";
            this.txtBoxVille.Size = new System.Drawing.Size(176, 20);
            this.txtBoxVille.TabIndex = 45;
            // 
            // txtBoxAdresse
            // 
            this.txtBoxAdresse.Location = new System.Drawing.Point(100, 320);
            this.txtBoxAdresse.MaxLength = 128;
            this.txtBoxAdresse.Multiline = true;
            this.txtBoxAdresse.Name = "txtBoxAdresse";
            this.txtBoxAdresse.Size = new System.Drawing.Size(208, 20);
            this.txtBoxAdresse.TabIndex = 30;
            // 
            // txtBoxPrenomClient
            // 
            this.txtBoxPrenomClient.Location = new System.Drawing.Point(200, 280);
            this.txtBoxPrenomClient.MaxLength = 50;
            this.txtBoxPrenomClient.Name = "txtBoxPrenomClient";
            this.txtBoxPrenomClient.ReadOnly = true;
            this.txtBoxPrenomClient.Size = new System.Drawing.Size(115, 20);
            this.txtBoxPrenomClient.TabIndex = 20;
            // 
            // txtBoxNomClient
            // 
            this.txtBoxNomClient.Location = new System.Drawing.Point(400, 280);
            this.txtBoxNomClient.MaxLength = 50;
            this.txtBoxNomClient.Name = "txtBoxNomClient";
            this.txtBoxNomClient.ReadOnly = true;
            this.txtBoxNomClient.Size = new System.Drawing.Size(153, 20);
            this.txtBoxNomClient.TabIndex = 25;
            // 
            // lblAdresseComplement
            // 
            this.lblAdresseComplement.AutoSize = true;
            this.lblAdresseComplement.Location = new System.Drawing.Point(322, 321);
            this.lblAdresseComplement.Name = "lblAdresseComplement";
            this.lblAdresseComplement.Size = new System.Drawing.Size(57, 13);
            this.lblAdresseComplement.TabIndex = 27;
            this.lblAdresseComplement.Text = "Adresse 2:";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(167, 361);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 26;
            this.lblVille.Text = "Ville :";
            // 
            // lblPrenomClient
            // 
            this.lblPrenomClient.AutoSize = true;
            this.lblPrenomClient.Location = new System.Drawing.Point(124, 280);
            this.lblPrenomClient.Name = "lblPrenomClient";
            this.lblPrenomClient.Size = new System.Drawing.Size(49, 13);
            this.lblPrenomClient.TabIndex = 23;
            this.lblPrenomClient.Text = "Prénom :";
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Location = new System.Drawing.Point(335, 280);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(35, 13);
            this.lblNomClient.TabIndex = 22;
            this.lblNomClient.Text = "Nom :";
            // 
            // btnModifierImage
            // 
            this.btnModifierImage.Location = new System.Drawing.Point(686, 50);
            this.btnModifierImage.Name = "btnModifierImage";
            this.btnModifierImage.Size = new System.Drawing.Size(92, 23);
            this.btnModifierImage.TabIndex = 0;
            this.btnModifierImage.TabStop = false;
            this.btnModifierImage.Text = "Modifier l\'image";
            this.btnModifierImage.UseVisualStyleBackColor = true;
            this.btnModifierImage.Click += new System.EventHandler(this.btnModifierImage_Click);
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
            this.ColCivilité,
            this.colPrenom,
            this.colNom});
            this.dgvClient.Location = new System.Drawing.Point(28, 12);
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
            this.dgvClient.Size = new System.Drawing.Size(460, 157);
            this.dgvClient.TabIndex = 42;
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
            this.colEntreprise.MinimumWidth = 150;
            this.colEntreprise.Name = "colEntreprise";
            this.colEntreprise.ReadOnly = true;
            this.colEntreprise.Width = 150;
            // 
            // ColCivilité
            // 
            this.ColCivilité.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColCivilité.HeaderText = "Civilité";
            this.ColCivilité.MinimumWidth = 40;
            this.ColCivilité.Name = "ColCivilité";
            this.ColCivilité.ReadOnly = true;
            this.ColCivilité.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCivilité.Width = 40;
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
            this.colNom.MinimumWidth = 150;
            this.colNom.Name = "colNom";
            this.colNom.ReadOnly = true;
            this.colNom.Width = 150;
            // 
            // lblNomEntreprise
            // 
            this.lblNomEntreprise.AutoSize = true;
            this.lblNomEntreprise.Location = new System.Drawing.Point(10, 240);
            this.lblNomEntreprise.Name = "lblNomEntreprise";
            this.lblNomEntreprise.Size = new System.Drawing.Size(63, 13);
            this.lblNomEntreprise.TabIndex = 43;
            this.lblNomEntreprise.Text = "Entreprise : ";
            // 
            // txtBoxNomEntreprise
            // 
            this.txtBoxNomEntreprise.Location = new System.Drawing.Point(96, 239);
            this.txtBoxNomEntreprise.MaxLength = 128;
            this.txtBoxNomEntreprise.Name = "txtBoxNomEntreprise";
            this.txtBoxNomEntreprise.Size = new System.Drawing.Size(282, 20);
            this.txtBoxNomEntreprise.TabIndex = 10;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(13, 321);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(54, 13);
            this.lblAdresse.TabIndex = 25;
            this.lblAdresse.Text = "Adresse : ";
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Location = new System.Drawing.Point(12, 361);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(70, 13);
            this.lblCodePostal.TabIndex = 47;
            this.lblCodePostal.Text = "Code Postal :";
            // 
            // mTxtBoxCodePostal
            // 
            this.mTxtBoxCodePostal.BeepOnError = true;
            this.mTxtBoxCodePostal.Location = new System.Drawing.Point(100, 360);
            this.mTxtBoxCodePostal.Mask = "00000";
            this.mTxtBoxCodePostal.Name = "mTxtBoxCodePostal";
            this.mTxtBoxCodePostal.PromptChar = ' ';
            this.mTxtBoxCodePostal.Size = new System.Drawing.Size(40, 20);
            this.mTxtBoxCodePostal.TabIndex = 40;
            this.mTxtBoxCodePostal.ValidatingType = typeof(int);
            this.mTxtBoxCodePostal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mTxtBoxCodePostal_MouseClick);
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(397, 240);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(64, 13);
            this.lblTelephone.TabIndex = 49;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // mTxtBoxTelephone
            // 
            this.mTxtBoxTelephone.BeepOnError = true;
            this.mTxtBoxTelephone.Location = new System.Drawing.Point(480, 240);
            this.mTxtBoxTelephone.Mask = "0000000000";
            this.mTxtBoxTelephone.Name = "mTxtBoxTelephone";
            this.mTxtBoxTelephone.PromptChar = ' ';
            this.mTxtBoxTelephone.Size = new System.Drawing.Size(70, 20);
            this.mTxtBoxTelephone.TabIndex = 15;
            this.mTxtBoxTelephone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mTxtBoxTelephone_MouseClick);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(402, 361);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 51;
            this.lblEmail.Text = "Email :";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(450, 360);
            this.txtBoxEmail.MaxLength = 128;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(210, 20);
            this.txtBoxEmail.TabIndex = 46;
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(13, 401);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(51, 13);
            this.lblLatitude.TabIndex = 53;
            this.lblLatitude.Text = "Latitude :";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(167, 401);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(60, 13);
            this.lblLongitude.TabIndex = 54;
            this.lblLongitude.Text = "Longitude :";
            // 
            // mTxtBoxLatitude
            // 
            this.mTxtBoxLatitude.BeepOnError = true;
            this.mTxtBoxLatitude.Location = new System.Drawing.Point(80, 400);
            this.mTxtBoxLatitude.Mask = "00.0000000";
            this.mTxtBoxLatitude.Name = "mTxtBoxLatitude";
            this.mTxtBoxLatitude.PromptChar = ' ';
            this.mTxtBoxLatitude.Size = new System.Drawing.Size(70, 20);
            this.mTxtBoxLatitude.TabIndex = 50;
            // 
            // mTxtBoxLongitude
            // 
            this.mTxtBoxLongitude.BeepOnError = true;
            this.mTxtBoxLongitude.Location = new System.Drawing.Point(260, 400);
            this.mTxtBoxLongitude.Mask = "#0.0000000";
            this.mTxtBoxLongitude.Name = "mTxtBoxLongitude";
            this.mTxtBoxLongitude.PromptChar = ' ';
            this.mTxtBoxLongitude.Size = new System.Drawing.Size(70, 20);
            this.mTxtBoxLongitude.TabIndex = 55;
            // 
            // cbxEtatClient
            // 
            this.cbxEtatClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEtatClient.FormattingEnabled = true;
            this.cbxEtatClient.Items.AddRange(new object[] {
            "valide",
            "impayé",
            "aSupprimer"});
            this.cbxEtatClient.Location = new System.Drawing.Point(100, 191);
            this.cbxEtatClient.Name = "cbxEtatClient";
            this.cbxEtatClient.Size = new System.Drawing.Size(87, 21);
            this.cbxEtatClient.TabIndex = 56;
            // 
            // lblEtatClient
            // 
            this.lblEtatClient.AutoSize = true;
            this.lblEtatClient.Location = new System.Drawing.Point(10, 194);
            this.lblEtatClient.Name = "lblEtatClient";
            this.lblEtatClient.Size = new System.Drawing.Size(64, 13);
            this.lblEtatClient.TabIndex = 57;
            this.lblEtatClient.Text = "Etat Client : ";
            // 
            // lblClientEnregistreDepuis
            // 
            this.lblClientEnregistreDepuis.AutoSize = true;
            this.lblClientEnregistreDepuis.Location = new System.Drawing.Point(360, 400);
            this.lblClientEnregistreDepuis.Name = "lblClientEnregistreDepuis";
            this.lblClientEnregistreDepuis.Size = new System.Drawing.Size(136, 13);
            this.lblClientEnregistreDepuis.TabIndex = 58;
            this.lblClientEnregistreDepuis.Text = "Client enregistré depuis le : ";
            // 
            // lblDateEnregistrementClient
            // 
            this.lblDateEnregistrementClient.AutoSize = true;
            this.lblDateEnregistrementClient.Location = new System.Drawing.Point(503, 399);
            this.lblDateEnregistrementClient.Name = "lblDateEnregistrementClient";
            this.lblDateEnregistrementClient.Size = new System.Drawing.Size(35, 13);
            this.lblDateEnregistrementClient.TabIndex = 59;
            this.lblDateEnregistrementClient.Text = "label2";
            // 
            // cbxCivilite
            // 
            this.cbxCivilite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCivilite.FormattingEnabled = true;
            this.cbxCivilite.Location = new System.Drawing.Point(15, 278);
            this.cbxCivilite.Name = "cbxCivilite";
            this.cbxCivilite.Size = new System.Drawing.Size(62, 21);
            this.cbxCivilite.TabIndex = 60;
            // 
            // ModifierSupprimerClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 437);
            this.Controls.Add(this.cbxCivilite);
            this.Controls.Add(this.lblDateEnregistrementClient);
            this.Controls.Add(this.lblClientEnregistreDepuis);
            this.Controls.Add(this.lblEtatClient);
            this.Controls.Add(this.cbxEtatClient);
            this.Controls.Add(this.mTxtBoxLongitude);
            this.Controls.Add(this.mTxtBoxLatitude);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.mTxtBoxTelephone);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.mTxtBoxCodePostal);
            this.Controls.Add(this.lblCodePostal);
            this.Controls.Add(this.txtBoxNomEntreprise);
            this.Controls.Add(this.lblNomEntreprise);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.btnModifierImage);
            this.Controls.Add(this.btnSupprimerImage);
            this.Controls.Add(this.btnSupprimerClient);
            this.Controls.Add(this.btnModifierClient);
            this.Controls.Add(this.btnRechargerListeClients);
            this.Controls.Add(this.pictureBoxImageClient);
            this.Controls.Add(this.txtBoxAdresse2);
            this.Controls.Add(this.txtBoxVille);
            this.Controls.Add(this.txtBoxAdresse);
            this.Controls.Add(this.txtBoxPrenomClient);
            this.Controls.Add(this.txtBoxNomClient);
            this.Controls.Add(this.lblAdresseComplement);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblPrenomClient);
            this.Controls.Add(this.lblNomClient);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 476);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(820, 476);
            this.Name = "ModifierSupprimerClientForm";
            this.Text = "Modifier / Supprimer Clients";
            this.Load += new System.EventHandler(this.ModifierSupprimerClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupprimerImage;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.Button btnRechargerListeClients;
        private System.Windows.Forms.PictureBox pictureBoxImageClient;
        private System.Windows.Forms.TextBox txtBoxAdresse2;
        private System.Windows.Forms.TextBox txtBoxVille;
        private System.Windows.Forms.TextBox txtBoxAdresse;
        private System.Windows.Forms.TextBox txtBoxPrenomClient;
        private System.Windows.Forms.TextBox txtBoxNomClient;
        private System.Windows.Forms.Label lblAdresseComplement;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblPrenomClient;
        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.Button btnModifierImage;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAbonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntreprise;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCivilité;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom;
        private System.Windows.Forms.Label lblNomEntreprise;
        private System.Windows.Forms.TextBox txtBoxNomEntreprise;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.MaskedTextBox mTxtBoxCodePostal;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.MaskedTextBox mTxtBoxTelephone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.MaskedTextBox mTxtBoxLatitude;
        private System.Windows.Forms.MaskedTextBox mTxtBoxLongitude;
        private System.Windows.Forms.ComboBox cbxEtatClient;
        private System.Windows.Forms.Label lblEtatClient;
        private System.Windows.Forms.Label lblClientEnregistreDepuis;
        private System.Windows.Forms.Label lblDateEnregistrementClient;
        private System.Windows.Forms.ComboBox cbxCivilite;
    }
}