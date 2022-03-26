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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tbl_Admin k = db.Tbl_Admin.Where(x => x.Kullanici == textBox1.Text && x.Sifre == textBox2.Text).SingleOrDefault();

            if (k==null)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox2.Clear();
            }

            if (k!=null)
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
        }
    }
}
