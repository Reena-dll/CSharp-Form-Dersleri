using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_1___Hello_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Oğuzhan";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //label6.Text = "Oğuzhan";
            //label7.Text = "Sadıkoğlu";
            //label8.Text = "Yazılım Mühendisi";

            label6.Text = textBox2.Text;
            label7.Text = textBox3.Text;
            label8.Text = textBox4.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label9.Text = textBox1.Text;
        }
    }
}
