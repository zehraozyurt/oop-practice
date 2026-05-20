using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7Konsol8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassB cb = new ClassB();
            cb.values(8, 4);
            Console.WriteLine(cb.addition());
            //Console.WriteLine(cb.name);
        }
    }
}
namespace Ders7Konsol8
{
    internal class  ClassA
    {
        protected int a, b;
        protected string name = "Ozan";

        public void values(int x, int y)
        {
            a = x;
            b = y;
        }
        
    }

}
namespace Ders7Konsol8
{
    internal class ClassB : ClassA
    {
        public int addition()
        {
            return a + b;
        }
    }
}