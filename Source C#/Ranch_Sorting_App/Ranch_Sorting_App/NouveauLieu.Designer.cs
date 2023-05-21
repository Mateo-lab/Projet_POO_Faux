namespace Ranch_Sorting_App
{
    partial class NouveauLieu
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
            txtBoxNomNouveauLieu = new TextBox();
            btnValiderNouveauLieu = new Button();
            lblAdresse = new Label();
            lblNomNouveauLieu = new Label();
            txtBoxAdresse = new TextBox();
            txtBoxNomProprietaire = new TextBox();
            LblProprietaire = new Label();
            SuspendLayout();
            // 
            // txtBoxNomNouveauLieu
            // 
            txtBoxNomNouveauLieu.Location = new Point(290, 43);
            txtBoxNomNouveauLieu.Name = "txtBoxNomNouveauLieu";
            txtBoxNomNouveauLieu.Size = new Size(168, 23);
            txtBoxNomNouveauLieu.TabIndex = 10;
            txtBoxNomNouveauLieu.TextChanged += txtBoxNomEpreuve_TextChanged;
            // 
            // btnValiderNouveauLieu
            // 
            btnValiderNouveauLieu.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnValiderNouveauLieu.Location = new Point(203, 214);
            btnValiderNouveauLieu.Name = "btnValiderNouveauLieu";
            btnValiderNouveauLieu.Size = new Size(78, 38);
            btnValiderNouveauLieu.TabIndex = 9;
            btnValiderNouveauLieu.Text = "Valider";
            btnValiderNouveauLieu.UseVisualStyleBackColor = true;
            btnValiderNouveauLieu.Click += btnValiderEpreuve_Click;
            // 
            // lblAdresse
            // 
            lblAdresse.AutoSize = true;
            lblAdresse.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdresse.Location = new Point(41, 102);
            lblAdresse.Name = "lblAdresse";
            lblAdresse.Size = new Size(162, 25);
            lblAdresse.TabIndex = 7;
            lblAdresse.Text = "Adresse du Lieu :";
            lblAdresse.Click += lblNomLieu_Click;
            // 
            // lblNomNouveauLieu
            // 
            lblNomNouveauLieu.AutoSize = true;
            lblNomNouveauLieu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomNouveauLieu.Location = new Point(41, 43);
            lblNomNouveauLieu.Name = "lblNomNouveauLieu";
            lblNomNouveauLieu.Size = new Size(137, 25);
            lblNomNouveauLieu.TabIndex = 6;
            lblNomNouveauLieu.Text = "Nom du Lieu :";
            lblNomNouveauLieu.Click += lblNomEpreuve_Click;
            // 
            // txtBoxAdresse
            // 
            txtBoxAdresse.Location = new Point(290, 107);
            txtBoxAdresse.Name = "txtBoxAdresse";
            txtBoxAdresse.Size = new Size(168, 23);
            txtBoxAdresse.TabIndex = 11;
            // 
            // txtBoxNomProprietaire
            // 
            txtBoxNomProprietaire.Location = new Point(290, 170);
            txtBoxNomProprietaire.Name = "txtBoxNomProprietaire";
            txtBoxNomProprietaire.Size = new Size(168, 23);
            txtBoxNomProprietaire.TabIndex = 13;
            txtBoxNomProprietaire.TextChanged += textBox1_TextChanged;
            // 
            // LblProprietaire
            // 
            LblProprietaire.AutoSize = true;
            LblProprietaire.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblProprietaire.Location = new Point(41, 170);
            LblProprietaire.Name = "LblProprietaire";
            LblProprietaire.Size = new Size(207, 25);
            LblProprietaire.TabIndex = 12;
            LblProprietaire.Text = "Nom du Proprietaire :";
            LblProprietaire.Click += label1_Click;
            // 
            // NouveauLieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 280);
            Controls.Add(txtBoxNomProprietaire);
            Controls.Add(LblProprietaire);
            Controls.Add(txtBoxAdresse);
            Controls.Add(txtBoxNomNouveauLieu);
            Controls.Add(btnValiderNouveauLieu);
            Controls.Add(lblAdresse);
            Controls.Add(lblNomNouveauLieu);
            Name = "NouveauLieu";
            Text = "NouveauLieu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DomainUpDown domainUpDown1;
        private TextBox txtBoxNomNouveauLieu;
        private Button btnValiderNouveauLieu;
        private Label lblAdresse;
        private Label lblNomNouveauLieu;
        private TextBox txtBoxAdresse;
        private TextBox txtBoxNomProprietaire;
        private Label LblProprietaire;
    }
}