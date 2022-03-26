using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_38___Constructor___YAPICI__
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.Write("Bilgi giriniz: ");
            //    string blg = Console.ReadLine();
            //    Ogrenci ogr = new Ogrenci(blg);
            Kimlik kml = new Kimlik();
            kml.AD = "Oğuzhan";
            kml.SOYAD = " Sadıkoğlu";
            kml.MEMLEKET = "Rize";
            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CİNSİYET);

            Console.Read();
        }
    }
}
