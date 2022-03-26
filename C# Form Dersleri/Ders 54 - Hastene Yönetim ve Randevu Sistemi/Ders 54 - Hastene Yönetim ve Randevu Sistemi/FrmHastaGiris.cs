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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        private void lnkUye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr = new FrmHastaKayit();
            fr.Show();

        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnGirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("@p2", textSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc = mskTc.Text;
                fr.Show();
                this.Hide();
            } 
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textSifre.Clear();
                mskTc.Clear();
            }
            bgl.baglanti().Close();

        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {
            mskTc.Focus();
        }
    }
}
