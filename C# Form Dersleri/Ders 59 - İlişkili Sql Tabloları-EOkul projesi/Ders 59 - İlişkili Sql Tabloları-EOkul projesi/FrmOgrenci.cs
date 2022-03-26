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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=BonusOkul;Integrated Security=True");
        void Listele()
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Red;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        DataTable dt = new DataTable();
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            Listele();
            

            SqlCommand komut = new SqlCommand("Select * From Tbl_Kulupler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
           // DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "KulupAd";
            comboBox1.ValueMember = "KulupId";
            comboBox1.DataSource = dt;
        }

        string c = "";
        private void BtnEkle_Click(object sender, EventArgs e)
        {
           
            if (radioButton1.Checked ==true)
            {
                c = "Kız";
            }
            if (radioButton2.Checked == true)
            {
                c = "Erkek";
            }

            ds.OgrenciEkle(txtAd.Text, txtSoyad.Text, byte.Parse(comboBox1.SelectedValue.ToString()),c);
            MessageBox.Show("Öğrenci Ekleme Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()=="Kız")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "Erkek")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
         
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(txtId.Text));
            MessageBox.Show("Öğrenci Silme Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                c = "Kız";
            }
            if (radioButton2.Checked == true)
            {
                c = "Erkek";
            }
            ds.OgrGuncelle(txtAd.Text, txtSoyad.Text, byte.Parse(comboBox1.SelectedValue.ToString()), c, int.Parse(txtId.Text));
            MessageBox.Show("Öğrenci Güncellemesi Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FrmOgretmen fr = new FrmOgretmen();
            fr.Show();
            this.Hide();
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Green;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Transparent;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = ds.OgrenciListesi().DefaultView;
            dv.RowFilter = "isim Like '" + txtAra.Text + "%'";     
            dataGridView1.DataSource = dv;
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
