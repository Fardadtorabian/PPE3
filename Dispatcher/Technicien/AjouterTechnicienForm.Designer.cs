namespace Dispatcher
{
    partial class AjouterTechnicienForm
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
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxLoginT = new System.Windows.Forms.TextBox();
            this.btnViderChamps = new System.Windows.Forms.Button();
            this.btnAjouterTechnicien = new System.Windows.Forms.Button();
            this.txtBoxMdp = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(12, 23);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 0;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(9, 4);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(43, 16);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(136, 4);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(61, 16);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(12, 46);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(47, 16);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Login :";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(139, 23);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenom.TabIndex = 6;
            // 
            // textBoxLoginT
            // 
            this.textBoxLoginT.Location = new System.Drawing.Point(12, 63);
            this.textBoxLoginT.Name = "textBoxLoginT";
            this.textBoxLoginT.Size = new System.Drawing.Size(100, 20);
            this.textBoxLoginT.TabIndex = 8;
            // 
            // btnViderChamps
            // 
            this.btnViderChamps.Location = new System.Drawing.Point(12, 107);
            this.btnViderChamps.Name = "btnViderChamps";
            this.btnViderChamps.Size = new System.Drawing.Size(100, 26);
            this.btnViderChamps.TabIndex = 11;
            this.btnViderChamps.Text = "Vider les champs";
            this.btnViderChamps.UseVisualStyleBackColor = true;
            this.btnViderChamps.Click += new System.EventHandler(this.btnViderChamps_Click);
            // 
            // btnAjouterTechnicien
            // 
            this.btnAjouterTechnicien.Location = new System.Drawing.Point(12, 139);
            this.btnAjouterTechnicien.Name = "btnAjouterTechnicien";
            this.btnAjouterTechnicien.Size = new System.Drawing.Size(227, 23);
            this.btnAjouterTechnicien.TabIndex = 12;
            this.btnAjouterTechnicien.Text = "Ajouter Technicien";
            this.btnAjouterTechnicien.UseVisualStyleBackColor = true;
            this.btnAjouterTechnicien.Click += new System.EventHandler(this.btnAjouterTechnicien_Click);
            // 
            // txtBoxMdp
            // 
            this.txtBoxMdp.Location = new System.Drawing.Point(127, 63);
            this.txtBoxMdp.Name = "txtBoxMdp";
            this.txtBoxMdp.PasswordChar = '*';
            this.txtBoxMdp.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMdp.TabIndex = 14;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.Location = new System.Drawing.Point(127, 46);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(96, 16);
            this.lblMdp.TabIndex = 13;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // AjouterTechnicienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 169);
            this.Controls.Add(this.txtBoxMdp);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.btnAjouterTechnicien);
            this.Controls.Add(this.btnViderChamps);
            this.Controls.Add(this.textBoxLoginT);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.textBoxNom);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(266, 207);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(266, 207);
            this.Name = "AjouterTechnicienForm";
            this.Text = "Ajouter Techniciens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxLoginT;
        private System.Windows.Forms.Button btnViderChamps;
        private System.Windows.Forms.Button btnAjouterTechnicien;
        private System.Windows.Forms.TextBox txtBoxMdp;
        private System.Windows.Forms.Label lblMdp;
    }
}