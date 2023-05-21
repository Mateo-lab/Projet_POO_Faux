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
    public partial class NouvelleEpreuve : Form
    {
        public NouvelleEpreuve()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValiderEpreuve_Click(object sender, EventArgs e)
        {
            AffichageEquipe affichageEquipe = new AffichageEquipe();
            affichageEquipe.Show();
            this.Hide();
        }

        private void btnNouveauLieu_Click(object sender, EventArgs e)
        {
            NouveauLieu nouveauLieu = new NouveauLieu();
            nouveauLieu.Show();
            this.Hide();
        }
    }
}
