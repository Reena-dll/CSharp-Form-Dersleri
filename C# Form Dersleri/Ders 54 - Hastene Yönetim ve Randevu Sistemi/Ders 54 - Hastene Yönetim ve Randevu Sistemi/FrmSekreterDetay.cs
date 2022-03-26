using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ders_54___Hastene_Yönetim_ve_Randevu_Sistemi
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string tc;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            labelTc.Text = tc;

            // AD SOYAD
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", labelTc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            if (dr1.Read())
            {
                labelAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            // Branşları Datagrid'e aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BransAd as Branş From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            // Doktorları Datagrid'e Aktarma

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd+' '+DoktorSoyad) as Doktorlar , DoktorBrans as Branş from Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            // COmbobax'a branş getirme
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            // Combobax'a doktor getirme

           
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevünüz Kayıt Edildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            cmbDoktor.Text = "";
            SqlCommand komut = new SqlCommand("Select (DoktorAd+' '+DoktorSoyad) from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Kayıt Edildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            rchDuyuru.Text = "";
        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fr = new FrmDoktorPaneli();
            fr.Show();
        }

        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBransPaneli fr = new FrmBransPaneli();
            fr.Show();
        }

        private void BtnRandevuListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr = new FrmRandevuListesi();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }
    }
}
