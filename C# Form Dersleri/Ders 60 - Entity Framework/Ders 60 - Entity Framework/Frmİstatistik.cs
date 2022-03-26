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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.Tbl_Kategori.Count().ToString(); // Toplam Kategori Sayısı
            label3.Text = db.Tbl_Urun.Count().ToString(); // Toplam Ürün Sayısı
            label5.Text = db.Tbl_Musteri.Count(x => x.Durum == true).ToString(); // Aktif Müşteri Sayısı
            label7.Text = db.Tbl_Musteri.Count(x => x.Durum == false).ToString(); // Pasif Müşteri Sayısı
            label15.Text = db.Tbl_Urun.Count(x => x.Kategori == 0).ToString();
            label13.Text = db.Tbl_Urun.Sum(x => x.Stok).ToString(); // Stok sayısı
            label11.Text = (from x in db.Tbl_Urun orderby x.Fiyat descending select x.UrunAd).FirstOrDefault(); // En Yüksek Fiyatlı Ürün
            label9.Text = (from x in db.Tbl_Urun orderby x.Fiyat ascending select x.UrunAd).FirstOrDefault(); // En Düşük Fiyatlı Ürün          
            label15.Text = db.Tbl_Urun.Count(x => x.Kategori == 1).ToString(); // Toplam Beyaz Eşya sayısı
            label21.Text = db.Tbl_Satis.Sum(x => x.Fiyat).ToString() + " TL"; // Kasa da ki Tutar
            label17.Text = db.Tbl_Urun.Count(x => x.UrunAd == "Buzdolabı").ToString(); // Toplam Buzdolabı Sayısı
            label23.Text = (from x in db.Tbl_Musteri select x.Sehir).Distinct().Count().ToString(); // Distinct: Tekrar eden verileri tekrar etmeden saydırmamızı yarıyor. Şehir Sayısı
            label19.Text = db.MarkaGetir().FirstOrDefault();
        }
    }
}
