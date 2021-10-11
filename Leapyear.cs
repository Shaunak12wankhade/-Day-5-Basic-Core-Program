using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_program
{
    class Leapyear
    {
        static void Main(string[] args)
        {

            int year = 0;
            Console.WriteLine("Enter the year in four digit ");
            year = int.Parse(Console.ReadLine());

            if ((year % 100 == 0) && (year % 400 == 0) && (year % 4 == 0))
            {
                Console.WriteLine("Entered year is a LEAP YEAR");
            }
            else
            {
                Console.WriteLine("Entered year is not a LEAP YEAR");
            }

            Console.ReadLine();
        }
    }
}
