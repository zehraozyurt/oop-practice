using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders8Konsol6
{
     abstract class Canli
    {
        public Canli() {
            Console.WriteLine("Canli soyut sinifinin constructorı cagrildi");
        }
    }
     class Insan : Canli
    {
        public Insan()
        {
            Console.WriteLine("Insan sinifinin constructorı cagrildi");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Insan insan = new Insan();
            
        }
    }
}
