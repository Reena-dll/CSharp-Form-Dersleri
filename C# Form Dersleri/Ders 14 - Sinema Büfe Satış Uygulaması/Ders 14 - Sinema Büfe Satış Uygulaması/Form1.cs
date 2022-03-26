using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_14___Sinema_Büfe_Satış_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int kasa = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet, toplam;
            misir = Convert.ToInt32(textmisir.Text);
            su = Convert.ToInt32(textsu.Text);
            cay = Convert.ToInt32(textçay.Text);
            bilet = Convert.ToInt32(textbilet.Text);

            toplam = misir * 4 + su * 1 + cay * 2 + bilet * 8;

            labeltoplam.Text = toplam.ToString()+" TL";


            kasa = toplam + kasa;

            labelkasa.Text = kasa.ToString()+" TL";

            textmisir.Clear();
            textbilet.Clear();
            textsu.Clear();
            textçay.Clear();
            textmisir.Focus();
        }
    }
}
