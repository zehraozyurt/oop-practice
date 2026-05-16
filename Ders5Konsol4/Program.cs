using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5Konsol4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars araba = new Cars();
        }
        class Cars
        {
            public Cars()
            {
                Console.WriteLine("Default constructor calistirildi");
            }
        }
    }
}
