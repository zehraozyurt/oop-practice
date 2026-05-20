using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders8Konsol7
{
    public abstract class Banka
    {
        public abstract double faizOrani(double anapara);
    }
    public class Abankasi : Banka
    {
        public override double faizOrani(double anapara)
        {
            return 0.15 * anapara;
        }
    }
    public class Bbankasi : Banka
    {
        public override double faizOrani(double anapara)
        {
            return 0.15 * anapara;
        }
    }
    public class Cbankasi : Banka
    {
        public override double faizOrani(double anapara)
        {
            return 0.20 * anapara;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Abankasi aBank = new Abankasi();
            Cbankasi cBank = new Cbankasi();

            Console.WriteLine(aBank.faizOrani(500000));
            Console.WriteLine(cBank.faizOrani(500000));

        }
    }
}
