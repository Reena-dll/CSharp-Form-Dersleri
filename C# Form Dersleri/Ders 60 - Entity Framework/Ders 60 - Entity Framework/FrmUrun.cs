using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_60___Entity_Framework
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();

        void listele()
        {
            dataGridView1.DataSource = (from x in db.Tbl_Urun
                                        select new
                                        {
                                            x.UrunId,
                                            x.UrunAd,
                                            x.Marka,
                                            x.Stok,
                                            x.Fiyat,
                                            x.Durum,
                                            x.Tbl_Kategori.AD

                                        }).ToList();

        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Tbl_Urun u = new Tbl_Urun();
            u.UrunAd = txtUrunAd.Text;
            u.Marka = txtMarka.Text;
            u.Stok = byte.Parse(txtStokSayı.Text);
            u.Fiyat = decimal.Parse(txtFiyat.Text);
            u.Kategori = int.Parse(comboBox1.SelectedValue.ToString());
            u.Durum = true;
            db.Tbl_Urun.Add(u);
            db.SaveChanges();
            MessageBox.Show("Ürün Sisteme Kayıt Edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var urun = db.Tbl_Urun.Find(Convert.ToInt32(txtId.Text));
            db.Tbl_Urun.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUrunAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMarka.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtStokSayı.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var urun = db.Tbl_Urun.Find(Convert.ToInt32(txtId.Text));
            urun.UrunAd = txtUrunAd.Text;
            urun.Stok = byte.Parse(txtStokSayı.Text);
            urun.Marka = txtMarka.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.Tbl_Kategori
                               select new
                               {
                                   x.ID,
                                   x.AD

                               }).ToList();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "AD";
            comboBox1.DataSource = kategoriler;
        }
    }
}
