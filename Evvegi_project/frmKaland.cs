using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Evvegi_project
{
    public partial class frmKaland : Form
    {
        public frmKaland()
        {
            InitializeComponent();

            tbValasztas.Focus();
            proba();
            Start();
            update();

        }
        List<Oldalak> oldal = new List<Oldalak>();
        static int maxattack;
        static int maxhp;
        static int maxluck;
        public int attack;
        static int hp;
        static int luck;
        static int szerncsevolt = 0;
        int szerencseproba = 0;

        private enum  States {elso,kinyit,t_eszak,nyugat,kelet,kelet_1,vag,maszik,nyugat_1,eszak,kelet_2,nyugat_3,szerencse,nyert,vesztett,csuklora,eszak_1,szigen,belenez,teszak_1,iszik,teszak_2,ivott,nemivott,tovabb,osszegkisebb,osszegnagyobb,tovabb_1};
        private States myState;
        void Statok()
        {
            StreamReader be = new StreamReader("Statok.txt");
            string[] a = be.ReadLine().Split(';');
            Jatekos b = new Jatekos(int.Parse(a[0]),int.Parse(a[1]),int.Parse(a[2]),int.Parse(a[3]),int.Parse(a[4]),int.Parse(a[5]),a[6]);

            maxattack = b.Maxattack;
            maxhp = b.Maxhp;
            maxluck = b.Maxluck;
            attack = b.Attack;
            hp = b.Hp;
            luck = b.Luck;
            
        }
        void Start() 
        {
            myState = States.elso;   
        }
        void elso()
        {
            tbAttack.Text = attack.ToString();
            tbHp.Text = hp.ToString();
            tbLuck.Text = luck.ToString();
            lbValasztasok.Items.Clear();
            lblOldal.Text = oldal[0].Oldal;
            tbTortenet.Text = oldal[0].Szoveg;
            lbValasztasok.Items.Add("Kinyitod a ládát(k)");
            lbValasztasok.Items.Add("Tovább haladsz észak felé(t)");
            if (tbValasztas.Text.ToLower() == "k")
            {
                myState = States.kinyit;
            }
            else if (tbValasztas.Text.ToLower() == "t")
            {
                myState = States.t_eszak;
            }
            tbValasztas.Text = "";
        }
        public void proba()
        {
            StreamReader be = new StreamReader("Kaland.txt");
            while (!be.EndOfStream)
            {
                string[] a = be.ReadLine().Split(';');
                oldal.Add(new Oldalak(a[0], a[1]));
            }
            Console.WriteLine();

        }
        #region Kaland
        string allapot = "";
        void kinyit()
        {
            tbArany.Text = "2";
            lblOldal.Text = oldal[1].Oldal;
            tbTortenet.Text = oldal[1].Szoveg;
            lbValasztasok.Items.Clear();
            lbValasztasok.Items.Add("Tovább észak felé(t)");
            
            if (tbValasztas.Text.ToLower() == "t")
            {
                myState = States.t_eszak;
                allapot = States.t_eszak.ToString();
            }
            tbValasztas.Text = "";
        }
        void t_eszak()
        {
            lblOldal.Text = oldal[2].Oldal;
            tbTortenet.Text = oldal[2].Szoveg;
            lbValasztasok.Items.Clear();
            lbValasztasok.Items.Add("Nyugat(n)");
            lbValasztasok.Items.Add("Kelet(k)");

            if (tbValasztas.Text.ToLower() == "n")
            {
                myState = States.nyugat;
            }
            else if (tbValasztas.Text.ToLower() == "k")
            {
                myState = States.kelet;
            }
            tbValasztas.Text = "";
        }
        public int Dobas()
        {

            Random rnd = new Random();
            int dobas = rnd.Next(1, 7);
            return dobas;
        }
        void nyugat()
        {
            lblOldal.Text = oldal[3].Oldal;
            tbTortenet.Text = oldal[3].Szoveg;
            lbValasztasok.Items.Clear();
            lbValasztasok.Items.Add("Nyugat(n)");
            lbValasztasok.Items.Add("Észak(e)");
            if (tbValasztas.Text.ToLower() == "n")
            {
                myState = States.nyugat_1;
            }
            else if(tbValasztas.Text.ToLower() == "e")
            {
                myState = States.eszak;
            }
            tbValasztas.Text = "";

        }
        int szugyesseg = 7;
        int szhp = 7;
        void eszak()
        {  
                lblOldal.Text = oldal[9].Oldal;
                tbTortenet.Text = oldal[9].Szoveg;
                tbSzelet.Text = szhp.ToString();
                tbSzugyseesge.Text = szugyesseg.ToString();
                lbValasztasok.Items.Clear();
                lbValasztasok.Items.Add("Tedd probára szerencséd(s)");
                btnHarc.Visible = true;
                btnDobas1.Visible = true;
                btnDobas2.Visible = true;
                btnSzerencsproba.Visible = false;
                if (tbValasztas.Text.ToLower() == "s")
                {
                    myState = States.szerencse;
                }
            
        

            tbValasztas.Text = "";
        }
        void szerencse()
        {

            if (szerncsevolt >= 1)
            {
                
                MessageBox.Show("Harconként csak egyszer használhatod a szerencsédet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                tbTortenet.Text = oldal[13].Szoveg;
                lbValasztasok.Items.Clear();
                lbValasztasok.Items.Add("Igen(i)");
                lbValasztasok.Items.Add("Nem(n)");
                if (tbValasztas.Text.ToLower() == "i")
                {
                    myState = States.szigen;
                    szerncsevolt++;
                }
                else if (tbValasztas.Text.ToLower() == "n")
                { myState = States.eszak; }
                tbValasztas.Text = "";
                
            }
            

        }
        void szigen()
        {
            tbTortenet.Text = "Dobj két kockával!";
            btnHarc.Visible = false;
            btnDobas1.Visible = false;
            btnDobas2.Visible = false;
            btnSzerencsproba.Visible = true;

        }

        void nyugat_1()
        {
            lblOldal.Text = oldal[8].Oldal;
            tbTortenet.Text = oldal[8].Szoveg;
            lbValasztasok.Items.Clear();
            lbValasztasok.Items.Add("Megkongatás(m)");
            lbValasztasok.Items.Add("Tovább nyugatnak(n)");
        }
        void kelet()
        {
            lblOldal.Text = oldal[4].Oldal;
            tbTortenet.Text = oldal[4].Szoveg;
            lbValasztasok.Items.Clear();
            lbValasztasok.Items.Add("Kelet(k)");
            lbValasztasok.Items.Add("Nyugat(n)");

            if (tbValasztas.Text.ToLower() == "k")
            {
                myState = States.kelet_1;
            }
            else if (tbValasztas.Text.ToLower() == "n")
            { myState = States.nyugat_3; }
            tbValasztas.Text = "";
        }
        void kelet_1()
        {
            lblOldal.Text = oldal[5].Oldal;
            tbTortenet.Text = oldal[5].Szoveg;
            lbValasztasok.Items.Clear();
            lbValasztasok.Items.Add("Átmászol rajta(a)");
            lbValasztasok.Items.Add("Kettévágod a kardoddal(k)");

            if (tbValasztas.Text.ToLower() == "a")
            {
                myState = States.maszik;
            }
            else if (tbValasztas.Text.ToLower() == "k")
            {
                myState = States.vag;
            }
            tbValasztas.Text = "";

        }
        
        void maszik()
        {
            lblOldal.Text = oldal[6].Oldal;
            tbTortenet.Text = oldal[6].Szoveg;
            lbValasztasok.Items.Clear();
            lbValasztasok.Items.Add("Kelet(k)");
            if (tbValasztas.Text.ToLower() == "k")
            {
                myState = States.kelet_2;
            }
            tbValasztas.Text = "";
        }
        void vag()
        {
            hp -= 2;
            tbHp.Text = hp.ToString();
            lblOldal.Text = oldal[7].Oldal;
            tbTortenet.Text = oldal[7].Szoveg;
            lbValasztasok.Items.Clear();
            lbValasztasok.Items.Add("Kelet(k)");
            if (tbValasztas.Text.ToLower() == "k")
            {
                myState = States.kelet_2;
            }
            
            tbValasztas.Text = "";
        }
        bool ivottell = false;
        void kelet_2()
        {
            lblOldal.Text = oldal[8].Oldal;
            tbTortenet.Text = oldal[8].Szoveg;
            lbValasztasok.Items.Clear();
            lbValasztasok.Items.Add("Megiszod a folyadékot(m)");
            lbValasztasok.Items.Add("Nem kockáztatod meg, hogy igyál a folyadékból, és inkább továbbmész észak felé(t)");
            if (tbValasztas.Text.ToLower() == "m")
            {
                ivottell = true;
                myState = States.iszik;
            }
            else if (tbValasztas.Text.ToLower() == "t")
            { myState = States.teszak_2; }
            
        }
        void teszak_2()
        {
            lblOldal.Text = oldal[16].Oldal;
            tbTortenet.Text = oldal[16].Szoveg;
            lbValasztasok.Items.Clear();
            lbValasztasok.Items.Add("Ha ittál a fogyadékból(i)");
            lbValasztasok.Items.Add("Ha nem ittál a fogyadékból(n)");
            if (tbValasztas.Text.ToLower() == "i")
            {
                myState = States.ivott;
            }
            else if (tbValasztas.Text.ToLower() == "n")
            { myState = States.nemivott; }
        }
        void nemivott()
        {
            lblOldal.Text = oldal[19].Oldal;
            tbTortenet.Text = oldal[19].Szoveg;
            btnKetdobas.Visible = true;
            btnKetdobas.Focus();
        }
        void osszegkisebb()
        {
            lblOldal.Text = oldal[20].Oldal;
            tbTortenet.Text = oldal[20].Szoveg;
            lbValasztasok.Items.Clear();
            lbValasztasok.Items.Add("Tovább(t)");
            if (tbValasztas.Text.ToLower() == "t")
            {
                myState = States.tovabb_1;
            }
        }
        void tovabb_1()
        {
            tbTortenet.Text = "Ez csak egy próba verzió volt. Köszönöm hogy kipróbáltad!";
        }
        void osszegnagyobb()
        {
            lblOldal.Text = oldal[21].Oldal;
            tbTortenet.Text = oldal[21].Szoveg;
            lbValasztasok.Items.Clear();
            lbValasztasok.Items.Add("Újrakezdés(u)");
            lbValasztasok.Items.Add("Kilépés(k)");
            if (tbValasztas.Text.ToLower() == "u")
            {
                myState = States.elso;
            }
            else if (tbValasztas.Text.ToLower() == "k") { this.Close(); }

        }
        void ivott()
        {
            lblOldal.Text = oldal[17].Oldal;
            tbTortenet.Text = oldal[17].Szoveg;
            lbValasztasok.Items.Clear();
            if (ivottell)
            {
                lbValasztasok.Items.Add("Tovább(t)");
            }
            else
            {
                MessageBox.Show("Miért próbáltál meg csalni? Nem szép dolog. Büntetésből elveszíted minden aranyadat!","Információ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                tbArany.Text = "0";
            }
            if (tbValasztas.Text.ToLower() == "t")
            {
                myState = States.tovabb;//oldala[18]
            }
        }
        void iszik()
        {
            lblOldal.Text = oldal[15].Oldal;
            tbTortenet.Text = oldal[15].Szoveg;
            lbValasztasok.Items.Clear();
            lbValasztasok.Items.Add("Tovább észak felé(t)");
            if (tbValasztas.Text.ToLower() == "t")
            {

            }
            tbValasztas.Text = "";
        }
        void nyert()
        {
            tbValasztas.Focus();
            lblOldal.Text = oldal[10].Oldal;
            tbTortenet.Text = oldal[10].Szoveg;
            lbValasztasok.Items.Clear();
            btnDobas1.Visible = false;
            btnDobas2.Visible = false;
            btnHarc.Visible = false;
            pbKocka1.Visible = false;
            pbKocka2.Visible = false;
            lblSzonyelet.Visible = false;
            lblSzornyugyesseg.Visible = false;
            tbSzelet.Visible = false;
            tbSzugyseesge.Visible = false;
            lbValasztasok.Items.Add("Csuklódra teszed(c)");
            lbValasztasok.Items.Add("Tovább haladsz észak felé(t)");
            if (tbValasztas.Text.ToLower() == "c")
            {
                myState = States.csuklora;
            }
            else if (tbValasztas.Text.ToLower() == "t")
            { myState = States.eszak_1; }
            tbValasztas.Text = "";

        }
        void eszak_1()
        {
            lblOldal.Text = oldal[12].Oldal;
            tbTortenet.Text = oldal[12].Szoveg;
            lbValasztasok.Items.Clear();
            lbValasztasok.Items.Add("Belenézel(b)");
            lbValasztasok.Items.Add("Tovább mész észak felé(t)");
            if (tbValasztas.Text.ToLower() =="b")
            {
                myState = States.belenez;
            }
            else if(tbValasztas.Text.ToLower() == "t")
            { myState = States.teszak_1; }
            tbValasztas.Text = "";

        }
        void belenez()
        {
            hp -= 6;
            if (hp<=0)
            {
                tbHp.Text = "0";
                MessageBox.Show("Meghaltál!");
            }
            else
            {
                tbHp.Text = hp.ToString();
            }
            lbValasztasok.Items.Clear();
            tbTortenet.Text = "Ez a játék egy próba verziója volt! Köszönöm hogy kipróbáltad.";
            tbValasztas.Text = "";
        }
        void csuklora()
        {
            lblOldal.Text = oldal[11].Oldal;
            tbTortenet.Text = oldal[11].Szoveg;
            lbValasztasok.Items.Clear();
            lbValasztasok.Items.Add("Tovább észak felé(t)");
            if (tbValasztas.Text.ToLower() == "t")
            {
                myState = States.eszak_1;
                int ugyes = int.Parse(tbAttack.Text);
                ugyes -= 4;
                tbAttack.Text = ugyes.ToString();
            }
            tbValasztas.Text = "";
        }
        void vesztett()
        {
            tbTortenet.Text = "Meghaltál! Elölről akarod kezdeni?";
            lbValasztasok.Items.Clear();
            lbValasztasok.Items.Add("Igen(i)");
            lbValasztasok.Items.Add("Kilépés(k)");
            if (tbValasztas.Text.ToLower() == "i")
            {
                myState = States.elso;
            }
            else if (tbValasztas.Text.ToLower() == "k")
            {
                this.Close();
            }
        }
        void update()
        {
            if (myState == States.elso) { elso(); }
            else if (myState == States.kinyit) { kinyit(); }
            else if (myState == States.t_eszak) { t_eszak(); }
            else if (myState == States.nyugat) { nyugat(); }
            else if (myState == States.kelet) { kelet(); }
            else if (myState == States.maszik) { maszik(); }
            else if (myState == States.vag) { vag(); }
            else if (myState == States.kelet_1) { kelet_1(); }
            else if (myState == States.nyugat_1) { nyugat_1(); }
            else if (myState == States.kelet_2) { kelet_2(); }
            else if (myState == States.eszak) { eszak(); }
            else if (myState == States.nyert) { nyert(); }
            else if (myState == States.csuklora) { csuklora(); }
            else if (myState == States.eszak_1) { eszak_1(); }
            else if (myState == States.vesztett) { vesztett(); }
            else if (myState == States.szerencse) { szerencse(); }
            else if (myState == States.szigen) { szigen(); }
            else if (myState == States.belenez) { belenez(); }
            else if (myState == States.iszik) { iszik(); }
            else if (myState == States.teszak_2) { teszak_2(); }
            else if (myState == States.ivott) { ivott(); }
            else if (myState == States.nemivott) { nemivott(); }
            else if (myState == States.osszegkisebb) { osszegkisebb(); }
            else if (myState == States.osszegnagyobb) { osszegnagyobb(); }
            else if (myState == States.tovabb_1) { tovabb_1(); }
        }
        void up_statok()
        {
            int hpseged = int.Parse(tbHp.Text);
            int lseged = int.Parse(tbLuck.Text);
            tbAttack.Text = attack.ToString();
            tbHp.Text = hpseged.ToString();
            tbLuck.Text = lseged.ToString();
            if (hpseged <= 0)
            {
                MessageBox.Show("Sajnos meghaltál!","Információ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void tbValasztas_TextChanged(object sender, EventArgs e)
        {
            update();
            up_statok();
        }

        private void frmKaland_Load(object sender, EventArgs e)
        {
            Statok();
        }

        private void btnDobas2_Click(object sender, EventArgs e)
        {
            switch (Dobas())
            {
                case 1:
                    pbKocka2.Image = Evvegi_project.Properties.Resources.dice_1;
                    break;
                case 2:
                    pbKocka2.Image = Evvegi_project.Properties.Resources.dice_2;
                    break;
                case 3:
                    pbKocka2.Image = Evvegi_project.Properties.Resources.dice_3;
                    break;
                case 4:
                    pbKocka2.Image = Evvegi_project.Properties.Resources.dice_4;
                    break;
                case 5:
                    pbKocka2.Image = Evvegi_project.Properties.Resources.dice_5;
                    break;
                case 6:
                    pbKocka2.Image = Evvegi_project.Properties.Resources.dice_6;
                    break;
            }
        }

        private void btnDobas1_Click(object sender, EventArgs e)
        {
            switch (Dobas())
            {
                case 1:
                    pbKocka1.Image = Evvegi_project.Properties.Resources.dice_1;
                    break;
                case 2:
                    pbKocka1.Image = Evvegi_project.Properties.Resources.dice_2;
                    break;
                case 3:
                    pbKocka1.Image = Evvegi_project.Properties.Resources.dice_3;
                    break;
                case 4:
                    pbKocka1.Image = Evvegi_project.Properties.Resources.dice_4;
                    break;
                case 5:
                    pbKocka1.Image = Evvegi_project.Properties.Resources.dice_5;
                    break;
                case 6:
                    pbKocka1.Image = Evvegi_project.Properties.Resources.dice_6;
                    break;
            }
        }
        private void btnHarc_Click(object sender, EventArgs e)
        {
            int pa = int.Parse(tbAttack.Text);
            int ma = int.Parse(tbSzugyseesge.Text);
            if (tbAttack.Text != "" || tbSzugyseesge.Text != "")
            {
                if ((pa > attack+2 && pa<=attack+12))
                {
                    if (ma>szugyesseg+2 && ma<=szugyesseg+12)
                    {
                        if (szerencseproba == 0)
                        {
                            Csata(pa, ma);
                        }
                        else if (szerencseproba == 1)
                        {
                            Csata1(pa, ma);
                        }
                        else if (szerencseproba == 2)
                        { csata2(pa, ma); }
                    }
                    else
                    {
                        MessageBox.Show("Túl nagy vagy túl kicsi számot adtál meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbSzugyseesge.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Túl nagy vagy túl kicsi számot adtál meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbAttack.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Nem adtál meg semmit!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }


        }

        private void Csata(int pa, int ma)
        {
            if (pa == ma)
            {
                tbAttack.Text = attack.ToString();
                tbSzugyseesge.Text = szugyesseg.ToString();
                MessageBox.Show("Döntetlen!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (pa < ma)
            {
                MessageBox.Show("A szörny ügyessége nagyobb volt. 2 életet vesztettél.", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int hp = int.Parse(tbHp.Text);
                hp -= 2;
                tbHp.Text = hp.ToString();
                tbAttack.Text = attack.ToString();
                tbSzugyseesge.Text = szugyesseg.ToString();

            }
            else if (pa > ma)
            {
                MessageBox.Show("A szörny ügyessége kissebb volt. 2 életet sebzel rajta.", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                szhp -= 2;
                tbSzelet.Text = szhp.ToString();
                tbAttack.Text = attack.ToString();
                tbSzugyseesge.Text = szugyesseg.ToString();

            }
            if (int.Parse(tbHp.Text) <= 0)
            {
                tbHp.Text = "0";
                MessageBox.Show("Sajnos meghaltál. Előlről kezdheted a kalandot vagy kiléphetsz", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myState = States.vesztett;
                update();
            }
            if (int.Parse(tbSzelet.Text) <= 0)
            {
                tbSzelet.Text = "0";
                MessageBox.Show("Gratulálok nyertél! Tovább haladhatsz.", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myState = States.nyert;
                update();
            }
        }
        private void Csata1(int pa, int ma)
        {
            if (pa == ma)
            {
                tbAttack.Text = attack.ToString();
                tbSzugyseesge.Text = "7";
                MessageBox.Show("Döntetlen!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (pa < ma)
            {
                MessageBox.Show("A szörny ügyessége nagyobb volt. 2 életet vesztettél.", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int hp = int.Parse(tbHp.Text);
                hp -= 2;
                tbHp.Text = hp.ToString();
                tbAttack.Text = attack.ToString();
                tbSzugyseesge.Text = "7";

            }
            else if (pa > ma)
            {
                MessageBox.Show("A szörny ügyessége kissebb volt. 3 életet sebzel rajta.", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                szhp -= 3;
                tbSzelet.Text = szhp.ToString();
                tbAttack.Text = attack.ToString();
                tbSzugyseesge.Text = "7";
                szerencseproba = 0;

            }
            if (int.Parse(tbHp.Text) <= 0)
            {
                tbHp.Text = "0";
                MessageBox.Show("Sajnos meghaltál. Előlről kezdheted a kalandot vagy kiléphetsz", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myState = States.vesztett;
                update();
            }
            if (int.Parse(tbSzelet.Text) <= 0)
            {
                tbSzelet.Text = "0";
                MessageBox.Show("Gratulálok nyertél! Tovább haladhatsz.", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myState = States.nyert;
                update();
            }
        }
        private void csata2(int pa, int ma)
        {
            if (pa == ma)
            {
                tbAttack.Text = attack.ToString();
                tbSzugyseesge.Text = "7";
                MessageBox.Show("Döntetlen!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (pa < ma)
            {
                MessageBox.Show("A szörny ügyessége nagyobb volt. 3 életet vesztettél.", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int hp = int.Parse(tbHp.Text);
                hp -= 3;
                tbHp.Text = hp.ToString();
                tbAttack.Text = attack.ToString();
                tbSzugyseesge.Text = "7";
                szerencseproba = 0;
            }
            else if (pa > ma)
            {
                MessageBox.Show("A szörny ügyessége kissebb volt. 2 életet sebzel rajta.", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
               szhp -= 2;
                tbSzelet.Text = szhp.ToString();
                tbAttack.Text = attack.ToString();
                tbSzugyseesge.Text = "7";

            }
            if (int.Parse(tbHp.Text) <= 0)
            {
                tbHp.Text = "0";
                MessageBox.Show("Sajnos meghaltál. Előlről kezdheted a kalandot vagy kiléphetsz", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myState = States.vesztett;
                update();
            }
            if (int.Parse(tbSzelet.Text) <= 0)
            {
                tbSzelet.Text = "0";
                MessageBox.Show("Gratulálok nyertél! Tovább haladhatsz.", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myState = States.nyert;
                update();
            }
        }
        

        private void tbAttack_TextChanged(object sender, EventArgs e)
        {
            char[] szamok = new char[] {'1','2','3','4','5','6','7','8','9','0' };
            for (int i = 0; i < tbAttack.Text.Length; i++)
            {
                if (!szamok.Contains(tbAttack.Text[i]))
                {
                    MessageBox.Show("Nem számot adtál meg!","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    tbAttack.Text = attack.ToString();
                }
            } 
        }

        private void btnSzerencsproba_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ketdobas = rnd.Next(1,12);
            if (ketdobas <= int.Parse(tbLuck.Text))
            {
                szerencseproba = 1;
                MessageBox.Show("Gratulálok kisebb számot dobtál mit a szerencse pontjaid! A következő támodásod 3 életerőt sebez.");
                myState = States.eszak;
                update();
            }
            else
            {
                szerencseproba = 2;
                MessageBox.Show("Sajnos nagyobb számot dobtál mit a szerencse pontjaid! Veszítesz egy szerencse pontot és a következő találat ellened 3 életerőt sebez.");
                int luck = int.Parse(tbLuck.Text);
                luck -= 1;
                tbLuck.Text = luck.ToString();
                myState = States.eszak;
                update();
            }
        }

        private void btnKetdobas_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dobasok = rnd.Next(1,12);
            if (dobasok < int.Parse(tbAttack.Text))
            {
                myState = States.osszegkisebb;
                update();
            }
            else
            {
                myState = States.osszegnagyobb;
                update();
            }
        }
        #endregion
    }
}
