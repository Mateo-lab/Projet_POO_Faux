namespace Ranch_Sorting_App
{
    partial class AffichageEquipe
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
            btnNouvelleEquipe = new Button();
            btnSupprimerEquipe = new Button();
            btnStart = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnNouvelleEquipe
            // 
            btnNouvelleEquipe.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNouvelleEquipe.Location = new Point(483, 71);
            btnNouvelleEquipe.Name = "btnNouvelleEquipe";
            btnNouvelleEquipe.Size = new Size(189, 42);
            btnNouvelleEquipe.TabIndex = 0;
            btnNouvelleEquipe.Text = "Ajouter une Equipe";
            btnNouvelleEquipe.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerEquipe
            // 
            btnSupprimerEquipe.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSupprimerEquipe.Location = new Point(483, 140);
            btnSupprimerEquipe.Name = "btnSupprimerEquipe";
            btnSupprimerEquipe.Size = new Size(189, 42);
            btnSupprimerEquipe.TabIndex = 1;
            btnSupprimerEquipe.Text = "Supprimer une Equipe";
            btnSupprimerEquipe.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(483, 330);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(189, 42);
            btnStart.TabIndex = 2;
            btnStart.Text = "Démarrer";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(59, 71);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(357, 301);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "Ici on affice la base de donné mais attention pas dans cette text box";
            // 
            // AffichageEquipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(btnStart);
            Controls.Add(btnSupprimerEquipe);
            Controls.Add(btnNouvelleEquipe);
            Name = "AffichageEquipe";
            Text = "AffichageEquipe";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNouvelleEquipe;
        private Button btnSupprimerEquipe;
        private Button btnStart;
        private RichTextBox richTextBox1;
    }
}