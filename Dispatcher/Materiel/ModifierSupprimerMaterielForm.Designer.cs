namespace Dispatcher
{
    partial class ModifierSupprimerMaterielForm
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
            this.btnSupprimerMateriel = new System.Windows.Forms.Button();
            this.btnModifierMateriel = new System.Windows.Forms.Button();
            this.comBoxEtatMatériel = new System.Windows.Forms.ComboBox();
            this.lblEtatMateriel = new System.Windows.Forms.Label();
            this.textBoxIdGoogle = new System.Windows.Forms.TextBox();
            this.lblIgGoogle = new System.Windows.Forms.Label();
            this.textBoxCodeIMEI = new System.Windows.Forms.TextBox();
            this.lblCodeImei = new System.Windows.Forms.Label();
            this.lblNumeroTel = new System.Windows.Forms.Label();
            this.textBoxNumSerie = new System.Windows.Forms.TextBox();
            this.textBoxTypeMateriel = new System.Windows.Forms.TextBox();
            this.lblNumeroSerie = new System.Windows.Forms.Label();
            this.lblTypeMateriel = new System.Windows.Forms.Label();
            this.lblAffecte = new System.Windows.Forms.Label();
            this.mTxtBoxNumtel = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxAffectationMat = new System.Windows.Forms.TextBox();
            this.lblDateEnregistrementMateriel = new System.Windows.Forms.Label();
            this.lblDateEnregistrement = new System.Windows.Forms.Label();
            this.lblValDateAffectation = new System.Windows.Forms.Label();
            this.lblDateAffectation = new System.Windows.Forms.Label();
            this.dgvMateriels = new System.Windows.Forms.DataGridView();
            this.IdMateriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeMateriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriels)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSupprimerMateriel
            // 
            this.btnSupprimerMateriel.Location = new System.Drawing.Point(137, 169);
            this.btnSupprimerMateriel.Name = "btnSupprimerMateriel";
            this.btnSupprimerMateriel.Size = new System.Drawing.Size(108, 35);
            this.btnSupprimerMateriel.TabIndex = 25;
            this.btnSupprimerMateriel.Text = "Supprimer matériel";
            this.btnSupprimerMateriel.UseVisualStyleBackColor = true;
            // 
            // btnModifierMateriel
            // 
            this.btnModifierMateriel.Location = new System.Drawing.Point(12, 169);
            this.btnModifierMateriel.Name = "btnModifierMateriel";
            this.btnModifierMateriel.Size = new System.Drawing.Size(97, 35);
            this.btnModifierMateriel.TabIndex = 24;
            this.btnModifierMateriel.Text = "Modifier matériel";
            this.btnModifierMateriel.UseVisualStyleBackColor = true;
            this.btnModifierMateriel.Click += new System.EventHandler(this.btnModifierMateriel_Click);
            // 
            // comBoxEtatMatériel
            // 
            this.comBoxEtatMatériel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxEtatMatériel.FormattingEnabled = true;
            this.comBoxEtatMatériel.Items.AddRange(new object[] {
            "stock",
            "enService",
            "enPanne",
            "vol",
            "declasse",
            "perdu"});
            this.comBoxEtatMatériel.Location = new System.Drawing.Point(492, 125);
            this.comBoxEtatMatériel.Name = "comBoxEtatMatériel";
            this.comBoxEtatMatériel.Size = new System.Drawing.Size(189, 21);
            this.comBoxEtatMatériel.TabIndex = 68;
            // 
            // lblEtatMateriel
            // 
            this.lblEtatMateriel.AutoSize = true;
            this.lblEtatMateriel.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEtatMateriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtatMateriel.Location = new System.Drawing.Point(489, 106);
            this.lblEtatMateriel.Name = "lblEtatMateriel";
            this.lblEtatMateriel.Size = new System.Drawing.Size(88, 16);
            this.lblEtatMateriel.TabIndex = 67;
            this.lblEtatMateriel.Text = "Etat Matériel :";
            // 
            // textBoxIdGoogle
            // 
            this.textBoxIdGoogle.Location = new System.Drawing.Point(492, 71);
            this.textBoxIdGoogle.MaxLength = 10;
            this.textBoxIdGoogle.Name = "textBoxIdGoogle";
            this.textBoxIdGoogle.Size = new System.Drawing.Size(189, 20);
            this.textBoxIdGoogle.TabIndex = 62;
            // 
            // lblIgGoogle
            // 
            this.lblIgGoogle.AutoSize = true;
            this.lblIgGoogle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblIgGoogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgGoogle.Location = new System.Drawing.Point(489, 52);
            this.lblIgGoogle.Name = "lblIgGoogle";
            this.lblIgGoogle.Size = new System.Drawing.Size(73, 16);
            this.lblIgGoogle.TabIndex = 61;
            this.lblIgGoogle.Text = "Id Google :";
            // 
            // textBoxCodeIMEI
            // 
            this.textBoxCodeIMEI.Location = new System.Drawing.Point(492, 29);
            this.textBoxCodeIMEI.MaxLength = 10;
            this.textBoxCodeIMEI.Name = "textBoxCodeIMEI";
            this.textBoxCodeIMEI.Size = new System.Drawing.Size(189, 20);
            this.textBoxCodeIMEI.TabIndex = 60;
            // 
            // lblCodeImei
            // 
            this.lblCodeImei.AutoSize = true;
            this.lblCodeImei.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCodeImei.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeImei.Location = new System.Drawing.Point(489, 10);
            this.lblCodeImei.Name = "lblCodeImei";
            this.lblCodeImei.Size = new System.Drawing.Size(43, 16);
            this.lblCodeImei.TabIndex = 59;
            this.lblCodeImei.Text = "IMEI : ";
            // 
            // lblNumeroTel
            // 
            this.lblNumeroTel.AutoSize = true;
            this.lblNumeroTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTel.Location = new System.Drawing.Point(251, 94);
            this.lblNumeroTel.Name = "lblNumeroTel";
            this.lblNumeroTel.Size = new System.Drawing.Size(138, 16);
            this.lblNumeroTel.TabIndex = 57;
            this.lblNumeroTel.Text = "Numéro de téléphone";
            // 
            // textBoxNumSerie
            // 
            this.textBoxNumSerie.Location = new System.Drawing.Point(254, 71);
            this.textBoxNumSerie.MaxLength = 17;
            this.textBoxNumSerie.Name = "textBoxNumSerie";
            this.textBoxNumSerie.Size = new System.Drawing.Size(189, 20);
            this.textBoxNumSerie.TabIndex = 54;
            // 
            // textBoxTypeMateriel
            // 
            this.textBoxTypeMateriel.Location = new System.Drawing.Point(254, 29);
            this.textBoxTypeMateriel.MaxLength = 100;
            this.textBoxTypeMateriel.Name = "textBoxTypeMateriel";
            this.textBoxTypeMateriel.Size = new System.Drawing.Size(189, 20);
            this.textBoxTypeMateriel.TabIndex = 53;
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroSerie.Location = new System.Drawing.Point(251, 52);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(108, 16);
            this.lblNumeroSerie.TabIndex = 56;
            this.lblNumeroSerie.Text = "Numéro de série";
            // 
            // lblTypeMateriel
            // 
            this.lblTypeMateriel.AutoSize = true;
            this.lblTypeMateriel.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTypeMateriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeMateriel.Location = new System.Drawing.Point(251, 10);
            this.lblTypeMateriel.Name = "lblTypeMateriel";
            this.lblTypeMateriel.Size = new System.Drawing.Size(91, 16);
            this.lblTypeMateriel.TabIndex = 55;
            this.lblTypeMateriel.Text = "Type Matériel";
            // 
            // lblAffecte
            // 
            this.lblAffecte.AutoSize = true;
            this.lblAffecte.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAffecte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffecte.Location = new System.Drawing.Point(489, 158);
            this.lblAffecte.Name = "lblAffecte";
            this.lblAffecte.Size = new System.Drawing.Size(66, 16);
            this.lblAffecte.TabIndex = 70;
            this.lblAffecte.Text = "Affecté à :";
            // 
            // mTxtBoxNumtel
            // 
            this.mTxtBoxNumtel.BeepOnError = true;
            this.mTxtBoxNumtel.Location = new System.Drawing.Point(254, 113);
            this.mTxtBoxNumtel.Mask = "0000000000";
            this.mTxtBoxNumtel.Name = "mTxtBoxNumtel";
            this.mTxtBoxNumtel.PromptChar = ' ';
            this.mTxtBoxNumtel.Size = new System.Drawing.Size(70, 20);
            this.mTxtBoxNumtel.TabIndex = 71;
            this.mTxtBoxNumtel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mTxtBoxNumtel_MouseClick);
            // 
            // txtBoxAffectationMat
            // 
            this.txtBoxAffectationMat.Location = new System.Drawing.Point(492, 177);
            this.txtBoxAffectationMat.MaxLength = 17;
            this.txtBoxAffectationMat.Name = "txtBoxAffectationMat";
            this.txtBoxAffectationMat.ReadOnly = true;
            this.txtBoxAffectationMat.Size = new System.Drawing.Size(189, 20);
            this.txtBoxAffectationMat.TabIndex = 72;
            // 
            // lblDateEnregistrementMateriel
            // 
            this.lblDateEnregistrementMateriel.AutoSize = true;
            this.lblDateEnregistrementMateriel.Location = new System.Drawing.Point(368, 146);
            this.lblDateEnregistrementMateriel.Name = "lblDateEnregistrementMateriel";
            this.lblDateEnregistrementMateriel.Size = new System.Drawing.Size(35, 13);
            this.lblDateEnregistrementMateriel.TabIndex = 74;
            this.lblDateEnregistrementMateriel.Text = "label2";
            // 
            // lblDateEnregistrement
            // 
            this.lblDateEnregistrement.AutoSize = true;
            this.lblDateEnregistrement.Location = new System.Drawing.Point(251, 146);
            this.lblDateEnregistrement.Name = "lblDateEnregistrement";
            this.lblDateEnregistrement.Size = new System.Drawing.Size(111, 13);
            this.lblDateEnregistrement.TabIndex = 73;
            this.lblDateEnregistrement.Text = "Date enregistrement : ";
            // 
            // lblValDateAffectation
            // 
            this.lblValDateAffectation.AutoSize = true;
            this.lblValDateAffectation.Location = new System.Drawing.Point(368, 180);
            this.lblValDateAffectation.Name = "lblValDateAffectation";
            this.lblValDateAffectation.Size = new System.Drawing.Size(35, 13);
            this.lblValDateAffectation.TabIndex = 76;
            this.lblValDateAffectation.Text = "label2";
            // 
            // lblDateAffectation
            // 
            this.lblDateAffectation.AutoSize = true;
            this.lblDateAffectation.Location = new System.Drawing.Point(251, 180);
            this.lblDateAffectation.Name = "lblDateAffectation";
            this.lblDateAffectation.Size = new System.Drawing.Size(97, 13);
            this.lblDateAffectation.TabIndex = 75;
            this.lblDateAffectation.Text = "Dated\'affectation : ";
            // 
            // dgvMateriels
            // 
            this.dgvMateriels.AllowUserToAddRows = false;
            this.dgvMateriels.AllowUserToDeleteRows = false;
            this.dgvMateriels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMateriels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMateriel,
            this.TypeMateriel,
            this.NumeroSerie});
            this.dgvMateriels.Location = new System.Drawing.Point(12, 13);
            this.dgvMateriels.Name = "dgvMateriels";
            this.dgvMateriels.ReadOnly = true;
            this.dgvMateriels.Size = new System.Drawing.Size(233, 150);
            this.dgvMateriels.TabIndex = 77;
            this.dgvMateriels.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMateriels_CellClick);
            // 
            // IdMateriel
            // 
            this.IdMateriel.HeaderText = "Id";
            this.IdMateriel.Name = "IdMateriel";
            this.IdMateriel.ReadOnly = true;
            this.IdMateriel.Visible = false;
            // 
            // TypeMateriel
            // 
            this.TypeMateriel.HeaderText = "Type Materiel";
            this.TypeMateriel.Name = "TypeMateriel";
            this.TypeMateriel.ReadOnly = true;
            // 
            // NumeroSerie
            // 
            this.NumeroSerie.HeaderText = "Numéro de Serie";
            this.NumeroSerie.Name = "NumeroSerie";
            this.NumeroSerie.ReadOnly = true;
            // 
            // ModifierSupprimerMaterielForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 241);
            this.Controls.Add(this.dgvMateriels);
            this.Controls.Add(this.lblValDateAffectation);
            this.Controls.Add(this.lblDateAffectation);
            this.Controls.Add(this.lblDateEnregistrementMateriel);
            this.Controls.Add(this.lblDateEnregistrement);
            this.Controls.Add(this.txtBoxAffectationMat);
            this.Controls.Add(this.mTxtBoxNumtel);
            this.Controls.Add(this.lblAffecte);
            this.Controls.Add(this.comBoxEtatMatériel);
            this.Controls.Add(this.lblEtatMateriel);
            this.Controls.Add(this.textBoxIdGoogle);
            this.Controls.Add(this.lblIgGoogle);
            this.Controls.Add(this.textBoxCodeIMEI);
            this.Controls.Add(this.lblCodeImei);
            this.Controls.Add(this.lblNumeroTel);
            this.Controls.Add(this.textBoxNumSerie);
            this.Controls.Add(this.textBoxTypeMateriel);
            this.Controls.Add(this.lblNumeroSerie);
            this.Controls.Add(this.lblTypeMateriel);
            this.Controls.Add(this.btnSupprimerMateriel);
            this.Controls.Add(this.btnModifierMateriel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(714, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(714, 280);
            this.Name = "ModifierSupprimerMaterielForm";
            this.Text = "Modifier / Supprimer Materiel";
            this.Load += new System.EventHandler(this.ModifierSupprimerMaterielForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupprimerMateriel;
        private System.Windows.Forms.Button btnModifierMateriel;
        private System.Windows.Forms.ComboBox comBoxEtatMatériel;
        private System.Windows.Forms.Label lblEtatMateriel;
        private System.Windows.Forms.TextBox textBoxIdGoogle;
        private System.Windows.Forms.Label lblIgGoogle;
        private System.Windows.Forms.TextBox textBoxCodeIMEI;
        private System.Windows.Forms.Label lblCodeImei;
        private System.Windows.Forms.Label lblNumeroTel;
        private System.Windows.Forms.TextBox textBoxNumSerie;
        private System.Windows.Forms.TextBox textBoxTypeMateriel;
        private System.Windows.Forms.Label lblNumeroSerie;
        private System.Windows.Forms.Label lblTypeMateriel;
        private System.Windows.Forms.Label lblAffecte;
        private System.Windows.Forms.MaskedTextBox mTxtBoxNumtel;
        private System.Windows.Forms.TextBox txtBoxAffectationMat;
        private System.Windows.Forms.Label lblDateEnregistrementMateriel;
        private System.Windows.Forms.Label lblDateEnregistrement;
        private System.Windows.Forms.Label lblValDateAffectation;
        private System.Windows.Forms.Label lblDateAffectation;
        private System.Windows.Forms.DataGridView dgvMateriels;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateriel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeMateriel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroSerie;
    }
}