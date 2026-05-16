using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5Konsol9._4
{
    internal class Program
    {
        int x = 5;//global degisken
        static void Main(string[] args)
        {
            int a = 10;//local degisken
            Console.WriteLine(a);
            Program p1 = new Program();
            p1.x = 20;
            // p1.a = 30;
            change(a);
            Console.WriteLine(a);
            change(p1.x);
            Console.WriteLine(p1.x);
        }
        static void change(int a)
        {
            a = a + 50;
            Console.WriteLine("change metodu içindeki a : " + a);
        }
    }

}
