using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ders5Konsol8
{
    class Cars
    {
        public int year;

        public Cars(int year)
        {
            this.year = year;
            Console.WriteLine(year + "Yili Constructor ile üretildi");
        }
        ~Cars()
        {
            Console.WriteLine(year + "Yili Destructor ile silindi");
        }
        static void Main(string[] args)
        {
                for (int i = 2010; i <= 2025; i++)
                {
                    new Cars(i);
                }
                GC.Collect();
        
        }
    }
}
