namespace Ranch_Sorting_App
{
    partial class NouvelleEquipe
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
            txtBoxNomPremierCheval = new TextBox();
            LblCheval1 = new Label();
            txtBoxPremierCavalier = new TextBox();
            txtBoxNomNouvelleEquipe = new TextBox();
            btnValiderNouveauLieu = new Button();
            lblCavalier1 = new Label();
            lblNomNouvelleEquipe = new Label();
            txtBoxNomDeuxiemeCheval = new TextBox();
            lblNomDeuxiemeCheval = new Label();
            txtBoxNomDeuxiemeCavalier = new TextBox();
            lblNomDeuxiemeCavalier = new Label();
            SuspendLayout();
            // 
            // txtBoxNomPremierCheval
            // 
            txtBoxNomPremierCheval.Location = new Point(859, 94);
            txtBoxNomPremierCheval.Name = "txtBoxNomPremierCheval";
            txtBoxNomPremierCheval.Size = new Size(168, 23);
            txtBoxNomPremierCheval.TabIndex = 20;
            txtBoxNomPremierCheval.TextChanged += txtBoxNomProprietaire_TextChanged;
            // 
            // LblCheval1
            // 
            LblCheval1.AutoSize = true;
            LblCheval1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblCheval1.Location = new Point(587, 94);
            LblCheval1.Name = "LblCheval1";
            LblCheval1.Size = new Size(235, 25);
            LblCheval1.TabIndex = 19;
            LblCheval1.Text = "Nom du premier cheval  :";
            LblCheval1.Click += LblProprietaire_Click;
            // 
            // txtBoxPremierCavalier
            // 
            txtBoxPremierCavalier.Location = new Point(335, 94);
            txtBoxPremierCavalier.Name = "txtBoxPremierCavalier";
            txtBoxPremierCavalier.Size = new Size(168, 23);
            txtBoxPremierCavalier.TabIndex = 18;
            txtBoxPremierCavalier.TextChanged += txtBoxAdresse_TextChanged;
            // 
            // txtBoxNomNouvelleEquipe
            // 
            txtBoxNomNouvelleEquipe.Location = new Point(614, 32);
            txtBoxNomNouvelleEquipe.Name = "txtBoxNomNouvelleEquipe";
            txtBoxNomNouvelleEquipe.Size = new Size(168, 23);
            txtBoxNomNouvelleEquipe.TabIndex = 17;
            txtBoxNomNouvelleEquipe.TextChanged += txtBoxNomNouveauLieu_TextChanged;
            // 
            // btnValiderNouveauLieu
            // 
            btnValiderNouveauLieu.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnValiderNouveauLieu.Location = new Point(487, 215);
            btnValiderNouveauLieu.Name = "btnValiderNouveauLieu";
            btnValiderNouveauLieu.Size = new Size(110, 50);
            btnValiderNouveauLieu.TabIndex = 16;
            btnValiderNouveauLieu.Text = "Valider";
            btnValiderNouveauLieu.UseVisualStyleBackColor = true;
            btnValiderNouveauLieu.Click += btnValiderNouveauLieu_Click;
            // 
            // lblCavalier1
            // 
            lblCavalier1.AutoSize = true;
            lblCavalier1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCavalier1.Location = new Point(43, 89);
            lblCavalier1.Name = "lblCavalier1";
            lblCavalier1.Size = new Size(247, 25);
            lblCavalier1.TabIndex = 15;
            lblCavalier1.Text = "Nom du premier cavalier : ";
            lblCavalier1.Click += lblAdresse_Click;
            // 
            // lblNomNouvelleEquipe
            // 
            lblNomNouvelleEquipe.AutoSize = true;
            lblNomNouvelleEquipe.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomNouvelleEquipe.Location = new Point(287, 32);
            lblNomNouvelleEquipe.Name = "lblNomNouvelleEquipe";
            lblNomNouvelleEquipe.Size = new Size(260, 25);
            lblNomNouvelleEquipe.TabIndex = 14;
            lblNomNouvelleEquipe.Text = "Nom de la nouvelle equipe :";
            lblNomNouvelleEquipe.Click += lblNomNouveauLieu_Click;
            // 
            // txtBoxNomDeuxiemeCheval
            // 
            txtBoxNomDeuxiemeCheval.Location = new Point(859, 152);
            txtBoxNomDeuxiemeCheval.Name = "txtBoxNomDeuxiemeCheval";
            txtBoxNomDeuxiemeCheval.Size = new Size(168, 23);
            txtBoxNomDeuxiemeCheval.TabIndex = 24;
            // 
            // lblNomDeuxiemeCheval
            // 
            lblNomDeuxiemeCheval.AutoSize = true;
            lblNomDeuxiemeCheval.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomDeuxiemeCheval.Location = new Point(587, 152);
            lblNomDeuxiemeCheval.Name = "lblNomDeuxiemeCheval";
            lblNomDeuxiemeCheval.Size = new Size(252, 25);
            lblNomDeuxiemeCheval.TabIndex = 23;
            lblNomDeuxiemeCheval.Text = "Nom du deuxieme cheval  :";
            // 
            // txtBoxNomDeuxiemeCavalier
            // 
            txtBoxNomDeuxiemeCavalier.Location = new Point(335, 152);
            txtBoxNomDeuxiemeCavalier.Name = "txtBoxNomDeuxiemeCavalier";
            txtBoxNomDeuxiemeCavalier.Size = new Size(168, 23);
            txtBoxNomDeuxiemeCavalier.TabIndex = 22;
            // 
            // lblNomDeuxiemeCavalier
            // 
            lblNomDeuxiemeCavalier.AutoSize = true;
            lblNomDeuxiemeCavalier.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomDeuxiemeCavalier.Location = new Point(43, 147);
            lblNomDeuxiemeCavalier.Name = "lblNomDeuxiemeCavalier";
            lblNomDeuxiemeCavalier.Size = new Size(264, 25);
            lblNomDeuxiemeCavalier.TabIndex = 21;
            lblNomDeuxiemeCavalier.Text = "Nom du deuxieme cavalier : ";
            // 
            // NouvelleEquipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 302);
            Controls.Add(txtBoxNomDeuxiemeCheval);
            Controls.Add(lblNomDeuxiemeCheval);
            Controls.Add(txtBoxNomDeuxiemeCavalier);
            Controls.Add(lblNomDeuxiemeCavalier);
            Controls.Add(txtBoxNomPremierCheval);
            Controls.Add(LblCheval1);
            Controls.Add(txtBoxPremierCavalier);
            Controls.Add(txtBoxNomNouvelleEquipe);
            Controls.Add(btnValiderNouveauLieu);
            Controls.Add(lblCavalier1);
            Controls.Add(lblNomNouvelleEquipe);
            Name = "NouvelleEquipe";
            Text = "NouvelleEquipe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxNomPremierCheval;
        private Label LblCheval1;
        private TextBox txtBoxPremierCavalier;
        private TextBox txtBoxNomNouvelleEquipe;
        private Button btnValiderNouveauLieu;
        private Label lblCavalier1;
        private Label lblNomNouvelleEquipe;
        private TextBox txtBoxNomDeuxiemeCheval;
        private Label lblNomDeuxiemeCheval;
        private TextBox txtBoxNomDeuxiemeCavalier;
        private Label lblNomDeuxiemeCavalier;
    }
}