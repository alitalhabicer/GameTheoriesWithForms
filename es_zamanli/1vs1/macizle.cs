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
    public partial class macIzle : Form
    {  
        string met1; string met2; 
        public macIzle(string metin1 , string metin2 )
        {
            InitializeComponent();
           met1  = metin1; 
            met2 = metin2;
            //veriyi çektik form1 deki seçimlere göre heroları kullancaz burda 
        }

        private void macIzle_Load(object sender, EventArgs e)
        {
           
        }



        private void macizle_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Uygulamanın çalışmasını sonlandırır.
            Application.Exit();
        }

    }
}
