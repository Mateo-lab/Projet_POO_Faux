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
    public partial class AffichageEquipe : Form
    {
        public AffichageEquipe()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            LancementRound lancementRound = new LancementRound();
            lancementRound.Show();
            this.Close();
        }
    }
}
