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
    public partial class FrmSinavNotlar : Form
    {
        public FrmSinavNotlar()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.Tbl_NotlarTableAdapter ds = new DataSet1TableAdapters.Tbl_NotlarTableAdapter();
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=BonusOkul;Integrated Security=True");

        private void FrmSinavNotlar_Load(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select * From Tbl_Dersler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "DersAd";
            comboBox1.ValueMember = "DersId";
            comboBox1.DataSource = dt;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(txtId.Text));
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FrmOgretmen nw = new FrmOgretmen();
            nw.Show();
            this.Hide();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Red;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Green;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Transparent;
        }
        int notid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid =int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSinav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSinav2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSinav3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtProje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtOrtalama.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        int sinav1, sinav2, sinav3, proje;
        double ortalama;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
           
           // string durum;
            sinav1 = Convert.ToInt16(txtSinav1.Text);
            sinav2 = Convert.ToInt16(txtSinav2.Text);
            sinav3 = Convert.ToInt16(txtSinav3.Text);
            proje = Convert.ToInt16(txtProje.Text);
            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            txtOrtalama.Text = ortalama.ToString();
            if (ortalama>=50)
            {
                txtDurum.Text = "True";
            }
            else
            {
                txtDurum.Text = "False";
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(byte.Parse(comboBox1.SelectedValue.ToString()), int.Parse(txtId.Text), byte.Parse(txtSinav1.Text), byte.Parse(txtSinav2.Text), byte.Parse(txtSinav3.Text), byte.Parse(txtProje.Text), byte.Parse(txtOrtalama.Text), bool.Parse(txtDurum.Text), notid);
            
        }
    }
}
