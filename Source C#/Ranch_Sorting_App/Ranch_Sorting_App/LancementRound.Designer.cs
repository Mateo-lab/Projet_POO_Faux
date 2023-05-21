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
            lblNumVache = new Label();
            btnValidationResultat = new Button();
            lblAnnoncePremiereVache = new Label();
            btnStop = new Button();
            SuspendLayout();
            // 
            // lblEquipeEnCours
            // 
            lblEquipeEnCours.AutoSize = true;
            lblEquipeEnCours.Location = new Point(36, 21);
            lblEquipeEnCours.Name = "lblEquipeEnCours";
            lblEquipeEnCours.Size = new Size(97, 15);
            lblEquipeEnCours.TabIndex = 0;
            lblEquipeEnCours.Text = "Equipe en cours :";
            lblEquipeEnCours.Click += label1_Click;
            // 
            // btnGO
            // 
            btnGO.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnGO.Location = new Point(632, 228);
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
            lblEquipeSuivante.Location = new Point(325, 21);
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
            lblAffichageEquipeSuivante.Location = new Point(314, 70);
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
            lblAffichageEquipeEnCours.Location = new Point(27, 70);
            lblAffichageEquipeEnCours.Name = "lblAffichageEquipeEnCours";
            lblAffichageEquipeEnCours.Size = new Size(120, 22);
            lblAffichageEquipeEnCours.TabIndex = 4;
            lblAffichageEquipeEnCours.Text = "Equipe en cours";
            // 
            // btnBonneVache
            // 
            btnBonneVache.AutoSize = true;
            btnBonneVache.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBonneVache.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBonneVache.Location = new Point(502, 332);
            btnBonneVache.Name = "btnBonneVache";
            btnBonneVache.Size = new Size(119, 31);
            btnBonneVache.TabIndex = 5;
            btnBonneVache.TabStop = false;
            btnBonneVache.Text = "Bonne Vache";
            btnBonneVache.UseVisualStyleBackColor = true;
            btnBonneVache.Click += btnBonneVache_Click;
            // 
            // btnMauvaiseVache
            // 
            btnMauvaiseVache.AutoSize = true;
            btnMauvaiseVache.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMauvaiseVache.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMauvaiseVache.Location = new Point(755, 332);
            btnMauvaiseVache.Name = "btnMauvaiseVache";
            btnMauvaiseVache.Size = new Size(142, 31);
            btnMauvaiseVache.TabIndex = 6;
            btnMauvaiseVache.Text = "Mauvaise vache";
            btnMauvaiseVache.UseVisualStyleBackColor = true;
            btnMauvaiseVache.Click += btnMauvaiseVache_Click;
            // 
            // btnEquipeSuivante
            // 
            btnEquipeSuivante.AutoSize = true;
            btnEquipeSuivante.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEquipeSuivante.Enabled = false;
            btnEquipeSuivante.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquipeSuivante.Location = new Point(755, 412);
            btnEquipeSuivante.Name = "btnEquipeSuivante";
            btnEquipeSuivante.Size = new Size(142, 31);
            btnEquipeSuivante.TabIndex = 7;
            btnEquipeSuivante.Text = "Equipe suivante";
            btnEquipeSuivante.UseVisualStyleBackColor = true;
            btnEquipeSuivante.Click += btnEquipeSuivante_Click;
            // 
            // lblTimer
            // 
            lblTimer.BorderStyle = BorderStyle.FixedSingle;
            lblTimer.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimer.Location = new Point(563, 21);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(263, 95);
            lblTimer.TabIndex = 8;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(27, 110);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(408, 333);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "Ici on affice la base de donné mais attention pas dans cette text box.";
            // 
            // lblNumVache
            // 
            lblNumVache.AutoSize = true;
            lblNumVache.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumVache.Location = new Point(708, 148);
            lblNumVache.Name = "lblNumVache";
            lblNumVache.Size = new Size(204, 32);
            lblNumVache.TabIndex = 10;
            lblNumVache.Text = "*Random vache*";
            // 
            // btnValidationResultat
            // 
            btnValidationResultat.AutoSize = true;
            btnValidationResultat.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnValidationResultat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnValidationResultat.Location = new Point(478, 411);
            btnValidationResultat.Name = "btnValidationResultat";
            btnValidationResultat.Size = new Size(168, 31);
            btnValidationResultat.TabIndex = 11;
            btnValidationResultat.Text = "Valider les résultats";
            btnValidationResultat.UseVisualStyleBackColor = true;
            // 
            // lblAnnoncePremiereVache
            // 
            lblAnnoncePremiereVache.AutoSize = true;
            lblAnnoncePremiereVache.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnnoncePremiereVache.Location = new Point(468, 148);
            lblAnnoncePremiereVache.Name = "lblAnnoncePremiereVache";
            lblAnnoncePremiereVache.Size = new Size(191, 32);
            lblAnnoncePremiereVache.TabIndex = 12;
            lblAnnoncePremiereVache.Text = "Vache numero :";
            // 
            // btnStop
            // 
            btnStop.AutoSize = true;
            btnStop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStop.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnStop.Location = new Point(824, 247);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(54, 29);
            btnStop.TabIndex = 13;
            btnStop.Text = "STOP";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += button1_Click_1;
            // 
            // LancementRound
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 465);
            Controls.Add(btnStop);
            Controls.Add(lblAnnoncePremiereVache);
            Controls.Add(btnValidationResultat);
            Controls.Add(lblNumVache);
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
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LancementRound";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label lblNumVache;
        private Button btnValidationResultat;
        private Label lblAnnoncePremiereVache;
        private Button btnStop;
    }
}