using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders8Konsol3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TuretilenSinif tSinif = new TuretilenSinif();
            tSinif.metot1();
            tSinif.metot2();
        }
    }
    abstract class TemelSinif
    {
        public void metot1()
        {
            Console.WriteLine("Temel sinifin metot1 calisti");
        }
        public abstract void metot2();
    }
    class TuretilenSinif : TemelSinif
    {
        public override void metot2()
        {
            Console.WriteLine("Turetilmis sinifftan temel sinifin soyut metot2 calisti ");
        }
    }
    class ZehraBahoyaAsik : TemelSinif
    {
        public override void metot2()
        {
            Console.WriteLine("Turetilmis sinifftan temel sinifin soyut metot2 calisti ");
        }
    }
}



