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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();

        void listele()
        {
            var kategoriler = db.Tbl_Kategori.ToList();
            dataGridView1.DataSource = kategoriler;

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tbl_Kategori t = new Tbl_Kategori();
            t.AD = textBox2.Text;
            db.Tbl_Kategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int x = Convert.ToInt32(textBox1.Text);
            //var ktg = db.Tbl_Kategori.Find(x);
            //db.Tbl_Kategori.Remove(ktg);
            //db.SaveChanges();
            //MessageBox.Show("Kategori Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //listele();

            var ktg = db.Tbl_Kategori.Find(Convert.ToInt32(textBox1.Text));
            db.Tbl_Kategori.Remove(ktg);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var ktg = db.Tbl_Kategori.Find(Convert.ToInt32(textBox1.Text));
            ktg.AD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
