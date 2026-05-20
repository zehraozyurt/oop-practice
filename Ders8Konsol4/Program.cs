using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders8Konsol4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();
            IkinciElAraba ıkinciElAraba=new IkinciElAraba();

            Console.WriteLine(araba.Fiyat());
            Console.WriteLine(ıkinciElAraba.Fiyat());
        }
    }
    public class Araba
    {
       public decimal fiyati = 500; 
       public virtual decimal Fiyat()
        {
            return fiyati + 200;  
        }
    } 
    public class IkinciElAraba :Araba 
    {
        public override decimal Fiyat()
        {
            return fiyati - 100;
        }
    } 
}
