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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TCNO;

        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTc.Text = TCNO;

            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textAd.Text = dr[1].ToString();
                textSoyad.Text = dr[2].ToString();
                cmbBrans.Text = dr[3].ToString();
                textSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tbl_doktorlar set DoktorAd=@p1, DoktorSoyad=@p2, DoktorBrans=@p3, DoktorSifre=@p4 where DoktorTC=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textAd.Text);
            komut.Parameters.AddWithValue("@p2", textSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", textSifre.Text);
            komut.Parameters.AddWithValue("@p5", mskTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();

        }
    }
}
