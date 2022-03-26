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

namespace Ders_59___İlişkili_Sql_Tabloları_EOkul_projesi
{
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=BonusOkul;Integrated Security=True");
        public string numara;
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select DersAd,Sinav1,Sinav2,Sinav3,Proje,Ortalama,Durum from Tbl_Notlar inner join Tbl_Dersler ON Tbl_Notlar.DersId=Tbl_Dersler.DersId where OgrId=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            //this.Text = numara.ToString();
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;


            // Öğrenci ismi çekme
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select OgrAd,OgrSoyad from Tbl_Ogrenciler where OgrId=" + numara + " ", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                this.Text = dr2[0] + " " + dr2[1];
            }
            baglanti.Close();
        }

    }
}
