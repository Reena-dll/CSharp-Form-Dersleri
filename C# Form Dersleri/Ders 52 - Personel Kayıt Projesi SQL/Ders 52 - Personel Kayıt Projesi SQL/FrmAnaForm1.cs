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
    public partial class FrmAnaForm1 : Form
    {
        public FrmAnaForm1()
        {
            InitializeComponent();
        }


        void Listele()
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet2.Tbl_Personel);
        }

        void Temizle()
        {
            TxTid.Clear();
            TxtAd.Clear();
            TxtSoyad.Clear();
            TxtMeslek.Clear();
            mskMaas.Clear();
            cmbSehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            TxtAd.Focus();

        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

            Listele();
            label8.Visible = false;
            
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,Permeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", mskMaas.Text);
            komut.Parameters.AddWithValue("@p5", TxtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();  // Tablo da bir veri değişikliği olduğunda ExecuteNonQuery'i kullanılır. Update delete güncelleme gibi işlemlerlde kullanılır.
            baglanti.Close();
            MessageBox.Show("Personel Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            Listele();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            TxTid.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilendeger].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[secilendeger].Cells[3].Value.ToString();
            mskMaas.Text = dataGridView1.Rows[secilendeger].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilendeger].Cells[5].Value.ToString();
            TxtMeslek.Text = dataGridView1.Rows[secilendeger].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            else if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel where PerID=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", TxTid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@a1, PerSoyad=@a2, PerSehir = @a3, PerMaas=@a4, PerDurum=@a5,PerMeslek = @a6 where PerID=@a7", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", TxtAd.Text);
            komutguncelle.Parameters.AddWithValue("@a2", TxtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", cmbSehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", mskMaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", TxtMeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", TxTid.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Bilgi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void Btnİstatistik_Click(object sender, EventArgs e)
        {
            Frmistatistik fr = new Frmistatistik();
            fr.Show();
        }

        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frg = new FrmGrafikler();
            frg.Show();
        }
    }
}


