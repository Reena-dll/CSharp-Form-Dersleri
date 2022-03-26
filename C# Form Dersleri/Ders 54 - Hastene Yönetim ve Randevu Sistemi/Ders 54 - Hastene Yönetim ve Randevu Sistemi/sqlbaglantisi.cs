using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ders_54___Hastene_Yönetim_ve_Randevu_Sistemi
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=localhost;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
