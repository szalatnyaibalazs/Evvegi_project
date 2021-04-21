using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evvegi_project
{
    public partial class frmOpciok : Form
    {
        public frmOpciok()
        {
            InitializeComponent();
        }

        private void btnTartalom_Click(object sender, EventArgs e)
        {
            Tartalom tartalom = new Tartalom();
            tartalom.ShowDialog();
        }

        private void btnIsmerteto_Click(object sender, EventArgs e)
        {
            Ismerteto ismerteto = new Ismerteto();
            ismerteto.ShowDialog();
        }

        private void btnHarc_Click(object sender, EventArgs e)
        {
            Harc harc = new Harc();
            harc.ShowDialog();
        }

        private void btnMenekules_Click(object sender, EventArgs e)
        {
            Menekules menekules = new Menekules();
            menekules.ShowDialog();
        }

        private void btnCsata_Click(object sender, EventArgs e)
        {
            Csata csata = new Csata();
            csata.ShowDialog();
        }

        private void btnSzerencse_Click(object sender, EventArgs e)
        {
            Szerencse szerencse = new Szerencse();
            szerencse.ShowDialog();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
