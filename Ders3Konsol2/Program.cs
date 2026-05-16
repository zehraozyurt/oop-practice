using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ders3Konsol2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Birinci sayiyi giriniz : ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("İkinci sayiyi giriniz: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                int sonuc = sayi1 + sayi2;
                Console.WriteLine("Sonuc: " + sonuc);
            }

            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}
