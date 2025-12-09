using GameTheories.es_zamanli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTheories
{
    public partial class GamePlay : Form
    {
        public GamePlay()
        {
            InitializeComponent();
        }


        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Uygulamanın çalışmasını sonlandırır.
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        /* kopyaciLBL
         poncikLBL
         sinsiLBL
         hain_hafizaLBL
         sansliLBL
         affeden_aynaLBL
         somurucuLBL
         grupcuLBL
         intikamciLBL
         firsatciLBL*/



        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seciliIndex = comboBox3.SelectedIndex;
            string resimYolu = "";
            if (seciliIndex == 0)
            {
                resimYolu = @"resimler\herolar\kopyaci.png";

                kopyaciLBL.Text = "\n\n\n\n\r\n\r\n\r\n\r\n\r\n\r\n1. Kopyacı (Tit-for-Tat - TFT) \U0001f91d\r\nKopyacı, ilk turda True (İşbirliği) ile başlayan ve sonrasında rakibin bir önceki hamlesini taklit eden dengeli bir stratejidir. Hem nazik hem de misillemeci olması nedeniyle evrimsel süreçte en başarılı stratejilerden biri olmuştur. Kopyacı, İşbirliği yaparak yüksek ödüllere ulaşma potansiyeli sunar, ancak ihanetle karşılaştığında anında misilleme yaparak sömürülmeyi tek bir tura indirir.\r\n\n\nÖrnek: Kopyacı, Sinsi (Hep ) ile eşleştiğinde, ilk turda puan alarak sömürülür. Ancak 2. turda oynayarak misilleme yapar ve skor 'e döner. Bu andan itibaren Sinsi'nin potansiyel kârını engeller.\r\n\n\nRiskler: Kopyacı'nın temel riski gürültülü ortamlardır. Oyunda rastgele bir hata (yanlışlıkla oynama) meydana gelirse, Kopyacı bu hataya ile karşılık verir. Bu durum, iki Kopyacı'nın birbirine karşı sürekli oynayarak (Kopyacı A'nın B'nin 'una ile, B'nin A'nın 'una ile karşılık vermesi, vb.) karşılıklı olarak düşük puan almaya devam ettiği bir intikam döngüsü başlatabilir.\r\n";

            }
            else if (seciliIndex == 1)
            {
                resimYolu = @"resimler\herolar\poncik.png";
                kopyaciLBL.Text = "\n\n\n\n\r\n\r\n\r\n\r\n\r\n\r\n2. Ponçik (Always Cooperate - All C) 😇\r\nPonçik, koşulsuz şartsız her turda True (İşbirliği) oynamaya odaklanır. Maksimum puan (3, 3) almanın tek yolu İşbirliği olduğu için, Ponçik ideal bir dünyada en yüksek puanı toplar. Ancak bu strateji, Oyun Teorisi'ndeki temel rasyonel varsayımı (bireysel çıkar) göz ardı eder ve rakibin iyi niyetli olmasını varsayar.\n\n\r\nÖrnek: Ponçik, Sinsi (Hep ) ile eşleştiğinde, her turda oynar ve skor sürekli olur. Ponçik'in kazancı her turda 0'dır.\n\n\r\nRiskler: Ponçik'in tek ve en büyük riski sömürülmedir. Popülasyonda oynayan tek bir strateji bile olsa, Ponçik ona karşı sürekli sıfır puan alarak popülasyondan hızla elenir. Misilleme yeteneği sıfırdır, bu da onu evrimsel olarak savunmasız kılar.\r\n";


            }
            else if (seciliIndex == 2)
            {
                resimYolu = @"resimler\herolar\Sinsi.png";
                kopyaciLBL.Text = "\n\n\n\n\r\n\r\n\r\n\r\n\r\n\r\n3. Sinsi (Always Defect - All D) 😈\r\nSinsi, her zaman False (İhanet) oynamayı seçen koşulsuz bencil bir stratejidir. Kısa vadede ve özellikle Ponçik gibi naif stratejiler karşısında her zaman kazanır, çünkü karşısındaki İşbirliği yaptıkça her turda en yüksek puanı (5) alır. Bu durum, onun başlangıç popülasyonlarında hızla yayılmasını sağlar. \n\n\r\nÖrnek: Sinsi, Ponçik (Hep ) ile eşleştiğinde, her turda oynar ve skor sürekli olur. Sinsi'nin kazancı her turda 5'tir. \n\n\r\nRiskler: Sinsi'nin temel riski misillemeci stratejilerdir. Kopyacı veya Hain Hafıza gibi stratejilerle eşleştiğinde, ilk turdan sonra 'a karşı oynanacağı için skor 'e düşer. Sinsi, popülasyon içinde yayılıp kendi türleriyle eşleşmeye başladığında da skorları olur. Bu düşük ortalama puan, Sinsi'nin popülasyonda baskın olmasını engeller ve yerini İşbirliği yapan stratejilere bırakmasına neden olur.\r\n";

            }
            else if (seciliIndex == 3)
            {
                resimYolu = @"resimler\herolar\hain_hafiza.png";
                kopyaciLBL.Text = "\n\n\n\n\r\n\r\n\r\n\r\n\r\n\r\n4. Hain Hafıza (Grudger / Friedman's Strategy) 😡\r\nHain Hafıza, oyuna (İşbirliği) ile başlayarak nazik davranır. Ancak rakip tek bir turda dahi (İhanet) yaparsa, bu ihaneti asla unutmaz ve oyunun sonuna kadar sürekli oynamaya geçer. Misilleme mekanizması sonsuzdur ve çok katıdır. \n\n\r\nÖrnek: Hain Hafıza, Sinsi ile eşleştiğinde, ilk turda oynayıp puan alır. İhanetle karşılaştığı için 2. turdan itibaren oynamaya başlar ve skor 'e döner. Bu durum oyun sonuna kadar sürer. \n\n\r\nRiskler: Hain Hafıza'nın riski, affetme yeteneğinin olmamasıdır. Eğer eşleştiği strateji (örneğin Kopyacı) rastgele bir hata yaparsa ve yanlışlıkla oynarsa, Hain Hafıza oyunu hemen 'a çevirir. Kopyacı hatayı fark edip tekrar oynasa bile, Hain Hafıza artık affetmeyeceği için oyunu sürekli skorunda bitirir. Bu, iki potansiyel işbirlikçinin uzun vadede yüksek puan almasını engeller.\r\n";


            }
            else if (seciliIndex == 4)
            {
                resimYolu = @"resimler\herolar\sansli_cimbom.png";
                kopyaciLBL.Text = "\n\n\n\n\r\n\r\n\r\n\r\n\r\n\r\n5. Şanslı (Random) 🎰\r\nŞanslı, önceden belirlenmiş bir kurala sahip değildir; her turda yaklaşık %50 ihtimalle , %50 ihtimalle oynar. Tamamen rastgele kararlar verir ve bu yüzden diğer stratejiler için öngörülemezdir. \n\n\r\nÖrnek: Şanslı, Kopyacı ile eşleştiğinde, rastgele davranışları nedeniyle Kopyacı'nın da kararları sürekli olarak rastgele dalgalanır. Bu iki strateji, ne sürekli skorunu ne de sürekli skorunu yakalayabilir. Skorları rastgele sömürü, ödül ve ceza puanları arasında gidip gelir. \n\n\r\nRiskler: Şanslı'nın temel riski tutarsızlıktır. Ne İşbirliği'nin güvenilirliğinden faydalanabilir ne de sistematik İhanetin kârını toplayabilir. Ortalamada, rastgele davranışları nedeniyle başarılı stratejilerden çok daha düşük puanlar alır ve evrimsel süreçte geride kalır.\r\n";


            }
            else if (seciliIndex == 5)
            {
                resimYolu = @"resimler\herolar\affetmez_ayna.png";
                kopyaciLBL.Text = "\n\n\n\n\r\n\r\n\r\n\r\n\r\n\r\n6. Affeden Ayna (Forgiving Tit-for-Tat) 🕊️\r\nAffeden Ayna, Kopyacı'nın temel prensibine sadıktır, ancak düşük bir ihtimalle (%20 gibi) rakibin ihanetini affedebilir ve bir sonraki turda misilleme yapmak yerine oynayabilir. Bu strateji, gürültülü (hataların olduğu) ortamlarda daha üstün performans göstermek üzere tasarlanmıştır. \n\n\r\nÖrnek: Affeden Ayna, Hain Hafıza ile eşleştiğinde ve Hain Hafıza yanlışlıkla oynadığında, Affeden Ayna'nın %20'lik affetme olasılığı devreye girer. Eğer affederse, Hain Hafıza'nın sürekli oynamasını engelleyerek karşılıklı düşük puan döngüsünü kırar ve oyunu tekrar İşbirliği dengesine taşıyabilir. \n\n\r\nRiskler: Affeden Ayna'nın riski, Sinsi gibi bir stratejinin karşısında gereksiz yere affetme ihtimalidir. Her affetme, Sinsi'nin bir hamlesine karşılık Affeden Ayna'nın oynaması anlamına gelir (skor ). Bu, Sinsi'ye gereksiz bir ekstra puan hediye eder ve sömürülme süresini uzatır.\r\n";


            }
            else if (seciliIndex == 6)
            {
                resimYolu = @"resimler\herolar\sömürücü.png";
                kopyaciLBL.Text = "\n\n\n\n\r\n\r\n\r\n\r\n\r\n\r\n7. Sömürücü (Test-and-Defect) 🐍\r\nSömürücü, oyuna agresif bir şekilde (İhanet) ile başlar ve rakibini test eder. Rakip misilleme yapmazsa (naifse), oynamaya devam ederek sömürür. Eğer misilleme gelirse, hemen stratejisini Kopyacı'ya dönüştürür ve işbirliği kurmaya çalışır. Bu, fırsatçı ve riskli bir stratejidir. \n\n\r\nÖrnek: Sömürücü, Ponçik ile eşleştiğinde, ilk hamlesine karşılık aldığı için (misilleme yok), Ponçik'in naif olduğunu tespit eder ve oyun sonuna kadar oynamaya devam eder, sürekli skorunu alır. \n\n\r\nRiskler: Sömürücü'nün riski, ilk hamlesidir. Kopyacı, Hain Hafıza veya İntikamcı gibi güçlü misillemecilerle karşılaştığında, ilk hamlesi nedeniyle anında cezalandırılır ve Sömürücü'nün Kopyacı'ya dönüşme çabası, zaten ceza döngüsüne girmiş olduğu anlamına gelir. Bu ilk hata, misillemeciler karşısında düşük ortalama puan almasına neden olur.\r\n";


            }
            else if (seciliIndex == 7)
            {
                resimYolu = @"resimler\herolar\fırsatçı.png";
                kopyaciLBL.Text = "\n\n\n\n\r\n\r\n\r\n\r\n\r\n\r\n8. Fırsatçı (TFT with Jitter) \U0001f92b\r\nFırsatçı, temelde Kopyacı'nın kuralını izler ancak arada bir (düşük ve rastgele bir ihtimalle) hiçbir neden yokken sürpriz bir (İhanet) hamlesi yapar. Amacı, diğer işbirlikçileri sarsmadan küçük, ekstra bir sömürü kârı elde etmektir. \n\n\r\nÖrnek: Fırsatçı ve Kopyacı, 10 tur boyunca skorunu alarak İşbirliği yapmıştır. 11. turda Fırsatçı oynar, Kopyacı oynar ve Fırsatçı puan alır. Ancak 12. turda Kopyacı misilleme olarak oynar. Bu, Fırsatçı'nın tek turda elde ettiği kârı, misilleme döngüsü yoluyla hızla geri kaybetmesine yol açar. \n\n Riskler: Fırsatçı'nın riski, uzun vadeli işbirliğini bozmasıdır. Elde ettiği küçük kâr, Kopyacı'nın misillemesi veya Hain Hafıza'nın sürekli 'a geçmesiyle misliyle geri alınır. Bu, onu Kopyacı'dan daha istikrarsız ve uzun vadeli İşbirliği ortamında daha az başarılı yapar.\r\n";


            }
            else if (seciliIndex == 8)
            {
                resimYolu = @"resimler\herolar\grupcu.png";
                kopyaciLBL.Text = "\n\n\n\n\r\n\r\n\r\n\r\n\r\n\r\n9. Grupçu (Majority Rule) 🗳️\r\nGrupçu, ilk turdan sonraki hamlelerini, kendisinin ve rakibinin geçmiş tüm hamlelerinin çoğunluğuna göre belirler. Oyunun başındaki hamleleri büyük bir ağırlık taşır ve stratejinin yavaş değişmesine neden olur. Bir tür toplumsal eğilimleri izleme stratejisidir. \n\n\r\nÖrnek: Grupçu, Sinsi ile eşleştiğinde, ilk birkaç tur oynadığı için sömürülür. Ancak Sinsi sürekli oynadığı için, oyun ilerledikçe hamleleri çoğunluk haline gelir. hamleleri çoğunluk olduğunda, Grupçu da oynamaya başlar ve skor 'e döner. \n\n\r\nRiskler: Grupçu'nun riski, yavaş tepki vermesidir. Sinsi gibi bir ihanet tehdidi ilk ortaya çıktığında, Grupçu tehdidi algılayıp çoğunluk kuralına geçiş yapana kadar uzun bir süre sömürülür. Bu yavaşlık, hızlı misilleme yapan Kopyacı'ya kıyasla daha fazla puan kaybetmesine neden olur.\r\n";


            }
            else if (seciliIndex == 9)
            {
                resimYolu = @"resimler\herolar\intikamcı.png";
                kopyaciLBL.Text = "\n\n\n\n\r\n\r\n\r\n\r\n\r\n\r\n10. İntikamcı (Pavlov / Win-Stay, Lose-Shift) 🔁\r\nİntikamcı, \"Kazan-Devam Et, Kaybet-Değiştir\" kuralına uyar. Eğer bir önceki turda yüksek puan aldıysa (kazandıysa), aynı eylemi tekrarlar. Eğer düşük puan aldıysa (kaybettiyse), eylemini tersine çevirir. Bu, sonuç odaklı basit bir öğrenme mekanizmasıdır. \n\n\r\nÖrnek: İntikamcı, Sinsi ile eşleştiğinde, ilk turda puan alarak kaybeder. 2. turda eylemini değiştirir ve oynar, skor olur. Bu bir kazanç olmadığı için (ceza puanı), İntikamcı tekrar eylemini değiştirir ve 3. turda oynar, skor olur ve kaybeder. İntikamcı, Sinsi karşısında sürekli ve arasında kararsız kalır ve düşük ortalama puan alır. \n\n\r\nRiskler: İntikamcı'nın riski, kayıp eşiğini belirlemesindeki basitlikten kaynaklanır. Sinsi örneğinde görüldüğü gibi, optimal olmayan puanları (1 veya 0) kayıp olarak algıladığı için, kararlı bir şekilde düşük puan döngüsünde kalmak yerine ve arasında salınım yapabilir. Ancak en büyük avantajı, hatalı bir ortamda bile iki İntikamcı'nın hızla İşbirliği dengesine dönebilme yeteneğidir.\r\n";


            }
            else
            {
                // Resim yolu boşsa veya dosya yoksa, resmi temizle
                resimYolu = "";
                pictureBox1.Image = Image.FromFile(@"resimler\herolar\hepsi.png");
                pictureBox1.Dock = DockStyle.None;
                pictureBox1.Location = new System.Drawing.Point(123, 97);
                pictureBox1.Size = new System.Drawing.Size(958, 321);
                kopyaciLBL.Text = "Kopyacı";
                kopyaciLBL.Dock = DockStyle.None;
                kopyaciLBL.BackColor = Color.CornflowerBlue;
                kopyaciLBL.Size = new System.Drawing.Size(66, 20);
                kopyaciLBL.Location = new System.Drawing.Point(176, 327);
                poncikLBL.Visible = true;
                sinsiLBL.Visible = true;
                hain_hafizaLBL.Visible = true;
                sansliLBL.Visible = true;
                affeden_aynaLBL.Visible = true;
                somurucuLBL.Visible = true;
                grupcuLBL.Visible = true;
                intikamciLBL.Visible = true;
                firsatciLBL.Visible = true;

            }

            if (!string.IsNullOrEmpty(resimYolu) && System.IO.File.Exists(resimYolu))
            {
                // Önceki resmi bellekten temizle
                pictureBox1.Image?.Dispose();

                // Yeni resmi PictureBox'a yükle
                pictureBox1.Image = Image.FromFile(resimYolu);

                pictureBox1.Location = new System.Drawing.Point(10, 10);
                pictureBox1.Size = new System.Drawing.Size(400, 400);
                pictureBox1.Dock = DockStyle.Left;
                kopyaciLBL.Dock = DockStyle.Fill;
                kopyaciLBL.BackColor = this.BackColor;

                poncikLBL.Visible = false;
                sinsiLBL.Visible = false;
                hain_hafizaLBL.Visible = false;
                sansliLBL.Visible = false;
                affeden_aynaLBL.Visible = false;
                somurucuLBL.Visible = false;
                grupcuLBL.Visible = false;
                intikamciLBL.Visible = false;
                firsatciLBL.Visible = false;

            }







        }

        private void button1_Click(object sender, EventArgs e)
        {
            NasilOynanir nasilOynanir = new NasilOynanir();
            nasilOynanir.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Eş zamanlı oyun " &&  comboBox2.Text == "1 vs 1 ")
            {
                Form1 oyun1vs1 = new Form1();
                oyun1vs1.Show();
                this.Hide(); 
            }
        }


        //labela karakterlerin özelliklerini yazdircaz 
        //diğerlerin seçeneklerini koyduk if elslerle yeni formlar eklicem form 4 ve 5 olarak onları kontrol edicez 

    }
}
