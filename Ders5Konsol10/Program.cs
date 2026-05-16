using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5Konsol10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orjDeger = 10;
            Console.WriteLine("Orjin degerimiz : " + orjDeger);
            degistirMetot(2, 3, ref orjDeger);
            Console.WriteLine("degistirMetot'dan sonraki değer : " + orjDeger);
        }
        static void degistirMetot(int x , int y, ref int z)
        {
            z = x + y + z;
        }
    }
}
