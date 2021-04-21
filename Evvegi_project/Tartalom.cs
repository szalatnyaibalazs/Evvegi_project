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
    public partial class Tartalom : Form
    {
        public Tartalom()
        {
            InitializeComponent();
            TartalomKiiras();
            btnVissza.Focus();
        }
        public void TartalomKiiras()
        {
            tbTartalom.Text = "A tekervényes labirintus mélyén ismeretlen teremtmények várnak rád. Előtted már évek hosszú során át számtalan harcos próbálkozott keresztüljutni a labirintuson, győzni a Szukumvit báró által meghirdetett Bajnokok Próbáján, azonban eddig még senki sem járt sikerrel. Most rajtad a sor, hogy Szukumvit labirintusában, amelyet a gazdag gonosz fantáziájának teremtményei népesítenek be, és ahol lépten-nyomon csapdákba ütközöl, bebizonyítsd, milyen ügyes, erős, tűrőképes vagy!";
        }

        private void Tartalom_Load(object sender, EventArgs e)
        {

        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
