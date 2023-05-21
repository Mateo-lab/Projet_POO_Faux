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
        public LancementRound()
        {
            InitializeComponent();
        }

        System.Timers.Timer Timer;
        int m, s, cs;
        private void LancementRound_Load(object sender, EventArgs e)
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEquipeSuivante_Click(object sender, EventArgs e)
        {

        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            m = 0;
            s = 0;
            cs = 0;
            Timer = new System.Timers.Timer();
            Timer.Interval = 10;
            Timer.Elapsed += Timer_Elapsed;
            Timer.Start();
        }
    }
}
