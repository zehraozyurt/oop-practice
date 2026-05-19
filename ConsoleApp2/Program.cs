using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulation2;
using Encapsulation3;

namespace Encapsulation1
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Kapsulleme k1 = new Kapsulleme();
            Kapsulleme3 k3 = new Kapsulleme3();
            Kapsulleme2 k2 = new Kapsulleme2();

            Console.WriteLine(k1.number1);
            Console.WriteLine(k1.number3);
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
        public int number1 = 5;
        protected int number2 = 10;
        protected internal int number3 = 15;
        internal int number4 = 20;
        private protected int number5 = 25;
        private int number6 = 30;
    }
}


/*NoKapsul noKapsul = new NoKapsul();
          noKapsul.TcNoAta(1234);

          Console.WriteLine("-------------------------");
          Console.WriteLine(noKapsul.TcNoGoster());
          Console.WriteLine("-------------------------");*/