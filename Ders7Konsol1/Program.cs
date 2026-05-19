using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7Konsol1
{
    internal class Calistir
    {
        static void Main(string[] args)
        {

            ElektrikliYarisArabasi eyA =new ElektrikliYarisArabasi();
            Arac arac = new Arac();
        }
    }


    internal class  Arac
    {
      public Arac()
        {
            Console.WriteLine("Arac sınıfının yapıcı metodu çalıştı");
        }

    }


    internal class  Araba:Arac  
    {
        public Araba()
        {
            Console.WriteLine("Araba sınıfının yapıcı metodu çalıştı");
        }
    }


    internal class  ElektrikliAraba:Araba
    {
        public ElektrikliAraba()
        {
            Console.WriteLine("YarisArabasi sınıfının yapıcı metodu çalıştı");
        }
    }


    internal class  ElektrikliYarisArabasi : ElektrikliAraba
    {
        public ElektrikliYarisArabasi()
        {
            Console.WriteLine("ElektrikliYarisArabasi sınıfının yapıcı metodu çalıştı");
        }
    }



}
