using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTheories.es_zamanli._1vs1
{
    public partial class sonucaGec : Form
    {
        string met1, met2; 
        public sonucaGec(string metin1 , string metin2 )
        {
            InitializeComponent();
            met1 = metin2;
            met2 = metin2;
            //veriyi çektik form1 deki seçimlere göre heroları kullancaz burda  
        }

        private void sonucaGec_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Uygulamanın çalışmasını sonlandırır.
            Application.Exit();
        }
    }
}
