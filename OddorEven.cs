using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_program
{
    class OddorEven
    {
        static void Main(string[] args)
        {
            int num = 0;
            int result = 0;
            Console.WriteLine("Enter no.");
            num = int.Parse(Console.ReadLine());
            {
                result = num % 2;
            }

            if (result == 0)
            {
                Console.WriteLine("No is even");
            }
            else
            {
                Console.WriteLine("No is odd");
            }
        }
    }
}