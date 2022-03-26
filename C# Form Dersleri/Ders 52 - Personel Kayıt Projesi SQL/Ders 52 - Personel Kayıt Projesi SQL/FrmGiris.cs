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

namespace Ders_52___Personel_Kayıt_Projesi_SQL
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void btnGirisyap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yonetici where KullaniciAd=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKullaniciad.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaForm1 frm = new FrmAnaForm1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            txtKullaniciad.Clear();
            txtsifre.Clear();
            baglanti.Close();

        }
    }
}
