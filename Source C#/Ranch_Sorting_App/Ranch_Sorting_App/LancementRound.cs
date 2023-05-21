using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ranch_Sorting_App
{
    public partial class LancementRound : Form
    {

        int m, s, cs, nbrVache;

        private int numVache;
        System.Timers.Timer? Timer;
        //En ajoutant l'annotation ? après le type System.Timers.Timer,
        //vous indiquez au compilateur que le champ Timer peut contenir une instance de System.Timers.Timer ou la valeur null.
        public LancementRound()
        {
            InitializeComponent();
        }



        private void LancementRound_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEquipeSuivante_Click(object sender, EventArgs e)
        {

        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            cs++;
            if (cs == 100)
            {
                s++;
                cs = 0;
            }
            if (s == 60)
            {
                m++;
                s = 0;
            }
            if (m == 1)
            {
                Timer.Stop();
                this.Close();
            }

            this.Invoke(new Action(() =>
            {
                lblTimer.Text = string.Format("{0}:{1}:{2}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'), cs.ToString().PadLeft(2, '0'));
            }));


        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private void btnGO_Click(object sender, EventArgs e)
        {
            GestionTimer();
            btnGO.Enabled = false;
            lblNumVache.Text = RandomNumber(0, 9).ToString();
            numVache = int.Parse(lblNumVache.Text);
        }
        private void GestionTimer()
        {
            m = 0;
            s = 0;
            cs = 0;
            Timer = new System.Timers.Timer();
            Timer.Interval = 10;
            Timer.Elapsed += Timer_Elapsed;
            Timer.Start();
        }
      

        private void btnEquipeSuivante_Click(object sender, EventArgs e)
        {
            btnEquipeSuivante.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Timer.Stop();
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
                Timer.Stop();
                btnBonneVache.Enabled = false;
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
            Timer.Stop();   
        }
    }
}
