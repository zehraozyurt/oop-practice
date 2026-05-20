using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7Konsol6
{
    class Ev
    {
        private string il;
        private string ilce;
        private string mahalle;
        private int alan;
        private int oda;
        private int kat;

        public string Il { get { return il; } set { il = value; } }
        public string Ilce { get { return ilce; } set { ilce = value; } }
        public string Mahalle { get { return mahalle; } set { mahalle = value;  } }
        public int Alan { get { return alan; } set { alan = value; } }
        public int Oda { get { return oda; } set { oda = value; } }
        public int Kat { get { return kat; } set { kat = value; } }

    }
    class KiralikEv :Ev
    {
        public void kiralikEvYazdir()
        {
            Console.WriteLine("Kiralık Ev Bilgileri : \nİl: {0}\nİlçe: {1}\nMahalle: {2}\nAlan: {3}\nOda: {4}\nKat: {5}\n", Il, Ilce, Mahalle, Alan, Oda, Kat);
        }
    }
    class SatilikEv : Ev
    {
        public void satilikEvYazdir() 
        {
        Console.WriteLine("Satılık Ev Bilgileri : \nİl: {0}\nİlçe: {1}\nMahalle: {2}\nAlan: {3}\nOda: {4}\nKat: {5}\n", Il, Ilce, Mahalle, Alan, Oda, Kat);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            KiralikEv kEv = new KiralikEv();
            SatilikEv sEv = new SatilikEv();    
            kEv.Il = "Ankara";
            kEv.Ilce = "Çankaya";
            kEv.Mahalle= "Çukurambar";
            kEv.Alan = 120; 
            kEv.Oda = 3;    
            kEv.Kat = 5;
            kEv.kiralikEvYazdir();

            sEv.Il = "Zonguldak";
            sEv.Ilce = "Merkez";
            sEv.Mahalle = "İncivez";
            sEv.Alan = 150;
            sEv.Oda = 3;
            sEv.Kat = 2;
            sEv.satilikEvYazdir();
        }

    }
}
