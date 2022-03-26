using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_37___Sınıf_içerisinde_geriye_değer_döndüren
{
    class Program
    {
        static void Main(string[] args)
        {
            islem isl = new islem();

            isl.topla(7,6);
            isl.topla(4, 5);

            isl.kare(2);
            isl.kare(6);
            Console.Read();

            
        }
    }
}
