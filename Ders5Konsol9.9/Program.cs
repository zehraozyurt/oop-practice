using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5Konsol9._9
{
   class Cars
    {
        public string model;
        public int year;
        public string color;
        public Cars()
        {
            model = "Togg";
        }

        public Cars (string model)
        {
            this.model = model;
        }

        public Cars (string model ,int year ,string color)
        {
            this.model = model;
            this.year = year;
            this.color = color;
        }
        static void Main(string[] args)
        {
            Cars cars = new Cars();
            Console.WriteLine(cars.model);

            Cars cars2 = new Cars();

            Console.WriteLine(cars2.model);
            Cars cars3 = new Cars();
            Console.WriteLine(cars2.model);
            Console.WriteLine(cars3.model);

            Cars cars4 = new Cars("bmw", 2025,"Blue");
            Console.WriteLine(cars4.model + " " + cars4.color + " " + cars4.year);
            cars4.arabaOzellikleri();



        }
        public void arabaOzellikleri()
        {
            Console.WriteLine("Arabamiz : " + model + " " + color + " " + year);
        }
    }
}
