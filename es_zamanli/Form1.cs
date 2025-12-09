using GameTheories.es_zamanli._1vs1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTheories.es_zamanli
{
    public partial class Form1 : Form
    {  /*Kopyacı 
Ponçik
Sinsi 
Hain Hafıza
Şanslı 
Affeden Ayna
Sömürücü 
Grupçu
İntikamcı
Fırsatçı
Herolar*/
        public int i = 0; public int k = 0;
        public string[] herolar = { "Siz", "Kopyaci", "Poncik", "Sinsi", "Hain Hafiza", "Sansli", "Affeden Ayna", "Somurucu", "Grupcu", "Intikamcı", "Firsatcı" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Uygulamanın çalışmasını sonlandırır.
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            if (i < 10)
            {
                i++;
                hero1LBL.Text = herolar[i];

                switch (i)
                {

                    case 1:
                        hero1P.Image = Image.FromFile(@"resimler\herolar\kopyaci.png");
                        if (hero2LBL.Text != "Siz")
                        {
                            macizle.Enabled = true;
                            sonucGit.Enabled = true;
                        }
                        break;
                    case 2:
                        hero1P.Image = Image.FromFile(@"resimler\herolar\poncik.png");
                        break;
                    case 3:
                        hero1P.Image = Image.FromFile(@"resimler\herolar\Sinsi.png");
                        break;
                    case 4:
                        hero1P.Image = Image.FromFile(@"resimler\herolar\hain_hafiza.png");
                        break;
                    case 5:
                        hero1P.Image = Image.FromFile(@"resimler\herolar\sansli_cimbom.png");
                        break;
                    case 6:
                        hero1P.Image = Image.FromFile(@"resimler\herolar\affetmez_ayna.png");
                        break;
                    case 7:
                        hero1P.Image = Image.FromFile(@"resimler\herolar\sömürücü.png");
                        break;
                    case 8:
                        hero1P.Image = Image.FromFile(@"resimler\herolar\grupcu.png");
                        break;
                    case 9:
                        hero1P.Image = Image.FromFile(@"resimler\herolar\intikamcı.png");
                        break;
                    case 10:
                        hero1P.Image = Image.FromFile(@"resimler\herolar\fırsatçı.png");
                        break;
                }
            }

            else if (i == 10)
            {
                i = 0;
                hero1LBL.Text = herolar[i];
                hero1P.Image = null;
                macizle.Enabled = false;
                sonucGit.Enabled = false;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            if (i > 0)
            {
                i--;
                hero1LBL.Text = herolar[i];
                switch (i)
                {
                    case 0:
                        hero1P.Image = null;
                        macizle.Enabled = false;
                        sonucGit.Enabled = false;
                        break;
                    case 1:
                        hero1P.Image = Image.FromFile(@"resimler\herolar\kopyaci.png");

                        break;
                    case 2:
                        hero1P.Image = Image.FromFile(@"resimler\herolar\poncik.png");
                        break;
                    case 3:
                        hero1P.Image = Image.FromFile(@"resimler\herolar\Sinsi.png");
                        break;
                    case 4:
                        hero1P.Image = Image.FromFile(@"resimler\herolar\hain_hafiza.png");
                        break;
                    case 5:
                        hero1P.Image = Image.FromFile(@"resimler\herolar\sansli_cimbom.png");
                        break;
                    case 6:
                        hero1P.Image = Image.FromFile(@"resimler\herolar\affetmez_ayna.png");
                        break;
                    case 7:
                        hero1P.Image = Image.FromFile(@"resimler\herolar\sömürücü.png");
                        break;
                    case 8:
                        hero1P.Image = Image.FromFile(@"resimler\herolar\grupcu.png");
                        break;
                    case 9:
                        hero1P.Image = Image.FromFile(@"resimler\herolar\intikamcı.png");
                        break;

                }
            }
            else if (i == 0)
            {
                i = 10;
                hero1LBL.Text = herolar[i];
                hero1P.Image = Image.FromFile(@"resimler\herolar\fırsatçı.png");
                if (hero2LBL.Text != "Siz")
                {
                    macizle.Enabled = true;
                    sonucGit.Enabled = true;
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            if (k > 0)
            {
                k--;
                hero2LBL.Text = herolar[k];
                switch (k)
                {
                    case 0:
                        hero2P.Image = null;
                        macizle.Enabled = false;
                        sonucGit.Enabled = false;
                        break;
                    case 1:
                        hero2P.Image = Image.FromFile(@"resimler\herolar\kopyaci.png");
                        break;
                    case 2:
                        hero2P.Image = Image.FromFile(@"resimler\herolar\poncik.png");
                        break;
                    case 3:
                        hero2P.Image = Image.FromFile(@"resimler\herolar\Sinsi.png");
                        break;
                    case 4:
                        hero2P.Image = Image.FromFile(@"resimler\herolar\hain_hafiza.png");
                        break;
                    case 5:
                        hero2P.Image = Image.FromFile(@"resimler\herolar\sansli_cimbom.png");
                        break;
                    case 6:
                        hero2P.Image = Image.FromFile(@"resimler\herolar\affetmez_ayna.png");
                        break;
                    case 7:
                        hero2P.Image = Image.FromFile(@"resimler\herolar\sömürücü.png");
                        break;
                    case 8:
                        hero2P.Image = Image.FromFile(@"resimler\herolar\grupcu.png");
                        break;
                    case 9:
                        hero2P.Image = Image.FromFile(@"resimler\herolar\intikamcı.png");
                        break;

                }
            }
            else if (k == 0)
            {
                k = 10;
                hero2LBL.Text = herolar[k];
                hero2P.Image = Image.FromFile(@"resimler\herolar\fırsatçı.png");
                if (hero1LBL.Text != "Siz")
                {
                    macizle.Enabled = true;
                    sonucGit.Enabled = true;
                }

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            if (k < 10)
            {
                k++;
                hero2LBL.Text = herolar[k];
                switch (k)
                {

                    case 1:
                        hero2P.Image = Image.FromFile(@"resimler\herolar\kopyaci.png");
                        if (hero1LBL.Text != "Siz")
                        {
                            macizle.Enabled = true;
                            sonucGit.Enabled = true;
                        }
                        break;
                    case 2:
                        hero2P.Image = Image.FromFile(@"resimler\herolar\poncik.png");
                        break;
                    case 3:
                        hero2P.Image = Image.FromFile(@"resimler\herolar\Sinsi.png");
                        break;
                    case 4:
                        hero2P.Image = Image.FromFile(@"resimler\herolar\hain_hafiza.png");
                        break;
                    case 5:
                        hero2P.Image = Image.FromFile(@"resimler\herolar\sansli_cimbom.png");
                        break;
                    case 6:
                        hero2P.Image = Image.FromFile(@"resimler\herolar\affetmez_ayna.png");
                        break;
                    case 7:
                        hero2P.Image = Image.FromFile(@"resimler\herolar\sömürücü.png");
                        break;
                    case 8:
                        hero2P.Image = Image.FromFile(@"resimler\herolar\grupcu.png");
                        break;
                    case 9:
                        hero2P.Image = Image.FromFile(@"resimler\herolar\intikamcı.png");
                        break;
                    case 10:
                        hero2P.Image = Image.FromFile(@"resimler\herolar\fırsatçı.png");
                        break;
                }
            }

            else if (k == 10)
            {
                k = 0;
                hero2LBL.Text = herolar[k];
                hero2P.Image = null;
                macizle.Enabled = false;
                sonucGit.Enabled = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string hero1lbl = hero1LBL.Text; 
            string hero2lbl = hero2LBL.Text; 
            if (hero1LBL.Text == "Siz" && hero2LBL.Text == "Siz")
            {
                label3.Text = "iki hero da siz olamazsiniz";
                label3.Visible = true;
            }

            if (macizle.Enabled == true)
            {
                macIzle mac1 = new macIzle(hero1lbl, hero2lbl);
                mac1.Show();
                this.Hide();
            }
            else if (sonucGit.Enabled == true)
            {
                sonucaGec sonucmac1 = new sonucaGec(hero1lbl, hero2lbl);
                sonucmac1.Show();
                this.Hide();
            }

            if (hero1LBL.Text == "Siz" && hero2LBL.Text != "Siz" || hero2LBL.Text == "Siz" && hero1LBL.Text != "Siz")
            {
                sizVs sizmac1 = new sizVs(hero1lbl, hero2lbl);
                sizmac1.Show();
                this.Hide();
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int oyunSayisi = (int)numericUpDown1.Value;
        }

       
    }
}
