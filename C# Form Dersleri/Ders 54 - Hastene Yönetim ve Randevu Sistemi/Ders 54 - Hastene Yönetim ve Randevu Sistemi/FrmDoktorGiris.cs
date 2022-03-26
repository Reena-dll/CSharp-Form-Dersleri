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
using System.Data.SqlTypes;

namespace Ders_54___Hastene_Yönetim_ve_Randevu_Sistemi
{
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnGirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTc=@p1 and DoktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("p2", textSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay fr = new FrmDoktorDetay();
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

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
