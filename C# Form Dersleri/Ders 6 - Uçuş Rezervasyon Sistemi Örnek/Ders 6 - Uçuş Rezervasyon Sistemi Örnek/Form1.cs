using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_6___Uçuş_Rezervasyon_Sistemi_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text + " Tarih: " + dateTimePicker1.Text + " Saat: " + maskedTextBox1.Text + " Yolcu Bilgileri ~~ Ad: " + textBox1.Text + " TC: " + maskedTextBox2.Text + " Telefon: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydı Yapıldı");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a, b;

            a = comboBox1.Text;
            b = comboBox2.Text;

            comboBox2.Text = a;
            comboBox1.Text = b;


        }
    }
}
