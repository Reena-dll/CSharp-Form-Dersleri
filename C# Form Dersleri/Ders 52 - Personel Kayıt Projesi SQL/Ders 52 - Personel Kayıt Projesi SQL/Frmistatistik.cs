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
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void Frmistatistik_Load(object sender, EventArgs e)
        {
            // Toplam Personel Sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select count(*) from Tbl_Personel", baglanti);
            // SqlDataReader Veri okuyucu. 
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())// dr1 işlemi okuma işlemi yaptığı kadar şu işlemleri yap.
            {
                labeltoplampersonel.Text = dr1[0].ToString();
            }

            baglanti.Close();
            // Evli Personel Sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select count(*) from Tbl_Personel where PerDurum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                labelevli.Text = dr2[0].ToString();
            }

            baglanti.Close();

            // Bekar Personel Sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) from Tbl_Personel where PerDurum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                labelbekar.Text = dr3[0].ToString();
            }
            baglanti.Close();

            //Şehir Sayısı

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select count(distinct(PerSehir)) from Tbl_Personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                labelsehirsayi.Text = dr4[0].ToString();
            }
            baglanti.Close();

            // Toplam Maaş

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(PerMaas) from Tbl_Personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                labeltoplammaas.Text = dr5[0].ToString();
            }
            baglanti.Close();

            // Ortalama Maaş

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select avg(PerMaas) from Tbl_Personel",baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                labelortalamamaas.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }

    }
}
