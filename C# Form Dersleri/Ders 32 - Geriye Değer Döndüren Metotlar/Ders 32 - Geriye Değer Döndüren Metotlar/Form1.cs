using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_32___Geriye_Değer_Döndüren_Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Toplam(int s1, int s2)
        {
            int toplam = s1 + s2;
            return toplam;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Toplam(s1:4,s2:6).ToString();
            label2.Text = Toplam(2, 3).ToString();
            label3.Text = Toplam(4, 8).ToString();
        }
    }
}
