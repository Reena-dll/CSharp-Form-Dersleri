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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tc;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            labelTc.Text = tc;

            // Ad Soyad

            SqlCommand komut1 = new SqlCommand("Select DoktorAd, DoktorSoyad from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", labelTc.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                labelAdSoyad.Text = dr[0] + " " + dr[1];

            }

            // Randevular

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuDoktor='"+labelAdSoyad.Text+"' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle fr = new FrmDoktorBilgiDuzenle();
            fr.TCNO = labelTc.Text;
            fr.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
