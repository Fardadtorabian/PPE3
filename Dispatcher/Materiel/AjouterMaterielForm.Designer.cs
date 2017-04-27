namespace Dispatcher
{
    partial class AjouterMaterielForm
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
            this.textBoxNumSerie = new System.Windows.Forms.TextBox();
            this.textBoxTypeMateriel = new System.Windows.Forms.TextBox();
            this.btnViderChamps = new System.Windows.Forms.Button();
            this.LblNumeroSerie = new System.Windows.Forms.Label();
            this.lblTypeMateriel = new System.Windows.Forms.Label();
            this.btnAjouterMateriel = new System.Windows.Forms.Button();
            this.lblNumeroTel = new System.Windows.Forms.Label();
            this.lblImei = new System.Windows.Forms.Label();
            this.textBoxCodeIMEI = new System.Windows.Forms.TextBox();
            this.lblIdGoogle = new System.Windows.Forms.Label();
            this.textBoxIdGoogle = new System.Windows.Forms.TextBox();
            this.lblEtatMateriel = new System.Windows.Forms.Label();
            this.comBoxEtatMateriel = new System.Windows.Forms.ComboBox();
            this.mTxtBoxNumtel = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBoxNumSerie
            // 
            this.textBoxNumSerie.Location = new System.Drawing.Point(15, 72);
            this.textBoxNumSerie.MaxLength = 50;
            this.textBoxNumSerie.Name = "textBoxNumSerie";
            this.textBoxNumSerie.Size = new System.Drawing.Size(189, 20);
            this.textBoxNumSerie.TabIndex = 5;
            // 
            // textBoxTypeMateriel
            // 
            this.textBoxTypeMateriel.Location = new System.Drawing.Point(15, 29);
            this.textBoxTypeMateriel.MaxLength = 100;
            this.textBoxTypeMateriel.Name = "textBoxTypeMateriel";
            this.textBoxTypeMateriel.Size = new System.Drawing.Size(189, 20);
            this.textBoxTypeMateriel.TabIndex = 4;
            // 
            // btnViderChamps
            // 
            this.btnViderChamps.Location = new System.Drawing.Point(12, 217);
            this.btnViderChamps.Name = "btnViderChamps";
            this.btnViderChamps.Size = new System.Drawing.Size(89, 23);
            this.btnViderChamps.TabIndex = 7;
            this.btnViderChamps.Text = "RAZ formulaire";
            this.btnViderChamps.UseVisualStyleBackColor = true;
            this.btnViderChamps.Click += new System.EventHandler(this.btnViderChamps_Click);
            // 
            // LblNumeroSerie
            // 
            this.LblNumeroSerie.AutoSize = true;
            this.LblNumeroSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroSerie.Location = new System.Drawing.Point(12, 52);
            this.LblNumeroSerie.Name = "LblNumeroSerie";
            this.LblNumeroSerie.Size = new System.Drawing.Size(117, 16);
            this.LblNumeroSerie.TabIndex = 8;
            this.LblNumeroSerie.Text = "Numéro de série : ";
            // 
            // lblTypeMateriel
            // 
            this.lblTypeMateriel.AutoSize = true;
            this.lblTypeMateriel.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTypeMateriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeMateriel.Location = new System.Drawing.Point(12, 9);
            this.lblTypeMateriel.Name = "lblTypeMateriel";
            this.lblTypeMateriel.Size = new System.Drawing.Size(100, 16);
            this.lblTypeMateriel.TabIndex = 6;
            this.lblTypeMateriel.Text = "Type Matériel : ";
            // 
            // btnAjouterMateriel
            // 
            this.btnAjouterMateriel.Location = new System.Drawing.Point(110, 217);
            this.btnAjouterMateriel.Name = "btnAjouterMateriel";
            this.btnAjouterMateriel.Size = new System.Drawing.Size(94, 23);
            this.btnAjouterMateriel.TabIndex = 9;
            this.btnAjouterMateriel.Text = "Ajouter Matériel";
            this.btnAjouterMateriel.UseVisualStyleBackColor = true;
            this.btnAjouterMateriel.Click += new System.EventHandler(this.btnAjouterMateriel_Click);
            // 
            // lblNumeroTel
            // 
            this.lblNumeroTel.AutoSize = true;
            this.lblNumeroTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTel.Location = new System.Drawing.Point(12, 95);
            this.lblNumeroTel.Name = "lblNumeroTel";
            this.lblNumeroTel.Size = new System.Drawing.Size(144, 16);
            this.lblNumeroTel.TabIndex = 10;
            this.lblNumeroTel.Text = "Numéro de téléphone :";
            // 
            // lblImei
            // 
            this.lblImei.AutoSize = true;
            this.lblImei.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblImei.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImei.Location = new System.Drawing.Point(246, 9);
            this.lblImei.Name = "lblImei";
            this.lblImei.Size = new System.Drawing.Size(40, 16);
            this.lblImei.TabIndex = 12;
            this.lblImei.Text = "IMEI :";
            // 
            // textBoxCodeIMEI
            // 
            this.textBoxCodeIMEI.Location = new System.Drawing.Point(249, 28);
            this.textBoxCodeIMEI.MaxLength = 17;
            this.textBoxCodeIMEI.Name = "textBoxCodeIMEI";
            this.textBoxCodeIMEI.Size = new System.Drawing.Size(189, 20);
            this.textBoxCodeIMEI.TabIndex = 13;
            // 
            // lblIdGoogle
            // 
            this.lblIdGoogle.AutoSize = true;
            this.lblIdGoogle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblIdGoogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdGoogle.Location = new System.Drawing.Point(246, 52);
            this.lblIdGoogle.Name = "lblIdGoogle";
            this.lblIdGoogle.Size = new System.Drawing.Size(76, 16);
            this.lblIdGoogle.TabIndex = 14;
            this.lblIdGoogle.Text = "Id Google : ";
            // 
            // textBoxIdGoogle
            // 
            this.textBoxIdGoogle.Location = new System.Drawing.Point(249, 72);
            this.textBoxIdGoogle.MaxLength = 255;
            this.textBoxIdGoogle.Multiline = true;
            this.textBoxIdGoogle.Name = "textBoxIdGoogle";
            this.textBoxIdGoogle.Size = new System.Drawing.Size(189, 116);
            this.textBoxIdGoogle.TabIndex = 15;
            // 
            // lblEtatMateriel
            // 
            this.lblEtatMateriel.AutoSize = true;
            this.lblEtatMateriel.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEtatMateriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtatMateriel.Location = new System.Drawing.Point(12, 147);
            this.lblEtatMateriel.Name = "lblEtatMateriel";
            this.lblEtatMateriel.Size = new System.Drawing.Size(88, 16);
            this.lblEtatMateriel.TabIndex = 46;
            this.lblEtatMateriel.Text = "Etat Matériel :";
            // 
            // comBoxEtatMateriel
            // 
            this.comBoxEtatMateriel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxEtatMateriel.FormattingEnabled = true;
            this.comBoxEtatMateriel.Items.AddRange(new object[] {
            "stock",
            "enService",
            "enPanne",
            "vol",
            "declasse",
            "perdu"});
            this.comBoxEtatMateriel.Location = new System.Drawing.Point(15, 167);
            this.comBoxEtatMateriel.Name = "comBoxEtatMateriel";
            this.comBoxEtatMateriel.Size = new System.Drawing.Size(189, 21);
            this.comBoxEtatMateriel.TabIndex = 52;
            // 
            // mTxtBoxNumtel
            // 
            this.mTxtBoxNumtel.BeepOnError = true;
            this.mTxtBoxNumtel.Location = new System.Drawing.Point(15, 114);
            this.mTxtBoxNumtel.Mask = "0000000000";
            this.mTxtBoxNumtel.Name = "mTxtBoxNumtel";
            this.mTxtBoxNumtel.PromptChar = ' ';
            this.mTxtBoxNumtel.Size = new System.Drawing.Size(70, 20);
            this.mTxtBoxNumtel.TabIndex = 53;
            this.mTxtBoxNumtel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mTxtBoxNumtel_MouseClick);
            // 
            // AjouterMaterielForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 247);
            this.Controls.Add(this.mTxtBoxNumtel);
            this.Controls.Add(this.comBoxEtatMateriel);
            this.Controls.Add(this.lblEtatMateriel);
            this.Controls.Add(this.textBoxIdGoogle);
            this.Controls.Add(this.lblIdGoogle);
            this.Controls.Add(this.textBoxCodeIMEI);
            this.Controls.Add(this.lblImei);
            this.Controls.Add(this.lblNumeroTel);
            this.Controls.Add(this.textBoxNumSerie);
            this.Controls.Add(this.textBoxTypeMateriel);
            this.Controls.Add(this.btnViderChamps);
            this.Controls.Add(this.LblNumeroSerie);
            this.Controls.Add(this.lblTypeMateriel);
            this.Controls.Add(this.btnAjouterMateriel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(230, 170);
            this.Name = "AjouterMaterielForm";
            this.Text = "Ajouter Materiels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumSerie;
        private System.Windows.Forms.TextBox textBoxTypeMateriel;
        private System.Windows.Forms.Button btnViderChamps;
        private System.Windows.Forms.Label LblNumeroSerie;
        private System.Windows.Forms.Label lblTypeMateriel;
        private System.Windows.Forms.Button btnAjouterMateriel;
        private System.Windows.Forms.Label lblNumeroTel;
        private System.Windows.Forms.Label lblImei;
        private System.Windows.Forms.TextBox textBoxCodeIMEI;
        private System.Windows.Forms.Label lblIdGoogle;
        private System.Windows.Forms.TextBox textBoxIdGoogle;
        private System.Windows.Forms.Label lblEtatMateriel;
        private System.Windows.Forms.ComboBox comBoxEtatMateriel;
        private System.Windows.Forms.MaskedTextBox mTxtBoxNumtel;
    }
}