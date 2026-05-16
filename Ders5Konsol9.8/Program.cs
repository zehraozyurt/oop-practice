using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5Konsol9._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int refDeger = 10;
            int outDeger;
            degistirMetot(out outDeger, ref refDeger);

            Console.WriteLine("degistirMetot den sonraki değerimiz" +outDeger);
            Console.WriteLine("degistirMetot den sonraki değerimiz" +refDeger);



        }
        static void degistirMetot(out int x, ref int y)
        {
            x = 9;
            y = x + y + 3;
        }
    }
}
