using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5Konsol
{
    internal class Program
    {
        class Insan
        {
            internal string isim;
            public int yas;
            internal protected double boy;
        }
             
        static void Main(string[] args)
        {
            Insan kisi = new Insan();
            kisi.boy = 1.70;
            kisi.yas = 37;
            kisi.isim = "Erkek";

            Console.WriteLine(kisi.isim);
            Console.WriteLine(kisi.yas);
            Console.WriteLine(kisi.boy);
        }
    }


}
