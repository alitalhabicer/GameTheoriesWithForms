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
    public partial class NasilOynanir : Form
    {
        public NasilOynanir()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Uygulamanın çalışmasını sonlandırır.
            Application.Exit();
        }

        private void vsRDBTN_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Image.FromFile(@"resimler\tahta\Gemini_Generated_Image_idk0fqidk0fqidk0.png");
            label1.Text = "\r\n\r\n\U0001f91d Oyun Teorisi: 1'e 1 Rasyonel Oynanış\n\r\nOyun Teorisi'nde 1'e 1 rasyonel oyun, basitçe şöyledir: Sen ve rakibin, ikiniz için de en iyi sonucu almayı amaçlarsınız, ancak bunu yaparken diğerinin de aynı şeyi düşündüğünü bilirsiniz. \n\r\n🎯 Temel Kural (Rasyonellik): \n\r\nHer iki oyuncu da her zaman kendi çıkarını maksimuma çıkaracak hamleyi yapar. Asla duygusal veya rastgele karar vermezler. \n\r\n🎲 Oynanış Nasıl Çalışır? \n\r\n1.\tHamleni Düşün: Bir karar vermeden önce (İşbirliği mi, İhanet mi?), rakibinin ne yapacağını tahmin etmeye çalışırsın. \n\r\n2.\tRakibini Düşün: Rakibin de senin ne yapacağını tahmin etmeye çalıştığını biliyorsun. Yani, \"O benim ne yapacağımı düşünüyor, o halde ben ne yapmalıyım?\" diye düşünürsün. \n\r\n3.\tEn İyi Cevabı Bul: Rakibin hangi hamleyi yaparsa yapsın (A veya B), senin için en çok kazandıran cevabı seçersin. \n\r\n⚖️ Sonuç: Nash Dengesi\n\r\nBu karşılıklı düşünme süreci, genellikle \"Nash Dengesi\" adı verilen bir noktada sonlanır. Bu, kimsenin tek başına farklı bir hamle yaparak daha iyi bir sonuç elde edemeyeceği istikrarlı bir durumdur. \n\r\nÖrnek: İki rakip şirket düşünün (Oyuncu A ve Oyuncu B). İkisi de indirim yapmak (İhanet) istemez, çünkü kârları düşer. Ancak A, B'nin indirim yapacağını düşünürse, A'nın tek rasyonel hamlesi de indirim yapmaktır (sömürülmemek için). Sonuç: İkisi de indirim yapar ve kârları düşer. Bu, kimsenin tek başına değiştirmek istemediği (veya değiştiremediği) istikrarlı, ancak optimal olmayan bir denge noktasıdır.\r\n";
            vsRDBTN.Visible = false;
            groupRDBTN.Visible = true;
            button1.Location = new Point(90, 607);
        }

        private void groupRDBTN_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Image.FromFile(@"resimler\tahta\Gemini_Generated_Image_m3dc7qm3dc7qm3dc.png");
            label1.Text = "\n\r\n\n\r\n🐒 Evrimsel Oyun Teorisi: Kuralı En İyi Olan Kazanır\n\r\nEvrimsel Oyun Teorisi, klasik rasyonel oyunun aksine, oyuncuların düşünerek, bilerek veya isteyerek strateji değiştirdiğini varsaymaz. Bunun yerine, stratejilerin bir popülasyon içinde zamanla nasıl yayıldığını ve hayatta kaldığını inceler. \n\r\n\U0001f9ec Temel Fikir\n\r\nBunu, bir ekosistemdeki farklı hayvan türlerinin hayatta kalma mücadelesine benzetebilirsiniz: \n\r\n1.\tStrateji = Gen: Her oyuncu (veya \"birey\"), bir stratejiyi (örneğin Kopyacı veya Sinsi) genetik olarak taşır. \n\r\n2.\tKâr = Üreme Başarısı: Bir strateji, eşleştiği rakiplerine karşı ne kadar yüksek kâr (ödül) elde ederse, o kadar başarılı sayılır. Bu başarı, onun daha fazla kopyalanması (daha fazla bireyin aynı stratejiyi benimsemesi) anlamına gelir. \n\r\n3.\tRekabet ve Yayılma: Başarılı olan stratejilerin sayısı popülasyonda artar, başarısız olanlar ise zamanla elenir ve sayıları azalır. \n\r\n⚖️ Evrimsel İstikrar\n\r\nBu sürecin amacı, Evrimsel Olarak Kararlı Strateji (Evolutionarily Stable Strategy - ESS) adı verilen bir denge noktası bulmaktır. \n\r\n•\tESS Nedir? Bir popülasyonun büyük bir kısmı ESS stratejisini uyguluyorsa, dışarıdan gelen (mutasyon veya göç yoluyla) hiçbir yeni strateji, ESS uygulayanlara karşı başarılı olup popülasyonu istikrarsızlaştıramaz. \n\r\n•\tÖrnek: Eğer bir popülasyon tamamen Ponçik (Always Cooperate) ise, Sinsi (Always Defect) stratejisi hızla yayılır ve Ponçik'i eler (sömürü kârı yüzünden). Dolayısıyla Ponçik, ESS değildir. Ancak Kopyacı (Tit-for-Tat) gibi bir strateji, popülasyonun çoğunluğunu oluşturduğunda, Sinsi gelip onu sömürmeye kalksa bile, Kopyacı misilleme yaparak Sinsi'nin kârını engeller ve popülasyonun istikrarını korur. \n\r\nÖzetle: Evrimsel Oyun Teorisi, hangi davranış (strateji) kuralının, bilinci olmayan bir süreçte (doğal seçilim gibi) uzun vadede popülasyon içinde baskın ve istikrarlı olacağını matematiksel olarak tahmin eder. \r\n";
            groupRDBTN.Visible = false;
            vsRDBTN.Visible = true;
            button1.Location = new Point(1032, 607);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GamePlay gamePlay = new GamePlay();
            gamePlay.Show();
            this.Hide(); 
        }
    }
}
