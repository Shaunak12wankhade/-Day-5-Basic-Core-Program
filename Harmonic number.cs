using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_program
{
    class Harmonic_number
    {
        static void Main(string[] args)
        {



            int Num = 0;
            int i = 1;
            double sumofHarmonicSeries = 0.0;
            Console.WriteLine("Enter the number");
            Num = int.Parse(Console.ReadLine());

            for (i = 1; i <= Num; i++)
            {

                Console.Write("1/{0} +", i);
                sumofHarmonicSeries = 1 / (float)i;




            }
            Console.WriteLine("\nSum of series upto {0} terms : {1}\n", +Num, +sumofHarmonicSeries);
            Console.ReadLine();
        }
    }
}
