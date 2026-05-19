using Ders7Konsol3;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7Konsol3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Ogretmen ogrtmn = new Ogretmen();

            ogrtmn.ad= "Ahmet";



            Ogrenci ogrenci = new Ogrenci();

            ogrenci.ogretmen = ogrtmn;
        }
    }

    public class Ogrenci
    {
        public Ogretmen ogretmen;
    }

    public class Ogretmen 
    {
        public string ad;
    }
}
        
  




