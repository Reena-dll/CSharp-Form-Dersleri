using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Ders_35___Kapsülleme
{
    class Araba
    {
        public string renk;
        public int hiz;
        public double motor;
        public char durum;
        public int fiyat;
        private int yil;
        private string marka;

        public int YIL
        {
            get { return yil; }
            set { yil = Math.Abs(value); }
        }

        public string MARKASI
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }
    }
}
