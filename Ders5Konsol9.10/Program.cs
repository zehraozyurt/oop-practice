using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5Konsol9._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sayiToplama(1, 8, 6);
            sayiToplama(1, 3);
            sayiToplama(5);
        }

        static void sayiToplama(params int[] sayilar)
        {
            Console.WriteLine("Params metodu çağrıldı");

        }
        static void sayiToplama(int x, int y, int z)
        {
            Console.WriteLine("3 Pareömetreli normal metot cagrildi");

        }           
        static void sayiToplama(int x , int y)
        {
            Console.WriteLine("2 parametreli normal metot çagrildi");
        }
    }

}
