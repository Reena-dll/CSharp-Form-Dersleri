using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_59___İlişkili_Sql_Tabloları_EOkul_projesi
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKulup fr = new FrmKulup();
            fr.Show();
        }

        private void BtnDers_Click(object sender, EventArgs e)
        {
            FrmDersler dr = new FrmDersler();
            dr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmOgrenci fr = new FrmOgrenci();
            fr.Show();
            this.Hide();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Red;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSinavNotlar fr = new FrmSinavNotlar();
            fr.Show();
            this.Hide();
        }
    }
}
