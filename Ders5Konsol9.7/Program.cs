using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5Konsol9._7
{
    class MyClass
    {
        public MyClass() //Constructor
        {
            Console.WriteLine("Constructor is worked");
        }
        ~MyClass()
        {
            Console.WriteLine("Destructor is worked"); 
        }
        static void Main(string[] args)
        {
            int sayi = 10;
            for(int i = 0; i<sayi;i++)
            {
                new MyClass(); //referanssız nesne 
            }
                GC.Collect(); //Çöp toplayıcıyı çalıştırır ve referanssız nesneleri temizler
        }
    }
}
