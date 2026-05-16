using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders4Konsol3
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
            int sonuc = 1;
            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }

    }
}
