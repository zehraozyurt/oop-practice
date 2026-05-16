using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5Konsol9._5
{
     class Constructors
    {
        void metod1()
        {
            Console.WriteLine("Non-parameter");
        }
        void metod2(int number1)
        {
            Console.WriteLine("Number1: " + number1);
        }
        public Constructors()
        {
           metod1();
        }
        public Constructors(int number2)
        {
            metod2(number2);
        }
        static void Main(string[] args)
        {
                Constructors object1 = new Constructors();
                Constructors object2 = new Constructors(50);
        }
    }
}
