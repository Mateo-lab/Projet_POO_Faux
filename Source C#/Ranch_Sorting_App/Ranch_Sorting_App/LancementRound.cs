﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Ranch_Sorting_App
{
    public partial class LancementRound : Form
    {
        private Timer timer;
        int nbrVache;
        private static Stopwatch chrono;
        static DateTime startTime;
        private int numVache;
        //En ajoutant l'annotation ? après le type System.Timers.Timer,
        //vous indiquez au compilateur que le champ Timer peut contenir une instance de System.Timers.Timer ou la valeur null.
        public LancementRound()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }

        private void LancementRound_Load(object sender, EventArgs e)
        {

        }

        private void lblEquipeSuivante_Click(object sender, EventArgs e)
        {

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Appeler la mise à jour du libellé à chaque tick du Timer
            UpdateTimerLabel();

            // Vérifier si le chronomètre doit être arrêté
            if (!chrono.IsRunning)
            {
                timer.Stop(); // Arrêter le timer
                timer.Dispose(); // Disposer le timer
            }
        }
        private void UpdateTimerLabel()
        {
            // Récupération du temps écoulé
            TimeSpan elapsedTime = chrono.Elapsed;

            // Mise à jour du libellé avec le temps écoulé en minutes, secondes et millisecondes
            lblTimer.Invoke(new Action(() =>
            {
                lblTimer.Text = string.Format("{0:00}:{1:00}:{2:000}",
                    elapsedTime.Minutes, elapsedTime.Seconds, elapsedTime.Milliseconds);
            }));

            if (elapsedTime.Seconds == 90)
            {
                chrono.Stop();
                btnValidationResultat.Enabled = true;
            }

        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private void btnGO_Click(object sender, EventArgs e)
        {
            btnBonneVache.Enabled = true;
            btnMauvaiseVache.Enabled = true;
            GestionTimer();
            btnGO.Enabled = false;
            lblNumVache.Text = RandomNumber(0, 9).ToString();
            numVache = int.Parse(lblNumVache.Text);
        }
        private void GestionTimer()
        {
            timer.Start();
            chrono = new Stopwatch();

            // Démarrage du chronomètre
            chrono.Start();
        }


        private void btnEquipeSuivante_Click(object sender, EventArgs e)
        {
            btnEquipeSuivante.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            chrono.Stop();
        }
        private string TempsVache(int numvache)
        {
            string temps = lblTimer.Text;
            return temps;
        }
        private void btnBonneVache_Click(object sender, EventArgs e)
        {

            if (nbrVache == 9)
            {
                chrono.Stop();
                btnBonneVache.Enabled = false;
                btnValidationResultat.Enabled = true;
            }

            richTextBox1.AppendText('\n' + "Vache " + numVache + " : " + TempsVache(numVache));

            if (numVache == 9)
            {
                numVache = 0;
            }
            else
            {
                numVache++;
            }
            nbrVache++;
        }

        private void btnMauvaiseVache_Click(object sender, EventArgs e)
        {
            chrono.Stop();
            richTextBox1.AppendText('\n' + "NULL");
            btnValidationResultat.Enabled = true;
        }

        private void btnValidationResultat_Click(object sender, EventArgs e)
        {
            btnEquipeSuivante.Enabled = true;
        }
        private void LancementRound_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
