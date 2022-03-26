using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ders_53___Metin_Belgesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dosyaadi, dosyayolu;
        StreamWriter sw;

        private void button3_Click(object sender, EventArgs e)
        {
            dosyaadi = textBox2.Text;
            sw = File.CreateText(dosyayolu + "\\" + dosyaadi + ".txt");
            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string satir = sr.ReadLine();
                while (satir!=null)
                {
                    listBox1.Items.Add(satir);
                    satir = sr.ReadLine();
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Title = "Metin Kaydet";
                saveFileDialog1.Filter = "Metin Dosyaları|*.txt";
                saveFileDialog1.ShowDialog();

                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(richTextBox1.Text);
                sw.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("İptal Edildi");
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()== DialogResult.OK)
            {
                dosyayolu = folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = dosyayolu;
            }
        }
    }
}
