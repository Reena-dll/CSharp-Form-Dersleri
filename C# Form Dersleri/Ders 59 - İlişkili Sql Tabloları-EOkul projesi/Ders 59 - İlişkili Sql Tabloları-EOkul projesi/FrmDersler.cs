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
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.Tbl_DerslerTableAdapter ds = new DataSet1TableAdapters.Tbl_DerslerTableAdapter();

        void listele()
        {
            dataGridView1.DataSource = ds.DersListesi();

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Red;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }


        private void FrmDersler_Load(object sender, EventArgs e)
        {

            listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txtDersAd.Text);
            MessageBox.Show("Ders Ekleme İşlemi Yapılmıştır");
            listele();

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            ds.DersSil(Convert.ToByte(txtDersId.Text));
            MessageBox.Show("Ders Silme İşlemi Yapılmıştır");
            listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ds.DersGuncelle(txtDersAd.Text,byte.Parse(txtDersId.Text));
            MessageBox.Show("Ders Güncelleme İşlemi Yapılmıştır");
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDersId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDersAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FrmOgretmen fr = new FrmOgretmen();
            fr.Show();
            this.Hide();
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Green;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Transparent;
        }
    }
}
