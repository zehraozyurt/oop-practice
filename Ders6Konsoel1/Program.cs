using System;
using Encapsulation3;
using ClassLibrary1;

namespace Encapsulation1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kapsulleme k1 = new Kapsulleme();
            Kapsulleme3 k2 = new Kapsulleme3();
            Class1 k3 = new Class1();

            Console.WriteLine(k1.number1);
            Console.WriteLine(k2.number3);
            Console.WriteLine(k1.number4);
            Console.WriteLine(k2.number1);
            Console.WriteLine(k3.number1);
            Console.WriteLine(k3.number3);
            Console.WriteLine(k3.number4);

        }
    }
}
namespace Encapsulation3
{
    public class Kapsulleme3
    {
        public int number1=5;
        protected int number2 = 10;
        protected internal int number3 = 15;
        internal int number4 = 20;
        private protected int number5 = 25;
        private int number6 = 30;
    }
}