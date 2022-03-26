using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_36___Sınıf_içerisinde_geri_döndürmeyen_metot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mesaj msj = new Mesaj();
            //msj.metin();

            Kisiler ks = new Kisiler();
            string ads;
            Console.Write("İsim Girin: ");
            ads = Console.ReadLine();
            ks.kisilistesi(ads);
            Console.Read();
        }
    }
}
