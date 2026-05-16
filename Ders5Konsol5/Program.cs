using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ders5Konsol5
{
    internal class Program
    {
        class Cars
        {
            public string model;
            public Cars() 
            {
                model = "Togg";
            }   
        }
        static void Main(string[] args)
        {
            Cars cars= new Cars();
            Console.WriteLine(cars.model);
        }
    }
}
