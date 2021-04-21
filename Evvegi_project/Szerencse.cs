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
    public partial class Szerencse : Form
    {
        public Szerencse()
        {
            InitializeComponent();
            Szerencsemagyarazat();
            Probaszerencse();
        }
        public void Szerencsemagyarazat()
        {
            tbSzerencse.Text = "Kalandjaid során, akár csatában, akár olyan helyzetekben, amikor a SZERENCSE dönthet sorsod alakulásában (az erre vonatkozó utasítást az adott oldalakon megtalálod), a SZERENCSÉDRE is számíthatsz, hogy az események kimenetele számodra kedvező legyen. De vigyázz! A SZERENCSÉRE számítani kockázatos, és ha balszerencsés vagy, az eredmény végzetes lehet. ";
        }
        public void Probaszerencse()
        {
            tbProba.Text = "Dobj két kockával. Ha a kapott szám ugyanannyi vagy nem nagyobb, mint a jelenlegi SZERENCSE pontszámod, akkor szerencséd volt! Ha magasabb számot dobsz, mint a jelenlegi SZERENCSE pontszámod, balszerencséd volt, és vállald következményeit. Ezt hívjuk úgy, hogy Tedd próbára SZERENCSÉD. Minden alkalommal, amikor próbára teszed SZERENCSÉDET, 1 pontot le kell vonnod SZERENCSE pontjaidból. Így hamar rájössz, hogy a SZERENCSÉRE hagyatkozni kockázatos vállalkozás!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
