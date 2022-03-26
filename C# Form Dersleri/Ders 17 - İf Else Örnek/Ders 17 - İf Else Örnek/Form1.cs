using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_17___İf_Else_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapadet;
            double toplam;

            kitapadet = Convert.ToInt32(textBox1.Text);
            if (kitapadet >=0 && kitapadet <=20)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.20);
                label3.Text = toplam + " TL";
            }
            else if (kitapadet >=21 && kitapadet<=40)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.40);
                label3.Text = toplam + " TL";
            }
            else
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.50);
                label3.Text = toplam + " TL";
            }

        }
    }
}
