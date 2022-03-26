using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_8___Int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    int sayi1, sayi2, toplam;

            //    sayi1 = 10;
            //    sayi2 = 12;

            //    toplam = sayi1 + sayi2;
            //    label1.Text = toplam.ToString();

            int kenar, alan, cevre;

            kenar = 10;
            alan = kenar * kenar;
            cevre = kenar * 4;

            label1.Text = "Alan: " + alan+" Çevre: "+cevre;



        }
    }
}
