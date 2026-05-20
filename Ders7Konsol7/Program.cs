using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ders7Konsol7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class2 c2 = new Class2();
            c2.b = 60;
            c2.a = 45;
            Console.WriteLine(c2.a + c2.b);
            c2.method1();
            c2.method2();
        }
    }
}

namespace Ders7Konsol7
{
    internal class Class1
    {
        public int a;
        public void method1()
        {
            Console.WriteLine("Method1 is working");

        }

    }

}
namespace Ders7Konsol7
{
    internal class Class2:Class1
    {

        public int b;
        public void method2()
        {
            Console.WriteLine("Method2 is working");
        }

    }
}

