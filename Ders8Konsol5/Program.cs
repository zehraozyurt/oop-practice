using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders8Konsol5
{
    abstract class Hayvan
    {
        protected string ad;
        protected int yas;

        public abstract string Ad { get; set; }
        public virtual int Yas { get; set; }

    }
    class Kopek : Hayvan
    {
        public override string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public override int Yas 
        { 
            get { return yas; } 
            set { yas = value; } 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kopek kopek =new Kopek();
            kopek.Ad = "Tom";
            kopek.Yas = 2;
            Console.WriteLine(kopek.Ad + "\n" + kopek.Yas);
        }
    }
}
