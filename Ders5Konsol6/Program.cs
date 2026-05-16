using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5Konsol6
{
    class Deneme 
    {
        public int x;
        public Deneme(int x)
        {
            this.x = x;
        }
        static void Main(string[] args)
        {
            Deneme dene = new Deneme(60);
            Console.WriteLine(dene.x);
        }
    }
}
