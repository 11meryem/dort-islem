using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace button._43
{
    internal class Islemler
    {
        public double topla;
        public double cikar;
        public double carp;
        public double bol;

        public double sayi1;
        public double sayi2;

        public double Toplama()
        {
            return sayi1 + sayi2;
        }

        public double Cikarma()
        {
            return sayi1 - sayi2;
        }

        public double Carpma()
        {
            return sayi1 * sayi2;
        }

        public double Bolme ()
        {
            return sayi1 % sayi2;
        }
    }
}
