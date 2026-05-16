using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ders5Konsol7
{
    class Human 
    {
        int yas;
        char cinsiyet;
        double boy;

       public Human()
       {
            Console.WriteLine("Default constructor calisti");
       }
       public Human(char alo)
        {
            cinsiyet = alo;
            Console.WriteLine("Cinsiyet :  " + cinsiyet);
        }
       public Human(double boy)
       {
            this.boy = boy;
            Console.WriteLine("Boy : " + boy);
       }

        static void Main(string[] args)
        {
            Human person =new Human();
            Human person2 = new Human();
            Human persom3 =new Human(); 

        }
    }
}
