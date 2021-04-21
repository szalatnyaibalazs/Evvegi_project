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
    public partial class Ismerteto : Form
    {
        public Ismerteto()
        {
            InitializeComponent();
            IsmertetoKiirasa();
        }
        public void IsmertetoKiirasa()
        {
            tbIsmerteto.Text = $"Ennek a történetnek Te vagy a hőse. Te vívsz meg a kocka segítségével óriásokkal és szörnyekkel, magad döntesz, hogy merre haladj tovább, kivel barátkozz, csatázz. Nem pusztán az író fantáziája irányítja a történetet, hanem a te bátorságod, kíváncsiságod, leleményességed, kalandvágyad és józan eszed is. Játék és regény egyszerre, amelyet olvasol. Kalandos vállalkozás, amelybe bele is bukhatsz, de ha jól döntesz, sikerrel jársz. Lovagok, óriások, nindzsák, barbár harcosok, varázslók, szörnyetegek népesítik be ezt a fantasztikus világot.\n Mi kell ahhoz, hogy ne bukj el közöttük? Csak az, ami a mindennapi élethez is: ügyesség, jártasság, ötletesség; az, hogy felkészülten várd a nehézségeket. És szerencse, amely nélkül az előző három talán mit sem ér, de ha csak erre számítasz, biztosan cserbenhagy. Hogy mit jelent az ÜGYESSÉG, ÉLETERŐ és SZERENCSE ebben a történetben, megtudod a következőkből. Ha netán nem lenne teljesen világos a dolog, ne törődj vele. Bátran előre! Vágj neki az olvasásnak, menet közben minden a helyére kerül! De ha elfelejtenél valamit, hogyan kell jól megvívni egy harcot, hogyan menekülhetsz, hogyan gyógyíthatod magad a játék szabályai szerint magad lesz lehetőséged bármikor megnézni.";
        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
