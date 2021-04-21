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
    public partial class Menekules : Form
    {
        public Menekules()
        {
            InitializeComponent();
            MnekulesKiiras();
        }
        public void MnekulesKiiras()
        {
            tbMenekules.Text = "Bizonyos oldalakon eldöntheted, hogy megfutamodsz-e a csatából, ha a dolgok rosszul alakulnának. Ám ha megfutamodsz, menekülésed közben a teremtmény automatikusan sebet ejt rajtad (ezért 2 ÉLETERŐ pont levonás jár). Ez a gyávaság ára. Ilyenkor is hasznát veheted azonban a SZERENCSÉNEK a szokásos módon (lásd itt). De csak akkor menekülhetsz, ha az adott oldalon erre külön megkapod a lehetőséget.";
        }
        private void btnVissza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
