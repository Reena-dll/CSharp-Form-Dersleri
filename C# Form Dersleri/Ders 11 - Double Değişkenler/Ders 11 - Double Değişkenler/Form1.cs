using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_11___Double_Değişkenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    double s1, s2, s3, ort;
            //    s1 = 60;
            //    s2 = 70;
            //    s3 = 79;
            //    ort = (s1 + s2 + s3) / 3;
            //    label1.Text = ort.ToString("0.000");

            double sayi = Convert.ToDouble(textBox1.Text);
            label1.Text = sayi.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
