namespace Ranch_Sorting_App
{
    partial class LancementRound
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
            lblEquipeEnCours = new Label();
            btnGO = new Button();
            lblEquipeSuivante = new Label();
            lblAffichageEquipeSuivante = new Label();
            lblAffichageEquipeEnCours = new Label();
            btnBonneVache = new Button();
            btnMauvaiseVache = new Button();
            btnEquipeSuivante = new Button();
            lblTimer = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // lblEquipeEnCours
            // 
            lblEquipeEnCours.AutoSize = true;
            lblEquipeEnCours.Location = new Point(78, 31);
            lblEquipeEnCours.Name = "lblEquipeEnCours";
            lblEquipeEnCours.Size = new Size(97, 15);
            lblEquipeEnCours.TabIndex = 0;
            lblEquipeEnCours.Text = "Equipe en cours :";
            lblEquipeEnCours.Click += label1_Click;
            // 
            // btnGO
            // 
            btnGO.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnGO.Location = new Point(762, 130);
            btnGO.Name = "btnGO";
            btnGO.Size = new Size(116, 54);
            btnGO.TabIndex = 1;
            btnGO.Text = "GO";
            btnGO.UseVisualStyleBackColor = true;
            btnGO.Click += btnGO_Click;
            // 
            // lblEquipeSuivante
            // 
            lblEquipeSuivante.AutoSize = true;
            lblEquipeSuivante.Location = new Point(415, 31);
            lblEquipeSuivante.Name = "lblEquipeSuivante";
            lblEquipeSuivante.Size = new Size(97, 15);
            lblEquipeSuivante.TabIndex = 2;
            lblEquipeSuivante.Text = "Equipe Suivante :";
            lblEquipeSuivante.Click += lblEquipeSuivante_Click;
            // 
            // lblAffichageEquipeSuivante
            // 
            lblAffichageEquipeSuivante.AutoSize = true;
            lblAffichageEquipeSuivante.BorderStyle = BorderStyle.Fixed3D;
            lblAffichageEquipeSuivante.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblAffichageEquipeSuivante.Location = new Point(404, 70);
            lblAffichageEquipeSuivante.Name = "lblAffichageEquipeSuivante";
            lblAffichageEquipeSuivante.Size = new Size(121, 22);
            lblAffichageEquipeSuivante.TabIndex = 3;
            lblAffichageEquipeSuivante.Text = "Equipe Suivante";
            // 
            // lblAffichageEquipeEnCours
            // 
            lblAffichageEquipeEnCours.AutoSize = true;
            lblAffichageEquipeEnCours.BorderStyle = BorderStyle.Fixed3D;
            lblAffichageEquipeEnCours.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAffichageEquipeEnCours.Location = new Point(67, 70);
            lblAffichageEquipeEnCours.Name = "lblAffichageEquipeEnCours";
            lblAffichageEquipeEnCours.Size = new Size(120, 22);
            lblAffichageEquipeEnCours.TabIndex = 4;
            lblAffichageEquipeEnCours.Text = "Equipe en cours";
            // 
            // btnBonneVache
            // 
            btnBonneVache.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBonneVache.Location = new Point(586, 211);
            btnBonneVache.Name = "btnBonneVache";
            btnBonneVache.Size = new Size(292, 35);
            btnBonneVache.TabIndex = 5;
            btnBonneVache.TabStop = false;
            btnBonneVache.Text = "Bonne Vache";
            btnBonneVache.UseVisualStyleBackColor = true;
            // 
            // btnMauvaiseVache
            // 
            btnMauvaiseVache.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMauvaiseVache.Location = new Point(586, 269);
            btnMauvaiseVache.Name = "btnMauvaiseVache";
            btnMauvaiseVache.Size = new Size(292, 32);
            btnMauvaiseVache.TabIndex = 6;
            btnMauvaiseVache.Text = "Mauvaise vache";
            btnMauvaiseVache.UseVisualStyleBackColor = true;
            // 
            // btnEquipeSuivante
            // 
            btnEquipeSuivante.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquipeSuivante.Location = new Point(586, 372);
            btnEquipeSuivante.Name = "btnEquipeSuivante";
            btnEquipeSuivante.Size = new Size(292, 32);
            btnEquipeSuivante.TabIndex = 7;
            btnEquipeSuivante.Text = "Equipe suivante";
            btnEquipeSuivante.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            lblTimer.Location = new Point(712, 54);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(91, 15);
            lblTimer.TabIndex = 8;
            lblTimer.Text = "lblTimer";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(78, 130);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(357, 301);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "Ici on affice la base de donné mais attention pas dans cette text box";
            // 
            // LancementRound
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 474);
            Controls.Add(richTextBox1);
            Controls.Add(lblTimer);
            Controls.Add(btnEquipeSuivante);
            Controls.Add(btnMauvaiseVache);
            Controls.Add(btnBonneVache);
            Controls.Add(lblAffichageEquipeEnCours);
            Controls.Add(lblAffichageEquipeSuivante);
            Controls.Add(lblEquipeSuivante);
            Controls.Add(btnGO);
            Controls.Add(lblEquipeEnCours);
            Name = "LancementRound";
            Text = "LancementRound";
            Load += LancementRound_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEquipeEnCours;
        private Button btnGO;
        private Label lblEquipeSuivante;
        private Label lblAffichageEquipeSuivante;
        private Label lblAffichageEquipeEnCours;
        private Button btnBonneVache;
        private Button btnMauvaiseVache;
        private Button btnEquipeSuivante;
        private Label lblTimer;
        private RichTextBox richTextBox1;
    }
}