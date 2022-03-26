using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Ders_54___Hastene_Yönetim_ve_Randevu_Sistemi
{
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();


        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void temizle()
        {
            txtBransAd.Clear();
            txtId.Clear();
        }

        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBransAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Kayıt Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete Tbl_Branslar where Bransid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update  Tbl_Branslar set BransAd=@p1 where bransid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBransAd.Text);
            komut.Parameters.AddWithValue("@p2", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }
    }
}
