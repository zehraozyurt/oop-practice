using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7Konsol5
{
    class Calisan
    {
        private string calisanAd;
        private int calisanId;
        private double calisanMaas;

        public string CalisanAd { get { return calisanAd; } set { calisanAd = value; } }
        public int CalisanId { get { return calisanId; } set { calisanId = value; } }
        public double CalisanMaas { get { return calisanMaas; } set { calisanMaas = value; } }
    }
    class Yonetici : Calisan
    {
        private int sirketKar;

        public int SirketKar
        {
            get { return sirketKar; }
            set { sirketKar = value; }
        }

        class Personel : Calisan
        {
            private double satisMiktari;

            public double SatisMiktari { get { return satisMiktari; } set { satisMiktari = value; } }
        }

        internal class Program
        {
            static void Main(string[] args)
            {

                Yonetici ytc = new Yonetici();
                ytc.CalisanAd = "Ozan";
                ytc.CalisanId = 1;
                ytc.CalisanMaas = 180000;
                ytc.SirketKar = 600000;//sadece yöneticiyeaitt bir alan

                Personel psl = new Personel();
                psl.CalisanAd = "Mahmut";
                psl.CalisanMaas = 22000;
                psl.CalisanId = 2;

                psl.SatisMiktari = 400;

                Console.WriteLine("Yönetici Adi :{0} \nYönetici  ID: {1} \nYönetici Maasi: {2}\nSirket Kar: {3}\n", ytc.CalisanAd, ytc.CalisanId, ytc.CalisanMaas, ytc.SirketKar);

                Console.WriteLine("Personel Adi: {0}\nPersonel ID: {1}\nPersonel Maasi: {2}\nPersonel Satis Miktari: {3}\n",psl.CalisanAd,psl.CalisanId,ytc.CalisanMaas,ytc.SirketKar);
            }
        }
    }
}
