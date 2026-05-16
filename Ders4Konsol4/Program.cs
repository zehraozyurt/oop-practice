using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders4Konsol4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faktöryeli alinacak sayiyi giriniz");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Faktöryeli alınacak sayi = {0} ve faktöryeli = {1} ", sayi, hesapla(sayi));
        }
        static int hesapla(int sayi)
        {
            if (sayi==1)
            {
                return 1;
            }
            else
            {
                return sayi * hesapla(sayi - 1);
            }
        }
    }
}
