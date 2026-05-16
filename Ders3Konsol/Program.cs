using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3Konsol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] array1 = { 6, 79, -8, 9, 41 };

                Console.WriteLine(array1[6]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
