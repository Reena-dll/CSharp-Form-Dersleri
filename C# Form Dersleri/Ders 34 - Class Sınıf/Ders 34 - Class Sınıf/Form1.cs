using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_34___Class_Sınıf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();

            rb.renk = "Mavi";
            rb.hız = 160;
            rb.motor = 1245.56;
            rb.fiyat = 50000;
            rb.durum = 's';

            label1.Text = rb.renk;
            label2.Text = rb.hız.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.fiyat.ToString();
            label5.Text = rb.durum.ToString();
        }
    }
}
