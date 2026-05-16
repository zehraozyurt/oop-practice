using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Metodlara aşırı yükleme (overloading) kavramını açıklayınız ve örnek kod yazınız
namespace Ders4Konsol5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adınızı ve Soyadınızı giriniz : ");
            string adSoyad = Console.ReadLine();
            Console.WriteLine("yasınızı giriniz : ");
            int yas = int.Parse(Console.ReadLine());    
            Console.WriteLine("Boyunuzu metre olarak giriniz : ");
            int boy = int.Parse(Console.ReadLine());

            Console.WriteLine("Kisiye ait bilgiler : {0} , {1} , {2} ", Method(adSoyad), Method(yas), Method(boy));

            Console.WriteLine("Tc no giriniz : ");
            double tcNo = double.Parse(Console.ReadLine());
            Method(adSoyad, yas, boy, tcNo);

        }
        static string Method(string x)
        {
            return x;
        }
        static int Method(int y)
        {
            return y;
        }
        static double Method(double z)
        {
            return z;
        } 
        static void Method(string a,int b, double c, double d)
        {
            Console.WriteLine("Kisiye ait bilgiler : {0} , {1} , {2} , {3} ", a, b, c, d);
        }
    }
}
