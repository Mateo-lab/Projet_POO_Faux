namespace Ranch_Sorting_App
{
    partial class Main
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
            splitContainer1 = new SplitContainer();
            richTextBox1 = new RichTextBox();
            splitContainer2 = new SplitContainer();
            domainUpDown1 = new DomainUpDown();
            txtBoxNomEpreuve = new TextBox();
            btnValiderEpreuve = new Button();
            btnNouveauLieu = new Button();
            lblNomLieu = new Label();
            lblNomEpreuve = new Label();
            btnSupprimerEquipe = new Button();
            btnStart = new Button();
            btnNouvelleEquipe = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(richTextBox1);
            splitContainer1.Panel1.RightToLeft = RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2.RightToLeft = RightToLeft.No;
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 350;
            splitContainer1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(50, 73);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(242, 294);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "Ici on affice la base de donné mais attention pas dans cette text box";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(domainUpDown1);
            splitContainer2.Panel1.Controls.Add(txtBoxNomEpreuve);
            splitContainer2.Panel1.Controls.Add(btnValiderEpreuve);
            splitContainer2.Panel1.Controls.Add(btnNouveauLieu);
            splitContainer2.Panel1.Controls.Add(lblNomLieu);
            splitContainer2.Panel1.Controls.Add(lblNomEpreuve);
            splitContainer2.Panel1.RightToLeft = RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(btnSupprimerEquipe);
            splitContainer2.Panel2.Controls.Add(btnStart);
            splitContainer2.Panel2.Controls.Add(btnNouvelleEquipe);
            splitContainer2.Panel2.RightToLeft = RightToLeft.No;
            splitContainer2.Size = new Size(442, 446);
            splitContainer2.SplitterDistance = 223;
            splitContainer2.TabIndex = 0;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(264, 104);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(168, 23);
            domainUpDown1.TabIndex = 11;
            domainUpDown1.Text = "Séléctionner le lieu";
            domainUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxNomEpreuve
            // 
            txtBoxNomEpreuve.Location = new Point(264, 36);
            txtBoxNomEpreuve.Name = "txtBoxNomEpreuve";
            txtBoxNomEpreuve.Size = new Size(168, 23);
            txtBoxNomEpreuve.TabIndex = 10;
            // 
            // btnValiderEpreuve
            // 
            btnValiderEpreuve.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnValiderEpreuve.Location = new Point(292, 158);
            btnValiderEpreuve.Name = "btnValiderEpreuve";
            btnValiderEpreuve.Size = new Size(78, 38);
            btnValiderEpreuve.TabIndex = 9;
            btnValiderEpreuve.Text = "Valider";
            btnValiderEpreuve.UseVisualStyleBackColor = true;
            // 
            // btnNouveauLieu
            // 
            btnNouveauLieu.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNouveauLieu.Location = new Point(15, 158);
            btnNouveauLieu.Name = "btnNouveauLieu";
            btnNouveauLieu.Size = new Size(186, 38);
            btnNouveauLieu.TabIndex = 8;
            btnNouveauLieu.Text = "Ajouter un nouveau lieu";
            btnNouveauLieu.UseVisualStyleBackColor = true;
            btnNouveauLieu.Click += btnNouveauLieu_Click;
            // 
            // lblNomLieu
            // 
            lblNomLieu.AutoSize = true;
            lblNomLieu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomLieu.Location = new Point(15, 104);
            lblNomLieu.Name = "lblNomLieu";
            lblNomLieu.Size = new Size(137, 25);
            lblNomLieu.TabIndex = 7;
            lblNomLieu.Text = "Nom du Lieu :";
            // 
            // lblNomEpreuve
            // 
            lblNomEpreuve.AutoSize = true;
            lblNomEpreuve.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomEpreuve.Location = new Point(15, 31);
            lblNomEpreuve.Name = "lblNomEpreuve";
            lblNomEpreuve.Size = new Size(186, 25);
            lblNomEpreuve.TabIndex = 6;
            lblNomEpreuve.Text = "Nom de L'épreuve :";
            // 
            // btnSupprimerEquipe
            // 
            btnSupprimerEquipe.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSupprimerEquipe.Location = new Point(243, 58);
            btnSupprimerEquipe.Name = "btnSupprimerEquipe";
            btnSupprimerEquipe.Size = new Size(189, 42);
            btnSupprimerEquipe.TabIndex = 4;
            btnSupprimerEquipe.Text = "Supprimer une Equipe";
            btnSupprimerEquipe.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(129, 166);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(189, 42);
            btnStart.TabIndex = 5;
            btnStart.Text = "Démarrer";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnNouvelleEquipe
            // 
            btnNouvelleEquipe.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNouvelleEquipe.Location = new Point(15, 58);
            btnNouvelleEquipe.Name = "btnNouvelleEquipe";
            btnNouvelleEquipe.Size = new Size(189, 42);
            btnNouvelleEquipe.TabIndex = 3;
            btnNouvelleEquipe.Text = "Ajouter une Equipe";
            btnNouvelleEquipe.UseVisualStyleBackColor = true;
            btnNouvelleEquipe.Click += btnNouvelleEquipe_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Main";
            Text = "Main";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private DomainUpDown domainUpDown1;
        private TextBox txtBoxNomEpreuve;
        private Button btnValiderEpreuve;
        private Button btnNouveauLieu;
        private Label lblNomLieu;
        private Label lblNomEpreuve;
        private Button btnSupprimerEquipe;
        private Button btnStart;
        private Button btnNouvelleEquipe;
        private RichTextBox richTextBox1;
    }
}