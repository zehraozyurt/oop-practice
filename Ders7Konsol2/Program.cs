using Ders7Konsol2;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7Konsol2
{
    internal class Canli
    {
        private bool nefesAlmak;
        public bool NefesAlmak
        {
            get { return nefesAlmak; }
            set { nefesAlmak = value; }
        }

        static void Main(string[] args)
        {
            Canli canli = new Canli();
            canli.NefesAlmak = true;

            Hayvan hayvan = new Hayvan();
            hayvan.NefesAlmak = true;

            hayvan.Kol = 0;
            hayvan.Ayak = 4;
            hayvan.Konusmak = false;
            hayvan.Kuyruk = true;
            hayvan.Bas = 1;

            // Console.WriteLine(hayvan.Konusmak);

            HavadaYasayanlar hy = new HavadaYasayanlar();
            hy.Kuyruk = true;
            hy.Bas = 1;


            // Console.WriteLine(hy.Kuyruk);
        }
    }
}
internal class Insan : Canli
{
    private int ayak;
    private int kol;
    private bool konusmak;
    private int bas;

    public int Ayak { get { return ayak; } set { ayak = value; } }
    public int Kol { get { return kol; } set { kol = value; } }

    public bool Konusmak { get; set; }

    public int Bas { get; set; }
}

internal class Hayvan : Insan
{
    private bool kuyruk;
    public bool Kuyruk { get { return kuyruk; } set { kuyruk = value; } }
}

internal class SudaYasayanlar : Hayvan
{
    private bool solungac;
    public bool Solungac { get { return solungac; } set { solungac = value; } }
}

internal class KaradaYasayanlar : Hayvan
{
    private bool pence;
    public bool Pence { get { return pence; } set { pence = value; } }
}

internal class HavadaYasayanlar : Hayvan
{
    private bool kanat;
    public bool Kanat { get { return kanat; } set { kanat = value; } }
}





