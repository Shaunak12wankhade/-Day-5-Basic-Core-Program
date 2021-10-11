using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_program
{
    class Prime_factorization
    {
        static void Main(string[] args)
        {
            //Prime Factorization

            int num = 1;
            int i = 1;

            Console.WriteLine("Enter the Number ");
            num = int.Parse(Console.ReadLine());



            for (i = 1; i <= num; i++)
            {

                if (num % i == 0)
                {
                    Console.WriteLine("Factors are = " + i);
                }

            }
            Console.ReadLine();
        }
    }
}
