using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTheories.es_zamanli._1vs1
{
    public partial class sonucaGec : Form
    {
        string met1;
        string met2;
        int oyunsayısı;
        int oynananOyun = 0;
        bool hero1;
        bool hero2;
        bool hero1Gecmis;
        bool hero2Gecmis;
        bool hafiza1;
        bool hafiza2;
        int sonuc1;
        int sonuc2;
        List<bool> genel = new List<bool>();



        //------------------hero algoritma ------------------------------------------------------------------------------------
        //kopyaci için bir önceki hamle tutuluyo 

        //cimbom için %50 random ihtimali var 

        //hain hafıza için if == hero2Gecmis == false ise full false yaptırırız 

        //affeden ayna %20 ihanet affeder 

        //sömürücü false ile baslar diğer el rakip false yaparsa kopyacı olur ve böyle devam eder true yaparsa rakip false yapana kadar false yapar false yapınca kopyacı olur
        //yani önceki hamle false olana kadar false sonra kopyacı 

        //grupcu için liste koyduk her maç listeye eleman eklicez 


        //şimdi amacımız gelen metne göre heroların fonksiyonlarını yerine getircez ve ikisi aynı anda iş yapcak sonra tekrar 
        //bunun için bir while oluşturcaz hero1 ve 2 hareketini yapacak sonra while bitcek oyun sayısı kadar tekrar etcek 
        //her while döndüğünde 
        //oyundaki genel oy kullanılcak 
        //heroların hamleleri kaydedilcek 

        ///////////////////////hero geçmişleri oyun sırasında while döngüsü ile eklenmeli ikisi de hareket ettikten sonra /////////////////////////////
        public sonucaGec(string metin1, string metin2, int oyunsayisi)
        {
            InitializeComponent();
            met1 = metin1;
            met2 = metin2;
            oyunsayısı = oyunsayisi;
            //veriyi çektik form1 deki seçimlere göre heroları kullancaz burda  


        }


        public void Kopyaci1()   //ilk hamle true diğerleri rakibin önceki hamlesi 
        {
            if (oynananOyun == 0)
            {
                hero1 = true;
                genel.Add(true);
            }
            else
            {
                hero1 = hero2Gecmis;
                genel.Add(hero2Gecmis);
            }
        }

        public void poncik1()   //hep true 
        {
            hero1 = true;
            genel.Add(true);
        }

        public void sinsi1()  //hep false 
        {
            hero1 = false;
            genel.Add(false);
        }

        public void hainHafiza1()  //ilk hamle true, rakip false yapana kadar true sonra full false 
        {
            if (oynananOyun == 0)
            {
                hero1 = true;
                genel.Add(true);
            }
            else
            {
                if (hafiza1 == true && hero2Gecmis == true)
                {
                    hero1 = true;
                    genel.Add(true);
                }
                else if (hafiza1 == true && hero2Gecmis == false)
                {
                    hafiza1 = false;
                    hero1 = false;
                    genel.Add(false);
                }
                else if (hafiza1 == false)
                {
                    hero1 = false;
                    genel.Add(false);
                }
            }
        }

        public void sansliCimbom1() // random sayi oluşturur 1 ise true 0 ise false atar 
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(2);
            if (randomNumber == 0)
            {
                hero1 = false;
                genel.Add(false);
            }
            else if (randomNumber == 1)
            {
                hero1 = true;
                genel.Add(true);
            }
        }

        public void affedenAyna1() //affeden ayna 20 ihtimalle false true yapar 
        {
            if (oynananOyun == 0)
            {
                hero1 = true;
                genel.Add(true);
            }
            else
            {
                if (hero2Gecmis == true)
                {
                    hero1 = true;
                    genel.Add(true);
                }
                else if (hero2Gecmis == false)
                {
                    Random rnd = new Random();
                    int randomNmb = rnd.Next(5);
                    if (randomNmb == 0)
                    {
                        hero1 = true;
                        genel.Add(true);
                    }
                    else
                    {
                        hero1 = hero2Gecmis;
                        genel.Add(hero2Gecmis);
                    }
                }
            }
        }


        public void somurucu1() // sömürücü ilk iki el false sonra rakip false yaparsa kopyacı yapmazsa false devam 
        {
            if (oyunsayısı == 0)
            {
                hero1 = false;
                genel.Add(false);
            }
            else if (oyunsayısı == 1)
            {
                hero1 = false;
                genel.Add(false);
            }
            else
            {
                if (hafiza1 == true && hero2Gecmis == true)
                {
                    hero1 = false;
                    genel.Add(false);
                }
                else if (hafiza1 == true && hero2Gecmis == false)
                {
                    hero1 = false;
                    hafiza1 = false;
                    genel.Add(false);
                }
                else if (hafiza1 == false)
                {
                    hero1 = hero2Gecmis;
                    genel.Add(false);
                }
            }
        }

        public void grupcu1() //oynanan ele göre true veya false yapar 
        {
            if (oynananOyun == 0)
            {
                hero1 = true;
                genel.Add(true);
            }
            else
            {
                int trues = 0;
                int falses = 0;
                foreach (bool deger in genel)
                {
                    // Eğer eleman true ise
                    if (deger == true)
                    {
                        trues++;
                    }
                    // Eğer eleman false ise
                    else // (deger == false)
                    {
                        falses++;
                    }
                }

                if (trues >= falses)
                {
                    hero1 = true;
                    genel.Add(true);
                }
                else
                {
                    hero1 = false;
                    genel.Add(false);
                }
            }

        }

        //ilk el true sonra önceki el kazandıysa aynısı kaybettiyse değiştirir
        public void intikamci1()
        {
            if (oynananOyun == 0)
            {
                hero1 = true;
                genel.Add(true);
            }
            else
            {
                if (hero2Gecmis == true && hero1Gecmis == true)
                {
                    hero1 = true;
                    genel.Add(true);
                }
                else if (hero2Gecmis == false && hero1Gecmis == true)
                {
                    hero1 = false;
                    genel.Add(false);
                }
                else if (hero2Gecmis == true && hero1Gecmis == false)
                {
                    hero1 = false;
                    genel.Add(false);
                }
                else if (hero2Gecmis == false && hero1Gecmis == false)
                {
                    hero1 = true;
                    genel.Add(false);
                }

            }
        }

        public void fırsatcı1()
        {
            if (oynananOyun == 0)
            {
                hero1 = true;
                genel.Add(true);
            }
            else
            {
                Random rnd = new Random();
                int numara = rnd.Next(5);
                if (numara == 0)
                {
                    hero1 = false;
                    genel.Add(false);
                }
                else
                {
                    hero1 = hero2Gecmis;
                    genel.Add(hero2Gecmis);
                }

            }
        }

        public void Kopyaci2()   //ilk hamle true diğerleri rakibin önceki hamlesi 
        {
            if (oynananOyun == 0)
            {
                hero2 = true;
                genel.Add(true);
            }
            else
            {
                hero2 = hero1Gecmis;
                genel.Add(hero1Gecmis);
            }
        }

        public void poncik2()   //hep true 
        {
            hero2 = true;
            genel.Add(true);
        }

        public void sinsi2()  //hep false 
        {
            hero2 = false;
            genel.Add(false);
        }

        public void hainHafiza2()  //ilk hamle true, rakip false yapana kadar true sonra full false 
        {
            if (oynananOyun == 0)
            {
                hero2 = true;
                genel.Add(true);
            }
            else
            {
                if (hafiza2 == true && hero1Gecmis == true)
                {
                    hero2 = true;
                    genel.Add(true);
                }
                else if (hafiza2 == true && hero1Gecmis == false)
                {
                    hafiza2 = false;
                    hero2 = false;
                    genel.Add(false);
                }
                else if (hafiza2 == false)
                {
                    hero2 = false;
                    genel.Add(false);
                }
            }
        }

        public void sansliCimbom2() // random sayi oluşturur 1 ise true 0 ise false atar 
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(2);
            if (randomNumber == 0)
            {
                hero2 = false;
                genel.Add(false);
            }
            else if (randomNumber == 1)
            {
                hero2 = true;
                genel.Add(true);
            }
        }

        public void affedenAyna2() //affeden ayna 20 ihtimalle false true yapar 
        {
            if (oynananOyun == 0)
            {
                hero2 = true;
                genel.Add(true);
            }
            else
            {
                if (hero1Gecmis == true)
                {
                    hero2 = true;
                    genel.Add(true);
                }
                else if (hero1Gecmis == false)
                {
                    Random rnd = new Random();
                    int randomNmb = rnd.Next(5);
                    if (randomNmb == 0)
                    {
                        hero2 = true;
                        genel.Add(true);
                    }
                    else
                    {
                        hero2 = hero1Gecmis;
                        genel.Add(hero1Gecmis);
                    }
                }
            }
        }


        public void somurucu2() // sömürücü ilk iki el false sonra rakip false yaparsa kopyacı yapmazsa false devam 
        {
            if (oyunsayısı == 0)
            {
                hero2 = false;
                genel.Add(false);
            }
            else if (oyunsayısı == 1)
            {
                hero2 = false;
                genel.Add(false);
            }
            else
            {
                if (hafiza2 == true && hero1Gecmis == true)
                {
                    hero2 = false;
                    genel.Add(false);
                }
                else if (hafiza2 == true && hero1Gecmis == false)
                {
                    hero2 = false;
                    hafiza2 = false;
                    genel.Add(false);
                }
                else if (hafiza2 == false)
                {
                    hero2 = hero1Gecmis;
                    genel.Add(false);
                }
            }
        }

        public void grupcu2() //oynanan ele göre true veya false yapar 
        {
            if (oynananOyun == 0)
            {
                hero2 = true;
                genel.Add(true);
            }
            else
            {
                int trues2 = 0;
                int falses2 = 0;
                foreach (bool deger in genel)
                {
                    // Eğer eleman true ise
                    if (deger == true)
                    {
                        trues2++;
                    }
                    // Eğer eleman false ise
                    else // (deger == false)
                    {
                        falses2++;
                    }
                }

                if (trues2 >= falses2)
                {
                    hero2 = true;
                    genel.Add(true);
                }
                else
                {
                    hero2 = false;
                    genel.Add(false);
                }
            }

        }

        //ilk el true sonra önceki el kazandıysa aynısı kaybettiyse değiştirir
        public void intikamci2()
        {
            if (oynananOyun == 0)
            {
                hero2 = true;
                genel.Add(true);
            }
            else
            {
                if (hero1Gecmis == true && hero2Gecmis == true)
                {
                    hero2 = true;
                    genel.Add(true);
                }
                else if (hero1Gecmis == false && hero2Gecmis == true)
                {
                    hero2 = false;
                    genel.Add(false);
                }
                else if (hero1Gecmis == true && hero2Gecmis == false)
                {
                    hero2 = false;
                    genel.Add(false);
                }
                else if (hero1Gecmis == false && hero2Gecmis == false)
                {
                    hero2 = true;
                    genel.Add(false);
                }

            }
        }

        public void fırsatcı2()
        {
            if (oynananOyun == 0)
            {
                hero2 = true;
                genel.Add(true);
            }
            else
            {
                Random rnd = new Random();
                int numara = rnd.Next(5);
                if (numara == 0)
                {
                    hero2 = false;
                    genel.Add(false);
                }
                else
                {
                    hero2 = hero1Gecmis;
                    genel.Add(hero1Gecmis);
                }

            }
        }
        private void sonucaGec_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Uygulamanın çalışmasını sonlandırır.
            Application.Exit();
        }

















        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kazananlbl_Click(object sender, EventArgs e)
        {

        }

        private void sonucaGec_Load(object sender, EventArgs e)
        {
            while (oynananOyun < oyunsayısı)//oyun sayısını burda yaptık 
            {
                if (met1 == "Kopyaci")
                {
                    Kopyaci1();
                    pictureBox1.Image = Image.FromFile(@"resimler\herolar\kopyaci.png");
                }
                else if (met1 == "Poncik")
                {
                    poncik1();
                    pictureBox1.Image = Image.FromFile(@"resimler\herolar\poncik.png");
                }
                else if (met1 == "Sinsi")
                {
                    pictureBox1.Image = Image.FromFile(@"resimler\herolar\Sinsi.png");
                    sinsi1();
                }
                else if (met1 == "Hain Hafiza")
                {
                    pictureBox1.Image = Image.FromFile(@"resimler\herolar\hain_hafiza.png");
                    hainHafiza1();

                }
                else if (met1 == "Sansli")
                {
                    pictureBox1.Image = Image.FromFile(@"resimler\herolar\sansli_cimbom.png");
                    sansliCimbom1();
                }
                else if (met1 == "Affeden Ayna")
                {
                    pictureBox1.Image = Image.FromFile(@"resimler\herolar\affetmez_ayna.png");
                    affedenAyna1();
                }
                else if (met1 == "Somurucu")
                {
                    pictureBox1.Image = Image.FromFile(@"resimler\herolar\sömürücü.png");
                    somurucu1();
                }
                else if (met1 == "Grupcu")
                {
                    pictureBox1.Image = Image.FromFile(@"resimler\herolar\grupcu.png");
                    somurucu1();
                }
                else if (met1 == "Intikamcı")
                {
                    pictureBox1.Image = Image.FromFile(@"resimler\herolar\intikamcı.png");
                    intikamci1();
                }
                else if (met1 == "Firsatcı")
                {
                    pictureBox1.Image = Image.FromFile(@"resimler\herolar\fırsatçı.png");
                    fırsatcı1();
                }


                if (met2 == "Kopyaci")
                {
                    pictureBox2.Image = Image.FromFile(@"resimler\herolar\kopyaci.png");
                    Kopyaci2();
                }
                else if (met2 == "Poncik")
                {
                    pictureBox2.Image = Image.FromFile(@"resimler\herolar\poncik.png");
                    poncik2();
                }
                else if (met2 == "Sinsi")
                {
                    pictureBox2.Image = Image.FromFile(@"resimler\herolar\Sinsi.png");
                    sinsi2();
                }
                else if (met2 == "Hain Hafiza")
                {
                    pictureBox2.Image = Image.FromFile(@"resimler\herolar\hain_hafiza.png");
                    hainHafiza2();
                }
                else if (met2 == "Sansli")
                {
                    pictureBox2.Image = Image.FromFile(@"resimler\herolar\sansli_cimbom.png");
                    sansliCimbom2();
                }
                else if (met2 == "Affeden Ayna")
                {
                    pictureBox2.Image = Image.FromFile(@"resimler\herolar\affetmez_ayna.png");
                    affedenAyna2();
                }
                else if (met2 == "Somurucu")
                {
                    pictureBox2.Image = Image.FromFile(@"resimler\herolar\sömürücü.png");
                    somurucu2();
                }
                else if (met2 == "Grupcu")
                {
                    pictureBox2.Image = Image.FromFile(@"resimler\herolar\grupcu.png");
                    somurucu2();
                }
                else if (met2 == "Intikamcı")
                {
                    pictureBox2.Image = Image.FromFile(@"resimler\herolar\intikamcı.png");
                    intikamci2();
                }
                else if (met2 == "Firsatcı")
                {
                    pictureBox2.Image = Image.FromFile(@"resimler\herolar\fırsatçı.png");
                    fırsatcı2();
                }

                if (hero1 == true && hero2 == true)
                {
                    sonuc1 += 2;
                    sonuc2 += 2;
                }
                else if (hero1 == false && hero2 == false)
                {
                    sonuc1 += 1;
                    sonuc2 += 1;
                }
                else if (hero1 == true && hero2 == false)
                {
                    sonuc2 += 3;
                }
                else if (hero1 == false && hero2 == true)
                {
                    sonuc1 += 3;
                }

                hero1Gecmis = hero1;
                hero2Gecmis = hero2;
                oynananOyun++;


            }
            hero1lbl.Text = met1;
            hero2lbl.Text = met2;
            hero1nameendlbl.Text = met1;
            hero2nameendlbl.Text = met2;
            sonuc1lbl.Text = Convert.ToString(sonuc1);
            sonuc2lbl.Text = Convert.ToString(sonuc2);
            oyunsayisilbl.Text = Convert.ToString(oynananOyun);

            if (sonuc1 < sonuc2)
            {
                pictureBox4.Image = Image.FromFile(@"resimler\herolar\tac.png");
            }
            else if (sonuc1 > sonuc2)
            {
                pictureBox3.Image = Image.FromFile(@"resimler\herolar\tac.png");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GamePlay herolar = new GamePlay();
            herolar.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 herosec = new Form1();
            herosec.Show();
            this.Hide();
        }

        private void hero2lbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
