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
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=BonusOkul;Integrated Security=True");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Kulupler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmKulup_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_Kulupler (KulupAd) values (@p1)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtKulupAd.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kulüp Listeye Eklenti", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                txtKulupAd.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Yanlış Değerler Girdiniz");
                
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("Delete from Tbl_Kulupler where KulupId=@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", txtKulupId.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                listele();
                txtKulupAd.Clear();
                txtKulupId.Clear();
                MessageBox.Show("Kulüp Silindi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Yanlış Değerler Girdiniz");

            }
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Red;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtKulupId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtKulupAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update  Tbl_Kulupler set KulupAd=@p1 where KulupId=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", txtKulupAd.Text);
                komut.Parameters.AddWithValue("@p2", txtKulupId.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
                txtKulupAd.Clear();
                txtKulupId.Clear();
                MessageBox.Show("Güncelleme İşleminz Gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Yanlış Değerler Girdiniz");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            FrmOgretmen fr = new FrmOgretmen();
            fr.Show();
            this.Hide();
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Green;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Transparent;

        }
    }
}
