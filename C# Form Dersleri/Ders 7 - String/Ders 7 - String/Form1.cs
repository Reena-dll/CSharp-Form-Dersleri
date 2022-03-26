using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_7___String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adsoyad, meslek;

            adsoyad = "OğuzhanSadıkoğlu";
            meslek = "Software Devoloper";

            label1.Text = adsoyad;
            label2.Text = meslek;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sehir;

            sehir = textBox1.Text;
            label3.Text = sehir;
        }
    }
}
