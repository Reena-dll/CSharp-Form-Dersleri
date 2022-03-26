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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;
        sqlbaglantisi bgl = new sqlbaglantisi();

        void randevugecmis()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            // AD SOYAD ÇEKME
            labelTc.Text = tc;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", labelTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labeladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            // Randevu Geçmiş
            randevugecmis();

            // Branşları Çekme

            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            cmbDoktor.Text = "";
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            
            bgl.baglanti().Close();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + cmbBrans.Text + "'"+" and RandevuDoktor='"+cmbDoktor.Text+"' and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.tcno = labelTc.Text;
            fr.Show();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular Set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", labelTc.Text);
            komut.Parameters.AddWithValue("@p2", rchSikayet.Text);
            komut.Parameters.AddWithValue("@p3", textİD.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            randevugecmis();
            textİD.Text = "";
            cmbBrans.Text = "";
            cmbDoktor.Text = "";
            rchSikayet.Text = "";
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textİD.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();

        }
    }
}
