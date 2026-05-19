using Hafta6C;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders6Konsol4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyHouse home = new MyHouse();
            home.City ="Zonguldak";
            home.District = "Merkez";
            home.Area = 140;
            home.RNumber = 4;
            home.FNumber = 8;
            Console.WriteLine(home.homeInformation());
        }
    }
}

namespace Hafta6C
{
    internal class MyHouse
    {
        private string city;
        private string district;
        private float area;
        private int fNumber;
        private int rNumber;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string District
        {
            get { return district; }
            set { district = value; }
        }

        public float Area
        {
            get { return area; }
            set
            {
                if (value <= 0)
                {
                    area = Math.Abs(value);
                }
            }
            }
        public int FNumber {
            get { return fNumber; }
            set { fNumber = value; }
        }
        public int RNumber
        {
            get { return rNumber; }
            set { rNumber = value; }
        }
        public String homeInformation()
        {
            return string.Format("City: {0} \nDistrict:{1} \nArea: {2}\nm2 Floor Number: {3} \nRoom Number: {4}", city,district,area,fNumber,rNumber);
        }
    }
}
