using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders8Konsol1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hayvan hayvan = new Hayvan();
            //hayvan.tanimla();

            Insan insan = new Insan();
            insan.tanimla();
        }
        public class Canli
        {
            public virtual void tanimla()
            {
                Console.WriteLine("Bu bir CANLİ sınıfına ait metottur");
            }
        }
        public class Insan : Canli
        {
            public override void tanimla()
            {
                base.tanimla();
                Console.WriteLine("Bu bir INSAN sinifina ait metotdur");
            }
        }
        public class Hayvan : Canli
        {
            public override void tanimla()
            {
                Console.WriteLine("Bu bir HAYVAN sinifina ait metodur");
            }
        }
    }
}


