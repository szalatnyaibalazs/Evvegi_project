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
    public partial class Harc : Form
    {
        public Harc()
        {
            InitializeComponent();
            HarcMenete();
        }
        public void HarcMenete()
        {
            tbHarcmenete.Text = "Sűrűn találsz majd olyan oldalakat, ahol azt az utasítást kapod, hogy küzdjél meg valamilyen teremtménnyel. Lehet, hogy lesz választási lehetőséged, de ha nem, vagy ha úgy döntesz, hogy vállalod a harcot, azt a következő módon kell megvívnod: Először is jegyezd fel a teremtmény ÜGYESSÉGÉT a Kalandlapod Harcok a Szörnyekkel rovatának barna négyzetébe, majd a teremtmény ÉLETERŐ pontjait a mellette lévő fekete keretbe! A teremtmények pontszámait minden alkalommal megadja a könyv, amikor összecsapsz valamelyikükkel.";
            lbFelsorolas.Items.Add("1. Dobj két kockával a teremtmény nevében. A kapott számot add az ő ÜGYESSÉG pontjaihoz. Az összeg az ő TÁMADÓEREJE.");
            lbFelsorolas.Items.Add("2. Dobj két kockával most magadnak, és az eredményt add saját jelenlegi ÜGYESSÉG pontjaidhoz. Ez a te TÁMADÓERŐD.");
            lbFelsorolas.Items.Add($"3. Ha a te TÁMADÓERŐD nagyobb, mint a teremtményé, akivel küzdesz, megsebezted. Menj tovább a 4. lépésre. Ha a teremtmény TÁMADÓEREJE");
            lbFelsorolas.Items.Add("nagyobb, ő sebzett meg téged, és haladj az 5. lépéshez. Ha a két TÁMADÓERŐ egyforma, kivédtétek egymás csapását, és a következő Fordulót");
            lbFelsorolas.Items.Add("az 1. lépéstől elölről kezditek.");
            lbFelsorolas.Items.Add("4. Megsebezted a teremtményt, ezért vonj le 2 pontot ÉLETEREJÉBŐL. Felhasználhatod SZERENCSÉDET is, hogy további sebeket ejts rajta (lásd ");
            lbFelsorolas.Items.Add("odébb).");
            lbFelsorolas.Items.Add("5. A teremtmény sebzett meg téged, ezért vonj le 2 pontot saját ÉLETERŐDBŐL. De ilyenkor is lehet SZERENCSÉD (lásd odébb).");
            lbFelsorolas.Items.Add("6. Ellenőrizd a teremtmény vagy a saját ÉLET-ERŐ pontjaidat, és a SZERENCSE pontokat is, ha kell.");
            lbFelsorolas.Items.Add("7. Kezdd el a következő Fordulót meglévő ÜGYESSÉG pontjaiddal, azaz ismételd meg a lépéseket 1-6-ig. Ezt mindaddig megteheted, amíg vagy a te,");
            lbFelsorolas.Items.Add("vagy a teremtmény ÉLETERŐ pontjai nem fogynak el (halál).");
            
        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
