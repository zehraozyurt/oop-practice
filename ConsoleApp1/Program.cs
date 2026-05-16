using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eBS = enBuyukSayi(9, 1, 1453, -8, 68, 222, 5710);
            Console.WriteLine("En büyük sayı: " + eBS);
        }

        static int enBuyukSayi(params int[] sayilar)
        {
            int enBuyukSayi = 0;

            if (sayilar.Length>0)
            {
                enBuyukSayi = sayilar[0];
            }

            foreach (int sayi in sayilar)
            {
                if ( enBuyukSayi<sayi)
                {
                    enBuyukSayi = sayi;  
                }
            }
            return enBuyukSayi;

        }
    }
}
