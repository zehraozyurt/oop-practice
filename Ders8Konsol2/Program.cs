using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders8Konsol2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.hayvanSesleri();
        }
    }
     abstract class Hayvan
    {
        public abstract void hayvanSesleri();
        public void uyku()
        {
            Console.WriteLine("zzz!");
        }
    }
     class Kedi : Hayvan
    {
        public override void hayvanSesleri()
        {
            Console.WriteLine("miyav !");
        }
    } 
}


