namespace Dispatcher
{
    partial class AffecterMaterielFormulaire
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
            this.lblChoisirMateriel = new System.Windows.Forms.Label();
            this.mTxtBoxNumtel = new System.Windows.Forms.MaskedTextBox();
            this.lblNumeroTel = new System.Windows.Forms.Label();
            this.textBoxNumSerie = new System.Windows.Forms.TextBox();
            this.textBoxTypeMateriel = new System.Windows.Forms.TextBox();
            this.lblNumeroSerie = new System.Windows.Forms.Label();
            this.lblTypeMateriel = new System.Windows.Forms.Label();
            this.lblChoixTechnicien = new System.Windows.Forms.Label();
            this.dgvListeTechniciens = new System.Windows.Forms.DataGridView();
            this.ColLoginT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrenomTech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNomTech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAttribuerMateriel = new System.Windows.Forms.Button();
            this.dgvMateriels = new System.Windows.Forms.DataGridView();
            this.IdMateriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeMateriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeTechniciens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriels)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChoisirMateriel
            // 
            this.lblChoisirMateriel.AutoSize = true;
            this.lblChoisirMateriel.Location = new System.Drawing.Point(12, 9);
            this.lblChoisirMateriel.Name = "lblChoisirMateriel";
            this.lblChoisirMateriel.Size = new System.Drawing.Size(144, 13);
            this.lblChoisirMateriel.TabIndex = 0;
            this.lblChoisirMateriel.Text = "Choisir le matériel à attribuer :\r\n";
            // 
            // mTxtBoxNumtel
            // 
            this.mTxtBoxNumtel.BeepOnError = true;
            this.mTxtBoxNumtel.Location = new System.Drawing.Point(15, 283);
            this.mTxtBoxNumtel.Mask = "0000000000";
            this.mTxtBoxNumtel.Name = "mTxtBoxNumtel";
            this.mTxtBoxNumtel.PromptChar = ' ';
            this.mTxtBoxNumtel.Size = new System.Drawing.Size(70, 20);
            this.mTxtBoxNumtel.TabIndex = 77;
            this.mTxtBoxNumtel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mTxtBoxNumtel_MouseClick);
            // 
            // lblNumeroTel
            // 
            this.lblNumeroTel.AutoSize = true;
            this.lblNumeroTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTel.Location = new System.Drawing.Point(12, 264);
            this.lblNumeroTel.Name = "lblNumeroTel";
            this.lblNumeroTel.Size = new System.Drawing.Size(144, 16);
            this.lblNumeroTel.TabIndex = 76;
            this.lblNumeroTel.Text = "Numéro de téléphone :";
            // 
            // textBoxNumSerie
            // 
            this.textBoxNumSerie.Location = new System.Drawing.Point(15, 241);
            this.textBoxNumSerie.MaxLength = 17;
            this.textBoxNumSerie.Name = "textBoxNumSerie";
            this.textBoxNumSerie.ReadOnly = true;
            this.textBoxNumSerie.Size = new System.Drawing.Size(189, 20);
            this.textBoxNumSerie.TabIndex = 73;
            // 
            // textBoxTypeMateriel
            // 
            this.textBoxTypeMateriel.Location = new System.Drawing.Point(15, 199);
            this.textBoxTypeMateriel.MaxLength = 10;
            this.textBoxTypeMateriel.Name = "textBoxTypeMateriel";
            this.textBoxTypeMateriel.ReadOnly = true;
            this.textBoxTypeMateriel.Size = new System.Drawing.Size(189, 20);
            this.textBoxTypeMateriel.TabIndex = 72;
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroSerie.Location = new System.Drawing.Point(12, 222);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(114, 16);
            this.lblNumeroSerie.TabIndex = 75;
            this.lblNumeroSerie.Text = "Numéro de série :";
            // 
            // lblTypeMateriel
            // 
            this.lblTypeMateriel.AutoSize = true;
            this.lblTypeMateriel.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTypeMateriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeMateriel.Location = new System.Drawing.Point(12, 180);
            this.lblTypeMateriel.Name = "lblTypeMateriel";
            this.lblTypeMateriel.Size = new System.Drawing.Size(97, 16);
            this.lblTypeMateriel.TabIndex = 74;
            this.lblTypeMateriel.Text = "Type Matériel :";
            // 
            // lblChoixTechnicien
            // 
            this.lblChoixTechnicien.AutoSize = true;
            this.lblChoixTechnicien.Location = new System.Drawing.Point(282, 9);
            this.lblChoixTechnicien.Name = "lblChoixTechnicien";
            this.lblChoixTechnicien.Size = new System.Drawing.Size(209, 13);
            this.lblChoixTechnicien.TabIndex = 78;
            this.lblChoixTechnicien.Text = "Choisir le technicien dépourvu de matériel :\r\n";
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
            this.ColNomTech});
            this.dgvListeTechniciens.Location = new System.Drawing.Point(285, 37);
            this.dgvListeTechniciens.MultiSelect = false;
            this.dgvListeTechniciens.Name = "dgvListeTechniciens";
            this.dgvListeTechniciens.ReadOnly = true;
            this.dgvListeTechniciens.RowHeadersVisible = false;
            this.dgvListeTechniciens.Size = new System.Drawing.Size(203, 121);
            this.dgvListeTechniciens.TabIndex = 79;
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
            this.ColPrenomTech.HeaderText = "Prénom";
            this.ColPrenomTech.MinimumWidth = 100;
            this.ColPrenomTech.Name = "ColPrenomTech";
            this.ColPrenomTech.ReadOnly = true;
            // 
            // ColNomTech
            // 
            this.ColNomTech.HeaderText = "Nom";
            this.ColNomTech.MinimumWidth = 100;
            this.ColNomTech.Name = "ColNomTech";
            this.ColNomTech.ReadOnly = true;
            // 
            // btnAttribuerMateriel
            // 
            this.btnAttribuerMateriel.Location = new System.Drawing.Point(327, 222);
            this.btnAttribuerMateriel.Name = "btnAttribuerMateriel";
            this.btnAttribuerMateriel.Size = new System.Drawing.Size(164, 52);
            this.btnAttribuerMateriel.TabIndex = 80;
            this.btnAttribuerMateriel.Text = "Attribuer matériel";
            this.btnAttribuerMateriel.UseVisualStyleBackColor = true;
            this.btnAttribuerMateriel.Click += new System.EventHandler(this.btnAttribuerMateriel_Click);
            // 
            // dgvMateriels
            // 
            this.dgvMateriels.AllowUserToAddRows = false;
            this.dgvMateriels.AllowUserToDeleteRows = false;
            this.dgvMateriels.AllowUserToResizeColumns = false;
            this.dgvMateriels.AllowUserToResizeRows = false;
            this.dgvMateriels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMateriels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMateriel,
            this.TypeMateriel,
            this.NumeroSerie});
            this.dgvMateriels.Location = new System.Drawing.Point(15, 37);
            this.dgvMateriels.MultiSelect = false;
            this.dgvMateriels.Name = "dgvMateriels";
            this.dgvMateriels.ReadOnly = true;
            this.dgvMateriels.RowHeadersVisible = false;
            this.dgvMateriels.Size = new System.Drawing.Size(240, 121);
            this.dgvMateriels.TabIndex = 81;
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
            this.TypeMateriel.HeaderText = "Type Matériel";
            this.TypeMateriel.Name = "TypeMateriel";
            this.TypeMateriel.ReadOnly = true;
            // 
            // NumeroSerie
            // 
            this.NumeroSerie.HeaderText = "Numero de Série";
            this.NumeroSerie.Name = "NumeroSerie";
            this.NumeroSerie.ReadOnly = true;
            // 
            // AffecterMaterielFormulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 314);
            this.Controls.Add(this.dgvMateriels);
            this.Controls.Add(this.btnAttribuerMateriel);
            this.Controls.Add(this.dgvListeTechniciens);
            this.Controls.Add(this.lblChoixTechnicien);
            this.Controls.Add(this.mTxtBoxNumtel);
            this.Controls.Add(this.lblNumeroTel);
            this.Controls.Add(this.textBoxNumSerie);
            this.Controls.Add(this.textBoxTypeMateriel);
            this.Controls.Add(this.lblNumeroSerie);
            this.Controls.Add(this.lblTypeMateriel);
            this.Controls.Add(this.lblChoisirMateriel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(581, 353);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(581, 353);
            this.Name = "AffecterMaterielFormulaire";
            this.Text = "Attribuer materiel à un technicien";
            this.Load += new System.EventHandler(this.AffecterMaterielFormulaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeTechniciens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoisirMateriel;
        private System.Windows.Forms.MaskedTextBox mTxtBoxNumtel;
        private System.Windows.Forms.Label lblNumeroTel;
        private System.Windows.Forms.TextBox textBoxNumSerie;
        private System.Windows.Forms.TextBox textBoxTypeMateriel;
        private System.Windows.Forms.Label lblNumeroSerie;
        private System.Windows.Forms.Label lblTypeMateriel;
        private System.Windows.Forms.Label lblChoixTechnicien;
        private System.Windows.Forms.DataGridView dgvListeTechniciens;
        private System.Windows.Forms.Button btnAttribuerMateriel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLoginT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrenomTech;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomTech;
        private System.Windows.Forms.DataGridView dgvMateriels;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateriel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeMateriel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroSerie;
    }
}