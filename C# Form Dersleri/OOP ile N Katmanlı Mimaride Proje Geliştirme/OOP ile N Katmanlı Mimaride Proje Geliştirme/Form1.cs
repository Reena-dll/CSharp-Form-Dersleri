using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using LogicLayer;
using DataAccessLayer;

namespace OOP_ile_N_Katmanlı_Mimaride_Proje_Geliştirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = txtAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Sehir = txtSehir.Text;
            ent.Gorev = txtGorev.Text;
            ent.Maas = short.Parse(txtMaas.Text);
            LogicPersonel.LLPersonelEkle(ent);
        }
    }
}
