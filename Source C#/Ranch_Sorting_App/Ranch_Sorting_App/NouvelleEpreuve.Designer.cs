namespace Ranch_Sorting_App
{
    partial class NouvelleEpreuve
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
            lblNomEpreuve = new Label();
            lblNomLieu = new Label();
            btnNouveauLieu = new Button();
            btnValiderEpreuve = new Button();
            txtBoxNomEpreuve = new TextBox();
            domainUpDown1 = new DomainUpDown();
            SuspendLayout();
            // 
            // lblNomEpreuve
            // 
            lblNomEpreuve.AutoSize = true;
            lblNomEpreuve.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomEpreuve.Location = new Point(40, 59);
            lblNomEpreuve.Name = "lblNomEpreuve";
            lblNomEpreuve.Size = new Size(186, 25);
            lblNomEpreuve.TabIndex = 0;
            lblNomEpreuve.Text = "Nom de L'épreuve :";
            // 
            // lblNomLieu
            // 
            lblNomLieu.AutoSize = true;
            lblNomLieu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomLieu.Location = new Point(40, 132);
            lblNomLieu.Name = "lblNomLieu";
            lblNomLieu.Size = new Size(137, 25);
            lblNomLieu.TabIndex = 1;
            lblNomLieu.Text = "Nom du Lieu :";
            // 
            // btnNouveauLieu
            // 
            btnNouveauLieu.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNouveauLieu.Location = new Point(40, 186);
            btnNouveauLieu.Name = "btnNouveauLieu";
            btnNouveauLieu.Size = new Size(186, 38);
            btnNouveauLieu.TabIndex = 2;
            btnNouveauLieu.Text = "Ajouter un nouveau lieu";
            btnNouveauLieu.UseVisualStyleBackColor = true;
            btnNouveauLieu.Click += btnNouveauLieu_Click;
            // 
            // btnValiderEpreuve
            // 
            btnValiderEpreuve.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnValiderEpreuve.Location = new Point(317, 186);
            btnValiderEpreuve.Name = "btnValiderEpreuve";
            btnValiderEpreuve.Size = new Size(78, 38);
            btnValiderEpreuve.TabIndex = 3;
            btnValiderEpreuve.Text = "Valider";
            btnValiderEpreuve.UseVisualStyleBackColor = true;
            btnValiderEpreuve.Click += btnValiderEpreuve_Click;
            // 
            // txtBoxNomEpreuve
            // 
            txtBoxNomEpreuve.Location = new Point(289, 64);
            txtBoxNomEpreuve.Name = "txtBoxNomEpreuve";
            txtBoxNomEpreuve.Size = new Size(168, 23);
            txtBoxNomEpreuve.TabIndex = 4;
            txtBoxNomEpreuve.TextChanged += textBox1_TextChanged;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(289, 132);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(168, 23);
            domainUpDown1.TabIndex = 5;
            domainUpDown1.Text = "Séléctionner le lieu";
            domainUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // NouvelleEpreuve
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 267);
            Controls.Add(domainUpDown1);
            Controls.Add(txtBoxNomEpreuve);
            Controls.Add(btnValiderEpreuve);
            Controls.Add(btnNouveauLieu);
            Controls.Add(lblNomLieu);
            Controls.Add(lblNomEpreuve);
            Name = "NouvelleEpreuve";
            Text = "NouvelleEpreuve";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomEpreuve;
        private Label lblNomLieu;
        private Button btnNouveauLieu;
        private Button btnValiderEpreuve;
        private TextBox txtBoxNomEpreuve;
        private DomainUpDown domainUpDown1;
    }
}