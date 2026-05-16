using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Geriye değer döndüren 2 sayının toplamını veren parametreli methodu yazınız
namespace Ders4Konsol2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. VE 2. SAYİYİ GİRİNİZ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("TOPLAM= "+topla(sayi1 , sayi2)) ;

        }
        static int topla(int sayi1 ,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
           }
    }
}
