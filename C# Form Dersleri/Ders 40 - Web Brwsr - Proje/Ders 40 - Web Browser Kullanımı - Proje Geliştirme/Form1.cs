using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_40___Web_Browser_Kullanımı___Proje_Geliştirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program Oğuzhan Sadıkoğlu tarafından yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void turunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void madMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hEJnMQG9ev8");
            label1.Text = "Mad Max Trailer";
        }

        private void ıLoveYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=CZzW6_hR068");
            label1.Text = "P.S I LOVE YOU Trailer";

        }

        private void korkuSeansıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=k10ETZ41q5o");
            label1.Text = "Korku Seansı Trailer";

        }

        private void uzayYolcularıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=7BWWWQzTpNU");
            label1.Text = "Uzay Yolcuları Trailer";

        }
    }
}
