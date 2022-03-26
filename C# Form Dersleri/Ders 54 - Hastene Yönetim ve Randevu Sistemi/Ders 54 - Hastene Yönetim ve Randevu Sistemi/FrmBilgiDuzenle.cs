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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string tcno;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTc.Text = tcno;
            SqlCommand komut = new SqlCommand("Select * from Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textAd.Text = dr[1].ToString();
                textSoyad.Text = dr[2].ToString();
                mskTel.Text = dr[4].ToString();
                textSifre.Text = dr[5].ToString();
                cmbCinsiyet.Text = dr[6].ToString();

            }
            bgl.baglanti().Close();
        }

        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1, HastaSoyad=@p2, HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", textAd.Text);
            komut2.Parameters.AddWithValue("@p2", textSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", mskTel.Text);
            komut2.Parameters.AddWithValue("@p4", textSifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut2.Parameters.AddWithValue("p6", mskTc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }
    }
}
