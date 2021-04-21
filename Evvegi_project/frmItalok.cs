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
    public partial class frmItalok : Form
    {
        public frmItalok()
        {
            InitializeComponent();
        }
        public string Ital;

        private void btnUgyesseg_Click(object sender, EventArgs e)
        {
            Ital = "ÜGYESSÉG itala";
            this.Close();
        }

        private void btnEro_Click(object sender, EventArgs e)
        {
            Ital = "ERŐ itala";
            this.Close();
        }

        private void btnLuck_Click(object sender, EventArgs e)
        {
            Ital = "SZERENCSE itala";
            this.Close();
        }
    }
}
