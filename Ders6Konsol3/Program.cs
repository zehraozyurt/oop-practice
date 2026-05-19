using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders6Konsol3
{
    public class Program2
    {
        private string ad;
        private string soyad;
        private int ogrNo;
        private string sehir;
        private int yil;
        private int tcNo;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public int OgrNo
        {
            get { return ogrNo; }
            set { ogrNo = value; }
        }

        public string Sehir { get; set; }

        public int Yil { get => yil; set => yil = value; }

        public int TcNo { get; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            Program2 prg = new Program2();

            prg.Ad = "Ozan";
            prg.Soyad = "Artun";
            prg.OgrNo = 215652;
            prg.Sehir = "Zonguldak";
            prg.Yil = 2025;

            Console.WriteLine(prg.Ad + " " + prg.Soyad + " " + prg.OgrNo);
            Console.WriteLine(prg.Ad + " "+ prg.Soyad + " " + prg.OgrNo+" "+prg.Sehir);
            Console.WriteLine(prg.Ad + " "+ prg.Soyad + " " + prg.OgrNo+" "+prg.Sehir+" "+prg.Yil);
            Console.WriteLine(prg.Ad + " "+ prg.Soyad + " " + prg.OgrNo+" "+prg.Sehir+" "+prg.Yil+" "+prg.TcNo);
        }
    }
}
