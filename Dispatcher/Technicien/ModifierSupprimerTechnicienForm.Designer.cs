namespace Dispatcher
{
    partial class ModifierSupprimerTechnicienForm
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
            this.btnModifierTechnicien = new System.Windows.Forms.Button();
            this.btnResetSelectionTechniciens = new System.Windows.Forms.Button();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxLoginT = new System.Windows.Forms.TextBox();
            this.lblIdTechnicien = new System.Windows.Forms.Label();
            this.btnSupprimerTechnicien = new System.Windows.Forms.Button();
            this.dgvTechnicien = new System.Windows.Forms.DataGridView();
            this.ColNomTech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrenomTech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLoginTech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxMdp = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifierTechnicien
            // 
            this.btnModifierTechnicien.Location = new System.Drawing.Point(224, 275);
            this.btnModifierTechnicien.Name = "btnModifierTechnicien";
            this.btnModifierTechnicien.Size = new System.Drawing.Size(93, 52);
            this.btnModifierTechnicien.TabIndex = 24;
            this.btnModifierTechnicien.Text = "Modifier Technicien";
            this.btnModifierTechnicien.UseVisualStyleBackColor = true;
            this.btnModifierTechnicien.Click += new System.EventHandler(this.btnModifierTechnicien_Click);
            // 
            // btnResetSelectionTechniciens
            // 
            this.btnResetSelectionTechniciens.Location = new System.Drawing.Point(12, 275);
            this.btnResetSelectionTechniciens.Name = "btnResetSelectionTechniciens";
            this.btnResetSelectionTechniciens.Size = new System.Drawing.Size(100, 52);
            this.btnResetSelectionTechniciens.TabIndex = 23;
            this.btnResetSelectionTechniciens.Text = "Rafraichir les techniciens";
            this.btnResetSelectionTechniciens.UseVisualStyleBackColor = true;
            this.btnResetSelectionTechniciens.Click += new System.EventHandler(this.btnResetSelectionTechnciens_Click);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(357, 148);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenom.TabIndex = 19;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(354, 129);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(61, 16);
            this.lblPrenom.TabIndex = 15;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(354, 87);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(43, 16);
            this.lblNom.TabIndex = 14;
            this.lblNom.Text = "Nom :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(357, 106);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 13;
            // 
            // textBoxLoginT
            // 
            this.textBoxLoginT.Enabled = false;
            this.textBoxLoginT.Location = new System.Drawing.Point(357, 64);
            this.textBoxLoginT.Name = "textBoxLoginT";
            this.textBoxLoginT.Size = new System.Drawing.Size(100, 20);
            this.textBoxLoginT.TabIndex = 30;
            // 
            // lblIdTechnicien
            // 
            this.lblIdTechnicien.AutoSize = true;
            this.lblIdTechnicien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTechnicien.Location = new System.Drawing.Point(354, 45);
            this.lblIdTechnicien.Name = "lblIdTechnicien";
            this.lblIdTechnicien.Size = new System.Drawing.Size(116, 16);
            this.lblIdTechnicien.TabIndex = 29;
            this.lblIdTechnicien.Text = "Login Technicien :";
            // 
            // btnSupprimerTechnicien
            // 
            this.btnSupprimerTechnicien.Location = new System.Drawing.Point(118, 275);
            this.btnSupprimerTechnicien.Name = "btnSupprimerTechnicien";
            this.btnSupprimerTechnicien.Size = new System.Drawing.Size(91, 52);
            this.btnSupprimerTechnicien.TabIndex = 31;
            this.btnSupprimerTechnicien.Text = "Supprimer Technicien";
            this.btnSupprimerTechnicien.UseVisualStyleBackColor = true;
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
            this.dgvTechnicien.Location = new System.Drawing.Point(12, 12);
            this.dgvTechnicien.Name = "dgvTechnicien";
            this.dgvTechnicien.ReadOnly = true;
            this.dgvTechnicien.RowHeadersVisible = false;
            this.dgvTechnicien.Size = new System.Drawing.Size(305, 238);
            this.dgvTechnicien.TabIndex = 32;
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
            // 
            // txtBoxMdp
            // 
            this.txtBoxMdp.Location = new System.Drawing.Point(354, 190);
            this.txtBoxMdp.Name = "txtBoxMdp";
            this.txtBoxMdp.PasswordChar = '*';
            this.txtBoxMdp.Size = new System.Drawing.Size(103, 20);
            this.txtBoxMdp.TabIndex = 34;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.Location = new System.Drawing.Point(354, 171);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(96, 16);
            this.lblMdp.TabIndex = 33;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // ModifierSupprimerTechnicienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 334);
            this.Controls.Add(this.txtBoxMdp);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.dgvTechnicien);
            this.Controls.Add(this.btnSupprimerTechnicien);
            this.Controls.Add(this.textBoxLoginT);
            this.Controls.Add(this.lblIdTechnicien);
            this.Controls.Add(this.btnModifierTechnicien);
            this.Controls.Add(this.btnResetSelectionTechniciens);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.textBoxNom);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(508, 372);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(508, 372);
            this.Name = "ModifierSupprimerTechnicienForm";
            this.Text = "Modifier / Supprimer Techniciens";
            this.Load += new System.EventHandler(this.ModifierSupprimerTechnicienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifierTechnicien;
        private System.Windows.Forms.Button btnResetSelectionTechniciens;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxLoginT;
        private System.Windows.Forms.Label lblIdTechnicien;
        private System.Windows.Forms.Button btnSupprimerTechnicien;
        private System.Windows.Forms.DataGridView dgvTechnicien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomTech;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrenomTech;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLoginTech;
        private System.Windows.Forms.TextBox txtBoxMdp;
        private System.Windows.Forms.Label lblMdp;
    }
}