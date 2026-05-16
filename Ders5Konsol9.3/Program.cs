using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5Konsol9._3
{
    internal class Program
    {
        public static int value1 = 5;
        int value2 = 10;
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Program p2 = new Program();

            p1.value2 = 15;
            p2.value2 = 20;

            Console.WriteLine("value 1 : " + value1);
            Console.WriteLine("value 2 : " + p1.value2);
            Console.WriteLine("value 2 : " + p2.value2);
        }
    }
}
