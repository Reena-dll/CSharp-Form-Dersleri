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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnGirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreter where SekreterTC=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("@p2", textSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmSekreterDetay fr = new FrmSekreterDetay();
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
    }
}
