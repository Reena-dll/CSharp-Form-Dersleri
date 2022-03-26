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
using System.Runtime.InteropServices;

namespace Ders_54___Hastene_Yönetim_ve_Randevu_Sistemi
{
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Doktorlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void temizle()
        {
            textAd.Clear();
            textSifre.Clear();
            mskTc.Clear();
            textSoyad.Clear();
            cmbBrans.Text = "";
        }
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            listele();

            // Branşları combobaxa aktarma 
            SqlCommand komut = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBrans.Items.Add(dr[0]);
            }
            
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textAd.Text);
            komut.Parameters.AddWithValue("@p2", textSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", mskTc.Text);
            komut.Parameters.AddWithValue("@p5", textSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorTc=@p4,DoktorSifre=@p5 where DoktorTC=@p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textAd.Text);
            komut.Parameters.AddWithValue("@p2", textSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", mskTc.Text);
            komut.Parameters.AddWithValue("@p5", textSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }
    }
}
