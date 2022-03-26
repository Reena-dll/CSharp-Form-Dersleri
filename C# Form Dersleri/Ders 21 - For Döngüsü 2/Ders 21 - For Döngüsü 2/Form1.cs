using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_21___For_Döngüsü_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 3 e bölülenleri listele
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i%3 == 0)
            //    {
            //        listBox1.Items.Add(i);
            //    }
            //}

            // 1 ile 100 arasında 5e ve 7e bölünen sayıları listele

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i% 5 == 0 && i% 7 == 0)
            //    {
            //        listBox1.Items.Add(i);
            //    }

            //}

            // Klavyeden girilen sayıya kadar listeyelen program


            //listBox1.Items.Clear();

            //int sayi;
            //sayi = Convert.ToInt32(textBox1.Text);

            //for (int i = 1; i <= sayi; i++)
            //{
            //    listBox1.Items.Add(i);
            //}

            // Klavyeden girilen sayının tam bölenlerini veren program

            listBox1.Items.Clear();
            int sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= sayi ; i++)
            {
                if (sayi %i == 0)
                {
                    listBox1.Items.Add(i);
                }
            }

        }
    }
}
