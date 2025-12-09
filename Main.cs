namespace GameTheories
{
    public partial class Main : Form
    {
        private string fullText1 = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nOyun Teorisi (Game Theory) ... \r\n\r\nOyun Teorisi, nükleer silahsýzlanma gibi büyük devlet politikalarýndan süpermarketlerin indirim stratejilerine veya evrimsel biyolojideki eþ seçimine kadar, farklý alanlardaki tüm karar alma süreçlerini tek bir çatý altýnda toplar.\r\n\r\nTemelde, bu teori sizin ve karþýnýzdaki rakibinizin rasyonel olduðunu varsayar.\r\n\r\nAmacý, sizin bir hamle yaptýðýnýzda rakibinizin size nasýl tepki vereceðini matematiksel olarak tahmin etmek ve bu tepkiyi hesaba katarak sizin için en kârlý sonucu (en yüksek kâr ve en iyi anlaþmayý) getirecek kararý vermektir.\r\n";
        private int charÝndex1;
        public Main()
        {
            InitializeComponent();
            lbl1.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Her 50 milisaniyede bir (saniyede 20 harf) tetiklensin.
            // Bu deðeri deðiþtirerek hýzý ayarlayabilirsiniz.
            tmr1.Interval = 1;

            // Timer'ý baþlat
            tmr1.Start();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            if (charÝndex1 < fullText1.Length)
            {
                // 1. fullText'in o anki indeksindeki harfi al ve label'a ekle
                lbl1.Text += fullText1[charÝndex1];

                // 2. Bir sonraki harfe geçmek için indeksi artýr
                charÝndex1++;
            }
            else
                tmr1.Stop();
        }

        private void okmainBT_Click(object sender, EventArgs e)
        {
            if (tmr1.Enabled == false)
            {

                GamePlay gamePlay = new GamePlay();
                gamePlay.Show();
                this.Hide();

            }
        }

        private void NasilOynanirBT_Click_1(object sender, EventArgs e)
        {
            if (tmr1.Enabled == false)
            {
                NasilOynanir nasilOynanir = new NasilOynanir();
                nasilOynanir.Show();
                this.Hide();
            }
        }

        private void FormClosed(object sender, FormClosedEventArgs e)
        {
            // Uygulamanýn çalýþmasýný sonlandýrýr.
            Application.Exit();
        }
        //bitti

    }
}
