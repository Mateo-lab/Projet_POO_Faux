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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnNouveauLieu_Click(object sender, EventArgs e)
        {
            NouveauLieu nouveauLieu = new NouveauLieu();
            nouveauLieu.Show();
        }

        private void btnNouvelleEquipe_Click(object sender, EventArgs e)
        {
            NouvelleEquipe nouvelleEquipe = new NouvelleEquipe();
            nouvelleEquipe.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            LancementRound lancementRound = new LancementRound();
            lancementRound.Show();
        }
    }
}
