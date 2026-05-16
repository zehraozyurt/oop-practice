using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders4Konsol1
{
    internal class Program
    {
        //İki sayının toplamını ekrana yazdıran programı statik ve void metod ile parametreli ve paremetresiz olarka yapınız
        static void Main(string[] args)
        {
            topla(10,2);
            topla();

        }
        static void topla(int sayi1,int sayi2)
        {
            int topla=sayi1 + sayi2;
            Console.WriteLine("Toplam : " + topla);
        }
        static  void topla()
        {
            int sayi1, sayi2, toplam;
            Console.WriteLine("Sayi1 ve sayi2 yi giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            sayi2 = int.Parse(Console.ReadLine());
            toplam = sayi1 + sayi2;
            Console.WriteLine("Birinci sayimiz : {0} ve ikinci sayimiz : {1} ise toplami = {2}", sayi1, sayi2, toplam);
        }
    }
}
