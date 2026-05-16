using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5Konsol2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Wrod");
            Human person = new Human();
            person.height = 1.70;
            person.age = 37;
            person.gender = "Male";

            Console.WriteLine(person.gender);
            Console.WriteLine(person.age);
            Console.WriteLine(person.height);
        }
    }
}

namespace Ders5Konsol2
{
    internal class Human
    {
        public double height;
        public string gender;
        public int age;
    }
}
