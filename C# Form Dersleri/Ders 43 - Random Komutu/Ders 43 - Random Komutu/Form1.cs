using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_43___Random_Komutu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            label1.Text = rnd.Next(1, 5).ToString();
            label2.Text = rnd.Next(1, 5).ToString();
            label3.Text = rnd.Next(1, 5).ToString();
        }
    }
}
