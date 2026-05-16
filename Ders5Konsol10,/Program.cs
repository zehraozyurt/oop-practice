using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5Konsol10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orjDeger ;
            degistirMetot(2, 3, out orjDeger);
            Console.WriteLine("degistirMetot'dan sonraki değer : " + orjDeger);
       
        }
        static void degistirMetot(int x, int y, out int z)
        {
            z = 11;
            z = x + y+ z;
        }
    }
}
