using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_20___For_Döngüsü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i+=2)
            {
                listBox1.Items.Add(i+" Merhaba Ankara");
            }

            // 1 ile 10 arasında ki sayıların toplamı

            //int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    toplam += i;
            //}
            // label1.Text = toplam.ToString();

            // 1 ile 10 arasında ki çift sayıların toplamı

            int toplam = 0;
            for (int i = 2; i <= 10; i+=2)
            {
                toplam += i;
            }
            label1.Text = toplam.ToString();
        }
    }
}
