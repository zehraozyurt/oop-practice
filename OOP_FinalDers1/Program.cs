using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FinalDers1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region örnek1
            //kalvyeden okutulan 2 sayının toplamını ekrana yazdıran program
            //int number1 , number2, sum;
            //Console.WriteLine("Birinci sayiyi giriniz: ");
            //number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci sayiyi giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //sum = number1 + number2;
            //Console.WriteLine("toplam :" + sum);
            #endregion

            #region örnek2
            //klavyeden basılan tuşu ekrana yazdıran program
            //Console.WriteLine("Klavyeden bir tusa basınız: ");
            //ConsoleKeyInfo keyinfo = Console.ReadKey(true);
            //Console.WriteLine(keyinfo.KeyChar.ToString() + " tusuna bastınız");
            #endregion

            #region örnek3
            //klavyeden okutulan sayının faktöryelini bulan program
            //int sayi ,sonuc=1;
            //Console.WriteLine("Lütfen faktöryeli buluncak sayiyi giriniz: ");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //for(int i=1;i<=sayi; i++)
            //{
            //    sonuc *= i; //sonuc = sonuc*i;
            //}
            //Console.WriteLine("Faktöryeli alınan sayi {0} ve sonucu :{1}", sayi, sonuc);
            #endregion

            #region örnek4
            //kalvyeden okutulan iki sayının toplamını veren program statik ve değer döndüren metod ile yapınız

            //Console.WriteLine("Sayi1 ve sayi2 yi giriniz: ");
            //int sayi1=Convert.ToInt32(Console.ReadLine());
            //int sayi2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Birinci sayimiz : {0} ve ikinci sayimiz : {1} ise toplami = {2}", sayi1, sayi2, topla(sayi1, sayi2));
            #endregion

            #region örnek5 
            //konsol ekranının renginii 3 saniyede bir yeşil mavi ve beyaz yapan programi kodlayınız
            //using System.Threading; eklemeyi unutmayınız

            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.Clear();
            //Thread.Sleep(3000);
            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.Clear();
            //Thread.Sleep(3000);
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();
            //Thread.Sleep(3000);
            #endregion

            #region örnek6
            ////klavyeden okutulan sayının aasal sayi olup olmadığını veren programi yaziniz

            //char cevap = 'H';
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Lütfen sayiyi giriniz: ");
            //    int sayac = 0;
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    for (int i = 1; i <= sayi; i++)
            //    {
            //        if (sayi % i == 0) sayac++;
            //    }
            //    //if (sayac > 2)
            //    //{

            //    //}   break;

            //    if (sayac == 2) Console.WriteLine("Girdiğiniz sayi asaldir");
            //    else Console.WriteLine("Girilen sayi asal sayi değildir");
            //    Console.WriteLine("Tekrar denek için E/H basin");
            //    cevap = Console.ReadKey().KeyChar;
            //}
            //while (cevap == 'E');
            #endregion

            #region örnek7
            ////dört basamaklı sayiların rakamları ters çevrilio 4 ile çarpıldığında kendisine eşit olan sayıları bulan programi yaziniz
            //// basamkları sayi olarak ayırmadan string olarak yapınız

            //int i = 0;
            //for (i=1000; i<9999;i++)
            //{
            //    string sayi = i.ToString();
            //    string tersi = "";
            //    for(int s=3; 0<=s; s--)
            //    {
            //        tersi = tersi + sayi[s].ToString();
            //    }
            //    if(Convert.ToInt32(tersi)*4==i)
            //    {
            //        break;
            //    }
            //}
            //    Console.WriteLine("istenilen sayi : {0}", i);
            #endregion

            #region örnek8 
            ////klavyeden okutulan sayının kaç basamklı olduğunu yazdıran programi yaziniz
            //int i = 1;
            //Console.WriteLine("Lütfen bir sayi giriniz: ");

            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int ilkSayi = sayi;

            //while (sayi > 9)
            //{
            //    sayi = sayi / 10;
            //    i++;
            //}
            //Console.WriteLine("Girdiğiniz {0} sayisi {1} basamaklidir", ilkSayi, i);
            #endregion

            #region örnek9 
            ///Klavyeden okutulan decimal sayiyi binary sayiya ceviren prog. yaziniz.

            //int sayi;
            //int i = 0;
            //double binary = 0;

            //Console.WriteLine("Lutfen decimal sayiyi giriniz");

            //sayi = Convert.ToInt32(Console.ReadLine());
            //int ilkSayi = sayi;
            //while (sayi >= 2)
            //{
            //    binary = binary + (sayi % 2) * Math.Pow(10, i);
            //    sayi = sayi / 2;
            //    i++;
            //}
            //binary = binary + sayi * Math.Pow(10, i);
            //Console.WriteLine("{0} decimal sayisinin binary karsiligi {1} 'dir.", ilkSayi, binary);

            #endregion

            #region örnek10 
            ////Klavyeden okutulan binary sayiya karsilik gelen decimal sayiyi bulan program. 
            //int binarySayi;
            //int sayac = 0;
            //double decimalSayi = 0;
            //int ilk;
            //Console.WriteLine("Lutfen binary sayiyi giriniz");
            //binarySayi = Convert.ToInt32(Console.ReadLine());
            //int ilkBinarySayi = binarySayi;
            //while (binarySayi > 9)
            //{
            //    ilk = binarySayi % 10;
            //    binarySayi = binarySayi / 10;
            //    decimalSayi = decimalSayi + ilk * Math.Pow(2, sayac);
            //    sayac++;
            //}
            //decimalSayi = decimalSayi + binarySayi * Math.Pow(2, sayac);
            //Console.WriteLine("{0} binary sayisinin decimal karsiligi {1} 'dir.",ilkBinarySayi, decimalSayi);
            #endregion

            #region örnek11
            //Soru: e sayisinin hesabini hata toleransi 0.0000000001 ile hesaplayan programi kodlayiniz.

            //int x = 2;
            //double eIlk, eSon, farki;
            //eIlk = Math.Pow(1.0 + 1.0 / x, x);
            //do
            //{
            //    x++;
            //    eSon = Math.Pow(1.0 + 1.0 / x, x);
            //    farki = Math.Abs(eSon - eIlk);
            //    eIlk = eSon;
            //    Console.WriteLine("x=" + x + "icin, " + "e degeri= " + eSon);

            //}
            //while (farki >= 0.0000000001);

            #endregion

            #region örnek12
            ////bir zar klavyeden okutulan atış sayısına bağlı olarak rastgele atılckatır
            //// zardan gelen sayıları ekrana veren programı yazınız

            //Console.WriteLine("Lütffen zar atış sayisini giriniz");
            //int zarDegeri;
            //int atisSayisi = Convert.ToInt32(Console.ReadLine());

            //Random rnd = new Random();
            //for (int i=1; i <=atisSayisi; i++)
            //{
            //    zarDegeri = rnd.Next(1, 7);
            //    Console.WriteLine("{0}.Zr değeri :{1} ",i, zarDegeri);
            //}

            #endregion
        }
        #region örnek3 method
        //static int topla(int sayi1, int sayi2)
        //{
        //    int sonuc = sayi1 + sayi2;
        //    return sonuc;
        //}

        #endregion
    
}
}
