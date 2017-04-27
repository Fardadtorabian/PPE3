namespace Dispatcher
{
    partial class AjouterClientForm 
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
            this.btnViderChamps = new System.Windows.Forms.Button();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.lblAdresseSuite = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblNumeroTel = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.pictureBoxImageClient = new System.Windows.Forms.PictureBox();
            this.txtBoxAdresseSuite = new System.Windows.Forms.TextBox();
            this.txtBoxVille = new System.Windows.Forms.TextBox();
            this.txtBoxAdresse = new System.Windows.Forms.TextBox();
            this.txtBoxPrenomClient = new System.Windows.Forms.TextBox();
            this.txtBoxNomClient = new System.Windows.Forms.TextBox();
            this.btnModifierImage = new System.Windows.Forms.Button();
            this.lblNomEntreprise = new System.Windows.Forms.Label();
            this.txtBoxNomEntreprise = new System.Windows.Forms.TextBox();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.mTxtBoxCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.comBoxCivilite = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageClient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViderChamps
            // 
            this.btnViderChamps.Location = new System.Drawing.Point(363, 291);
            this.btnViderChamps.Name = "btnViderChamps";
            this.btnViderChamps.Size = new System.Drawing.Size(81, 52);
            this.btnViderChamps.TabIndex = 0;
            this.btnViderChamps.TabStop = false;
            this.btnViderChamps.Tag = "0";
            this.btnViderChamps.Text = "Vider les champs";
            this.btnViderChamps.UseVisualStyleBackColor = true;
            this.btnViderChamps.Click += new System.EventHandler(this.btnViderChamps_Click);
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Location = new System.Drawing.Point(459, 291);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(113, 52);
            this.btnAjouterClient.TabIndex = 0;
            this.btnAjouterClient.TabStop = false;
            this.btnAjouterClient.Tag = "0";
            this.btnAjouterClient.Text = "Enregistrer le client";
            this.btnAjouterClient.UseVisualStyleBackColor = true;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // lblAdresseSuite
            // 
            this.lblAdresseSuite.AutoSize = true;
            this.lblAdresseSuite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblAdresseSuite.Location = new System.Drawing.Point(8, 183);
            this.lblAdresseSuite.Name = "lblAdresseSuite";
            this.lblAdresseSuite.Size = new System.Drawing.Size(98, 16);
            this.lblAdresseSuite.TabIndex = 27;
            this.lblAdresseSuite.Text = "Adresse (suite)";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblVille.Location = new System.Drawing.Point(8, 223);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(34, 16);
            this.lblVille.TabIndex = 26;
            this.lblVille.Text = "Ville";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblAdresse.Location = new System.Drawing.Point(8, 143);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(68, 16);
            this.lblAdresse.TabIndex = 25;
            this.lblAdresse.Text = "Adresse : ";
            // 
            // lblNumeroTel
            // 
            this.lblNumeroTel.AutoSize = true;
            this.lblNumeroTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNumeroTel.Location = new System.Drawing.Point(8, 303);
            this.lblNumeroTel.Name = "lblNumeroTel";
            this.lblNumeroTel.Size = new System.Drawing.Size(74, 16);
            this.lblNumeroTel.TabIndex = 24;
            this.lblNumeroTel.Text = "Téléphone";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPrenom.Location = new System.Drawing.Point(8, 102);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(58, 16);
            this.lblPrenom.TabIndex = 23;
            this.lblPrenom.Text = "Prenom ";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNom.Location = new System.Drawing.Point(69, 63);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 16);
            this.lblNom.TabIndex = 22;
            this.lblNom.Text = "Nom";
            // 
            // pictureBoxImageClient
            // 
            this.pictureBoxImageClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxImageClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxImageClient.Location = new System.Drawing.Point(372, 12);
            this.pictureBoxImageClient.Name = "pictureBoxImageClient";
            this.pictureBoxImageClient.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxImageClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageClient.TabIndex = 21;
            this.pictureBoxImageClient.TabStop = false;
            this.pictureBoxImageClient.Tag = "0";
            // 
            // txtBoxAdresseSuite
            // 
            this.txtBoxAdresseSuite.Location = new System.Drawing.Point(117, 182);
            this.txtBoxAdresseSuite.MaxLength = 128;
            this.txtBoxAdresseSuite.Name = "txtBoxAdresseSuite";
            this.txtBoxAdresseSuite.Size = new System.Drawing.Size(205, 20);
            this.txtBoxAdresseSuite.TabIndex = 30;
            // 
            // txtBoxVille
            // 
            this.txtBoxVille.Location = new System.Drawing.Point(117, 222);
            this.txtBoxVille.MaxLength = 128;
            this.txtBoxVille.Name = "txtBoxVille";
            this.txtBoxVille.Size = new System.Drawing.Size(210, 20);
            this.txtBoxVille.TabIndex = 35;
            // 
            // txtBoxAdresse
            // 
            this.txtBoxAdresse.Location = new System.Drawing.Point(117, 142);
            this.txtBoxAdresse.MaxLength = 128;
            this.txtBoxAdresse.Name = "txtBoxAdresse";
            this.txtBoxAdresse.Size = new System.Drawing.Size(210, 20);
            this.txtBoxAdresse.TabIndex = 25;
            // 
            // txtBoxPrenomClient
            // 
            this.txtBoxPrenomClient.Location = new System.Drawing.Point(117, 102);
            this.txtBoxPrenomClient.MaxLength = 50;
            this.txtBoxPrenomClient.Name = "txtBoxPrenomClient";
            this.txtBoxPrenomClient.Size = new System.Drawing.Size(210, 20);
            this.txtBoxPrenomClient.TabIndex = 20;
            // 
            // txtBoxNomClient
            // 
            this.txtBoxNomClient.Location = new System.Drawing.Point(117, 62);
            this.txtBoxNomClient.MaxLength = 50;
            this.txtBoxNomClient.Name = "txtBoxNomClient";
            this.txtBoxNomClient.Size = new System.Drawing.Size(210, 20);
            this.txtBoxNomClient.TabIndex = 15;
            // 
            // btnModifierImage
            // 
            this.btnModifierImage.Location = new System.Drawing.Point(430, 237);
            this.btnModifierImage.Name = "btnModifierImage";
            this.btnModifierImage.Size = new System.Drawing.Size(113, 23);
            this.btnModifierImage.TabIndex = 0;
            this.btnModifierImage.TabStop = false;
            this.btnModifierImage.Tag = "0";
            this.btnModifierImage.Text = "Modifier l\'image";
            this.btnModifierImage.UseVisualStyleBackColor = true;
            this.btnModifierImage.Click += new System.EventHandler(this.btnModifierImage_Click);
            // 
            // lblNomEntreprise
            // 
            this.lblNomEntreprise.AutoSize = true;
            this.lblNomEntreprise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNomEntreprise.Location = new System.Drawing.Point(11, 23);
            this.lblNomEntreprise.Name = "lblNomEntreprise";
            this.lblNomEntreprise.Size = new System.Drawing.Size(69, 16);
            this.lblNomEntreprise.TabIndex = 31;
            this.lblNomEntreprise.Text = "Entreprise";
            // 
            // txtBoxNomEntreprise
            // 
            this.txtBoxNomEntreprise.Location = new System.Drawing.Point(117, 22);
            this.txtBoxNomEntreprise.MaxLength = 50;
            this.txtBoxNomEntreprise.Name = "txtBoxNomEntreprise";
            this.txtBoxNomEntreprise.Size = new System.Drawing.Size(210, 20);
            this.txtBoxNomEntreprise.TabIndex = 10;
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCodePostal.Location = new System.Drawing.Point(8, 263);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(82, 16);
            this.lblCodePostal.TabIndex = 33;
            this.lblCodePostal.Text = "Code Postal";
            // 
            // mTxtBoxCodePostal
            // 
            this.mTxtBoxCodePostal.BeepOnError = true;
            this.mTxtBoxCodePostal.Location = new System.Drawing.Point(117, 262);
            this.mTxtBoxCodePostal.Mask = "00000";
            this.mTxtBoxCodePostal.Name = "mTxtBoxCodePostal";
            this.mTxtBoxCodePostal.PromptChar = ' ';
            this.mTxtBoxCodePostal.Size = new System.Drawing.Size(40, 20);
            this.mTxtBoxCodePostal.TabIndex = 40;
            this.mTxtBoxCodePostal.ValidatingType = typeof(int);
            this.mTxtBoxCodePostal.Click += new System.EventHandler(this.mTxtBoxCodePostal_Click);
            // 
            // mTxtBoxTelephone
            // 
            this.mTxtBoxTelephone.BeepOnError = true;
            this.mTxtBoxTelephone.Location = new System.Drawing.Point(117, 302);
            this.mTxtBoxTelephone.Mask = "0000000000";
            this.mTxtBoxTelephone.Name = "mTxtBoxTelephone";
            this.mTxtBoxTelephone.PromptChar = ' ';
            this.mTxtBoxTelephone.Size = new System.Drawing.Size(70, 20);
            this.mTxtBoxTelephone.TabIndex = 45;
            this.mTxtBoxTelephone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mTxtBoxTelephone_MouseClick);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEmail.Location = new System.Drawing.Point(8, 343);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 16);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "Email";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(117, 342);
            this.txtBoxEmail.MaxLength = 128;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(210, 20);
            this.txtBoxEmail.TabIndex = 50;
            // 
            // comBoxCivilite
            // 
            this.comBoxCivilite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxCivilite.FormattingEnabled = true;
            this.comBoxCivilite.Location = new System.Drawing.Point(12, 62);
            this.comBoxCivilite.Name = "comBoxCivilite";
            this.comBoxCivilite.Size = new System.Drawing.Size(53, 21);
            this.comBoxCivilite.TabIndex = 51;
            // 
            // AjouterClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 386);
            this.Controls.Add(this.comBoxCivilite);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.mTxtBoxTelephone);
            this.Controls.Add(this.mTxtBoxCodePostal);
            this.Controls.Add(this.lblCodePostal);
            this.Controls.Add(this.txtBoxNomEntreprise);
            this.Controls.Add(this.lblNomEntreprise);
            this.Controls.Add(this.btnModifierImage);
            this.Controls.Add(this.btnViderChamps);
            this.Controls.Add(this.btnAjouterClient);
            this.Controls.Add(this.lblAdresseSuite);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblNumeroTel);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pictureBoxImageClient);
            this.Controls.Add(this.txtBoxAdresseSuite);
            this.Controls.Add(this.txtBoxVille);
            this.Controls.Add(this.txtBoxAdresse);
            this.Controls.Add(this.txtBoxPrenomClient);
            this.Controls.Add(this.txtBoxNomClient);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 425);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 425);
            this.Name = "AjouterClientForm";
            this.Text = "Ajouter Client";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViderChamps;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.Label lblAdresseSuite;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblNumeroTel;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.PictureBox pictureBoxImageClient;
        private System.Windows.Forms.TextBox txtBoxAdresseSuite;
        private System.Windows.Forms.TextBox txtBoxVille;
        private System.Windows.Forms.TextBox txtBoxAdresse;
        private System.Windows.Forms.TextBox txtBoxPrenomClient;
        private System.Windows.Forms.TextBox txtBoxNomClient;
        private System.Windows.Forms.Button btnModifierImage;
        private System.Windows.Forms.Label lblNomEntreprise;
        private System.Windows.Forms.TextBox txtBoxNomEntreprise;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.MaskedTextBox mTxtBoxCodePostal;
        private System.Windows.Forms.MaskedTextBox mTxtBoxTelephone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.ComboBox comBoxCivilite;
    }
}