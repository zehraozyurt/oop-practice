using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5Konsol3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lutfen 1. sayiyi giriniz");
            double sayi1 =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lutfen 2. sayiyi giriniz");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Calculation cal = new Calculation();

            Console.WriteLine("Carpım : {0}", cal.multiplication(sayi1, sayi2));
            Console.WriteLine("Cikarma : {0}", cal.extraction(sayi1, sayi2));  
            Console.WriteLine("Toplama : {0}", Calculation.additions(sayi1,sayi2));

        }
    }

    class Calculation
    {
        public double multiplication(double number1, double number2 )
        {
            return number1 * number2;   
        }

        public double extraction(double number1, double number2)
        {
            return number2 - number1;
        }

        public static double additions(double number1,double number2)
        {
            return number1 + number2; 
        }
    }

}
