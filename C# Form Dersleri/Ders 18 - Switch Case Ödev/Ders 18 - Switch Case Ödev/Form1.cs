using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_18___Switch_Case_Ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            char karakter;

            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            karakter = Convert.ToChar(textBox3.Text);

            switch (karakter)
            {
                case 'x': label5.Text = (sayi1 * sayi2).ToString(); break;
                case '+': label5.Text = (sayi1 + sayi2).ToString(); break;
                case '-': label5.Text = (sayi1 - sayi2).ToString(); break;
                case '/': label5.Text = (sayi1 / sayi2).ToString(); break;

                default:label5.Text = "Yanlış Operatör Girildi. Lütfen + - / x Operatörlerini Kullanınız.";
                    break;
            }
        }
    }
}
