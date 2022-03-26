using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_19___Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            butonA.Enabled = false;
            butonB.Enabled = false;
            butonC.Enabled = false;
            butonD.Enabled = false;
        }

        

        private void butonSonraki_Click(object sender, EventArgs e)
        {
            butonSonraki.Enabled = false;
            butonA.Enabled = true;
            butonB.Enabled = true;
            butonC.Enabled = true;
            butonD.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruno++;
            labelSoruNo.Text = soruno.ToString();
            if (soruno==1)
            {
                richTextBox1.Text = "Cumhuriyet Kaç Yılında İlan Edilmiştir?";
                butonA.Text = "1920";
                butonB.Text = "1921";
                butonC.Text = "1922";
                butonD.Text = "1923";
                label4.Text = "1923";
            }

            if (soruno==2)
            {
                richTextBox1.Text = "Hangi Şehir Ege Bölgemizde Bulunmaz";
                butonA.Text = "İzmir";
                butonB.Text = "Balıkesir";
                butonC.Text = "Aydın";
                butonD.Text = "Manisa";
                label4.Text = "Balıkesir";
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir ?";
                butonA.Text = "Sait Faik";
                butonB.Text = "Cemal Süreyya";
                butonC.Text = "Attila İlhan";
                butonD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                butonSonraki.Text = "Sonuçlar";
            }

            if (soruno==4)
            {
                butonA.Enabled = false;
                butonB.Enabled = false;
                butonC.Enabled = false;
                butonD.Enabled = false;
                butonSonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);
                this.Close();
            }
        }

      

        private void butonA_Click(object sender, EventArgs e)
        {
            butonA.Enabled = false;
            butonB.Enabled = false;
            butonC.Enabled = false;
            butonD.Enabled = false;
            butonSonraki.Enabled = true;
            label5.Text = butonA.Text;

            if (label5.Text == label4.Text)
            {
                dogru++;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

    

        private void butonB_Click(object sender, EventArgs e)
        {
            butonSonraki.Enabled = true;

            butonA.Enabled = false;
            butonB.Enabled = false;
            butonC.Enabled = false;
            butonD.Enabled = false;
            label5.Text = butonB.Text;

            if (label5.Text == label4.Text)
            {
                dogru++;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }

            

        }

        private void butonC_Click(object sender, EventArgs e)
        {
            butonSonraki.Enabled = true;

            butonA.Enabled = false;
            butonB.Enabled = false;
            butonC.Enabled = false;
            butonD.Enabled = false;
            label5.Text = butonC.Text;

            if (label5.Text == label4.Text)
            {
                dogru++;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void butonD_Click(object sender, EventArgs e)
        {
            butonSonraki.Enabled = true;

            butonA.Enabled = false;
            butonB.Enabled = false;
            butonC.Enabled = false;
            butonD.Enabled = false;
            label5.Text = butonD.Text;

            if (label5.Text == label4.Text)
            {
                dogru++;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}
