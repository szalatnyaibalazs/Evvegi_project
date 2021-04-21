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
    public partial class Csata : Form
    {
        public Csata()
        {
            InitializeComponent();
            CsataMenete();
        }
        public void CsataMenete()
        {
            tbCsata.Text = "Ha egynél több lénnyel kerülnél egyszerre össze-ütközésbe, mindig közöljük veled a harcra vonatkozó utasítást az adott pont alatt. Néha egyszerre kell velük megküzdened, néha meg mindegyikkel külön-külön.";
        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
