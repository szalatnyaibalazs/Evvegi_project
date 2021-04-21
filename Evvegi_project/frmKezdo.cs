using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Evvegi_project
{
    public partial class frmJatek : Form
    {
        public frmJatek()
        {
            InitializeComponent();
            Szoveglistaletrehozasa();
            HatterListaLetrehozasa();
        }
        static List<string> szoveg = new List<string>();
        static List<string> hatter = new List<string>();
        public int maxattack;
        public int maxhp;
        public int maxluck;

        public void Szoveglistaletrehozasa()
        {
            StreamReader be = new StreamReader("pontok.txt");
            while (!be.EndOfStream)
            {
                string[] sor = be.ReadLine().Split(';');
                int index = 0;
                szoveg.Add(sor[index]);
                index++;
            }
            szoveg.Add("");
        }

        private void HatterListaLetrehozasa()
        {
            StreamReader be = new StreamReader("hatter.txt");
            while (!be.EndOfStream)
            {
                string[] a = be.ReadLine().Split(';');
                int i = 0;
                hatter.Add(a[i]);
            }
        }
        int hatterIndex = 0;


        static int szovegindex = 0;
        static bool jo = false;
        public int Dobas()
        {
            
            Random rnd = new Random();
            int dobas = rnd.Next(1, 7);
            return dobas;
        }
        private void btnDobás_Click(object sender, EventArgs e)
        {
            switch (Dobas())
            {
                case 1: pbKocka2.Image = Evvegi_project.Properties.Resources.dice_1;
                    break;
                case 2: pbKocka2.Image = Evvegi_project.Properties.Resources.dice_2;
                    break;
                case 3: pbKocka2.Image = Evvegi_project.Properties.Resources.dice_3;
                    break;
                case 4: pbKocka2.Image = Evvegi_project.Properties.Resources.dice_4;
                    break;
                case 5: pbKocka2.Image = Evvegi_project.Properties.Resources.dice_5;
                    break;
                case 6: pbKocka2.Image = Evvegi_project.Properties.Resources.dice_6;
                    break;
            }
        }

        private void btnSeged_Click(object sender, EventArgs e)
        {
            StreamWriter ki = new StreamWriter("Statok.txt");
            string hibauzenet = "Nem számot adtál meg";
            jo = false;
            if (Jo_e(tbAttack.Text) && Jo_e(tbMaxattack.Text))
            {
                if (szovegindex == 0)
                {
                    if (tbAttack.Text == ""|| tbMaxattack.Text == "")
                    {
                        MessageBox.Show("Nem adtál meg számot", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        
                    if (int.Parse(tbAttack.Text) < 7 || int.Parse(tbMaxattack.Text) > 12 || int.Parse(tbMaxattack.Text) < 7 || int.Parse(tbAttack.Text) > 12)
                    {
                        MessageBox.Show("Túl nagy vagy túl kicsi számot adtál meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                            if (tbAttack.Text == tbMaxattack.Text)
                            {
                                szovegindex++;
                                jo = true;
                            }
                            else
                            {
                                MessageBox.Show("A két szám nem egyezik", "Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }

                            if (jo)
                    {
                                tbStory.Text = szoveg[szovegindex];
                        tbHp.Enabled = true;
                        tbMaxhp.Enabled = true;
                    }
                    }
                    }
                    

                }
                else
                {
                    if (Jo_e(tbHp.Text) && Jo_e(tbMaxhp.Text))
                    {
                        
                        if (szovegindex == 1)
                        {
                            if (tbHp.Text==""||tbMaxhp.Text=="")
                            {
                                MessageBox.Show("Nem adtál meg számot", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                            if (int.Parse(tbHp.Text) > 24 ||
                            int.Parse(tbHp.Text) < 14 ||
                            int.Parse(tbMaxhp.Text) > 24 ||
                            int.Parse(tbMaxhp.Text) < 14)
                            {
                                MessageBox.Show("Túl nagy vagy túl kicsi számot adtál meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                    if (tbHp.Text == tbMaxhp.Text)
                                    {
                                        szovegindex++;
                                        jo = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("A két szám nem egyezik", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                            if (jo)
                            {
                                tbStory.Text = szoveg[szovegindex];
                                tbLuck.Enabled = true;
                                tbMaxluck.Enabled = true;
                            }
                            }
                            }
                        }
                        else
                        {
                            if (Jo_e(tbLuck.Text)&&Jo_e(tbMaxluck.Text))
                            {
                                if (szovegindex == 2)
                                {
                                    if (tbLuck.Text == "" || 
                                        tbMaxhp.Text == "")                                {
                                        MessageBox.Show("Nem adtál meg számot", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        if (int.Parse(tbLuck.Text) < 7 ||
                                            int.Parse(tbLuck.Text) > 12 ||
                                            int.Parse(tbMaxluck.Text) < 7 ||
                                            int.Parse(tbMaxluck.Text)>12)
                                        {
                                            MessageBox.Show("Túl nagy vagy túl kicsi számot adtál meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            if (tbLuck.Text == 
                                                tbMaxluck.Text)
                                            {
                                                szovegindex++;
                                            }
                                            else
                                            {
                                                MessageBox.Show("A két szám nem egyezik", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                }
                                if (szovegindex > 2)
                                {
                                btnSeged.Visible = false;
                                tbStory.Clear();
                                tbMaxattack.ReadOnly = true;
                                tbMaxhp.ReadOnly = true;
                                tbMaxluck.ReadOnly = true;
                                btnHatter.Visible = true;

                                maxattack = int.Parse(tbMaxattack.Text);
                                maxhp = int.Parse(tbMaxhp.Text);
                                maxluck = int.Parse(tbMaxluck.Text);
                                italokformLértehozasa();
                                    ki.WriteLine($"{tbMaxattack.Text};{tbAttack.Text};{tbHp.Text};{tbHp.Text};{tbLuck.Text};{tbMaxluck.Text};{tbItalok.Text}",true);

                                }
                            }
                            else
                            {
                                MessageBox.Show(hibauzenet, "Hiba");
                            }
                            
                        }
                    
                }
                    else
                    {
                        MessageBox.Show(hibauzenet, "Hiba");
                    }
                }
            }
            else
            {
                MessageBox.Show(hibauzenet,"Hiba");
            }
            ki.Close();
        }

        public void italokformLértehozasa()
        {
            frmItalok ital = new frmItalok();
            ital.ShowDialog();

            tbItalok.Text = "- " + ital.Ital;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbAttack.Enabled = true;
            tbMaxattack.Enabled = true;
            tbStory.Text = szoveg[szovegindex];
            btnSeged.Visible = true;
            btnKezdo.Visible = false;
            btnDobas.Visible = true;
            btnDobas2.Visible = true;
            pbKocka1.Visible = true;
            pbKocka2.Visible = true;
            btnDobas.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
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
        private bool Jo_e(string szoveg)
            {
            bool van = true;
                
                char[] szamok = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                for (int i = 0; i < szoveg.Length; i++)
                {
                    if (!szamok.Contains(szoveg[i]))
                    {
                        van = false;
                    }
                }
                
            return van;
        }

        private void btnOpciok_Click(object sender, EventArgs e)
        {
            frmOpciok opcio = new frmOpciok();
            opcio.ShowDialog();
        }

        private void btnHatter_Click(object sender, EventArgs e)
        {
            if (hatterIndex < 8)
            {
                lblHattercimke.Text = "Háttér -"+(hatterIndex+1);
                tbStory.Text = hatter[hatterIndex];
                hatterIndex++;
                if (hatterIndex == 8)
                {
                    pbHatter.Visible = true;
                    btnHatter.Visible = false;
                    btnKezdodik.Visible = true;
                    btnKezdodik.Focus();
                }
            }
            else
            {
                tbStory.Clear();
                lblHattercimke.Visible = false;
            }
           
        }
        private void btnKezdodik_Click(object sender, EventArgs e)
        {
            frmKaland Kaland = new frmKaland();
            Kaland.ShowDialog();
        }
    }
} 
