namespace Dispatcher
{
    partial class ApercuInterventionForm
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
            this.dgvIntervention = new System.Windows.Forms.DataGridView();
            this.idIntervention = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebutIntervention = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtatVisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxNomContact = new System.Windows.Forms.TextBox();
            this.txtBoxPrenomContact = new System.Windows.Forms.TextBox();
            this.txtBoxTelContact = new System.Windows.Forms.TextBox();
            this.rTxtBoxObjectif = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rTxTBoxCompteR = new System.Windows.Forms.RichTextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.cBoxEtatVisite = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervention)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIntervention
            // 
            this.dgvIntervention.AllowUserToAddRows = false;
            this.dgvIntervention.AllowUserToDeleteRows = false;
            this.dgvIntervention.AllowUserToOrderColumns = true;
            this.dgvIntervention.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntervention.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idIntervention,
            this.NomContact,
            this.PrenomContact,
            this.DebutIntervention,
            this.EtatVisite,
            this.Nom,
            this.Prenom});
            this.dgvIntervention.Location = new System.Drawing.Point(12, 12);
            this.dgvIntervention.Name = "dgvIntervention";
            this.dgvIntervention.ReadOnly = true;
            this.dgvIntervention.Size = new System.Drawing.Size(656, 150);
            this.dgvIntervention.TabIndex = 0;
            // 
            // idIntervention
            // 
            this.idIntervention.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idIntervention.HeaderText = "Id de l\'intervention";
            this.idIntervention.Name = "idIntervention";
            this.idIntervention.ReadOnly = true;
            this.idIntervention.Width = 70;
            // 
            // NomContact
            // 
            this.NomContact.HeaderText = "Nom du contact";
            this.NomContact.Name = "NomContact";
            this.NomContact.ReadOnly = true;
            // 
            // PrenomContact
            // 
            this.PrenomContact.HeaderText = "Prenom du contact";
            this.PrenomContact.Name = "PrenomContact";
            this.PrenomContact.ReadOnly = true;
            // 
            // DebutIntervention
            // 
            this.DebutIntervention.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DebutIntervention.HeaderText = "Debut";
            this.DebutIntervention.Name = "DebutIntervention";
            this.DebutIntervention.ReadOnly = true;
            this.DebutIntervention.Width = 61;
            // 
            // EtatVisite
            // 
            this.EtatVisite.HeaderText = "Etat de la visite";
            this.EtatVisite.Name = "EtatVisite";
            this.EtatVisite.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom du technicien";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom du technicien";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom du contact :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenom du contact :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telephone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Objectif :";
            // 
            // txtBoxNomContact
            // 
            this.txtBoxNomContact.Location = new System.Drawing.Point(131, 168);
            this.txtBoxNomContact.Name = "txtBoxNomContact";
            this.txtBoxNomContact.ReadOnly = true;
            this.txtBoxNomContact.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNomContact.TabIndex = 5;
            // 
            // txtBoxPrenomContact
            // 
            this.txtBoxPrenomContact.Location = new System.Drawing.Point(131, 196);
            this.txtBoxPrenomContact.Name = "txtBoxPrenomContact";
            this.txtBoxPrenomContact.ReadOnly = true;
            this.txtBoxPrenomContact.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrenomContact.TabIndex = 6;
            // 
            // txtBoxTelContact
            // 
            this.txtBoxTelContact.Location = new System.Drawing.Point(131, 223);
            this.txtBoxTelContact.Name = "txtBoxTelContact";
            this.txtBoxTelContact.ReadOnly = true;
            this.txtBoxTelContact.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTelContact.TabIndex = 7;
            // 
            // rTxtBoxObjectif
            // 
            this.rTxtBoxObjectif.Location = new System.Drawing.Point(255, 188);
            this.rTxtBoxObjectif.Name = "rTxtBoxObjectif";
            this.rTxtBoxObjectif.ReadOnly = true;
            this.rTxtBoxObjectif.Size = new System.Drawing.Size(100, 75);
            this.rTxtBoxObjectif.TabIndex = 8;
            this.rTxtBoxObjectif.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Etat de la Visite :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Compte rendu";
            // 
            // rTxTBoxCompteR
            // 
            this.rTxTBoxCompteR.Location = new System.Drawing.Point(361, 188);
            this.rTxTBoxCompteR.Name = "rTxTBoxCompteR";
            this.rTxTBoxCompteR.Size = new System.Drawing.Size(100, 77);
            this.rTxTBoxCompteR.TabIndex = 11;
            this.rTxTBoxCompteR.Text = "";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(593, 242);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 12;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // cBoxEtatVisite
            // 
            this.cBoxEtatVisite.FormattingEnabled = true;
            this.cBoxEtatVisite.Items.AddRange(new object[] {
            "planifiée",
            "à renouveler",
            "effectuée",
            "absence"});
            this.cBoxEtatVisite.Location = new System.Drawing.Point(474, 188);
            this.cBoxEtatVisite.Name = "cBoxEtatVisite";
            this.cBoxEtatVisite.Size = new System.Drawing.Size(121, 21);
            this.cBoxEtatVisite.TabIndex = 13;
            // 
            // ApercuInterventionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 276);
            this.Controls.Add(this.cBoxEtatVisite);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.rTxTBoxCompteR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rTxtBoxObjectif);
            this.Controls.Add(this.txtBoxTelContact);
            this.Controls.Add(this.txtBoxPrenomContact);
            this.Controls.Add(this.txtBoxNomContact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIntervention);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 315);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 315);
            this.Name = "ApercuInterventionForm";
            this.Text = "Apercu des Interventions";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervention)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIntervention;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxNomContact;
        private System.Windows.Forms.TextBox txtBoxPrenomContact;
        private System.Windows.Forms.TextBox txtBoxTelContact;
        private System.Windows.Forms.RichTextBox rTxtBoxObjectif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rTxTBoxCompteR;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cBoxEtatVisite;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIntervention;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebutIntervention;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtatVisite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
    }
}