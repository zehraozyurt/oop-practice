using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5Konsol9
{
    internal class Program
    {
        static int orjDeger = 10;
        static void Main(string[] args)
        {
            Console.WriteLine("Orjinal degerimiz: " + orjDeger);
            degistirMetot(2, 3, orjDeger);
            Console.WriteLine("DegistirMetoodundan sonraki degerimiz : " + orjDeger);
        }
        static void degistirMetot(int x, int y,int z)
        {
            orjDeger=x+y+z;
        }
    }
}
