using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Ders_55___Access_Veri_Tabanı_Kitaplık_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Reena\Desktop\Kitaplik.mdb");

        void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From Kitaplar",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void temizle()
        {
            txtAd.Clear();
            txtKitapid.Clear();
            txtSayfa.Clear();
            txtYazar.Clear();
            cmbTur.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        string durum = "";

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Kitaplar (KitapAd,Yazar,Tur,Sayfa,Durum) values (@1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYazar.Text);
            komut.Parameters.AddWithValue("@p3", cmbTur.Text);
            komut.Parameters.AddWithValue("@p4", txtSayfa.Text);
            komut.Parameters.AddWithValue("@p5", durum);
            komut.ExecuteReader();
            baglanti.Close();
            MessageBox.Show("Kitap Sisteme Kayıt Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtKitapid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cmbTur.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString()=="True")
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Delete from Kitaplar where Kitapid=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Silindi.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Update Kitaplar set KitapAd=@p1, Yazar=@p2, Tur=@p3, Sayfa=@p4, Durum=@5 where Kitapid=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYazar.Text);
            komut.Parameters.AddWithValue("@p3", cmbTur.Text);
            komut.Parameters.AddWithValue("@p4", txtSayfa.Text);
            if (radioButton1.Checked==true)
            {
                komut.Parameters.AddWithValue("@p5", durum);
            }
            if (radioButton2.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", durum);
            }
            komut.Parameters.AddWithValue("@p6", txtKitapid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Kitaplar where KitapAd=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtbul.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Kitaplar where KitapAd like '%"+txtbul.Text + "%'", baglanti);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void txtbul_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Kitaplar where KitapAd like '%" + txtbul.Text + "%'", baglanti);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}


