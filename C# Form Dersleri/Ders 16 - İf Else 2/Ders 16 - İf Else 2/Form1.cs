using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_16___İf_Else_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, proje, ortalama;
            string durum;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            proje = Convert.ToDouble(textBox3.Text);

            ortalama = (s1 + s2 + proje) / 3;

            if (ortalama >= 50)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Kaldı";
            }

            label4.Text = ortalama.ToString("0.00")+" - "+durum;

        }
    }
}
