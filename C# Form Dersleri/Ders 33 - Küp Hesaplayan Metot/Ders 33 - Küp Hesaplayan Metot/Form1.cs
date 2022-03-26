using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_33___Küp_Hesaplayan_Metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int kup(int sayi)
        {
            int sonuc = sayi * sayi * sayi;
            return sonuc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);

            label1.Text = kup(sayi).ToString();
        }
    }
}
