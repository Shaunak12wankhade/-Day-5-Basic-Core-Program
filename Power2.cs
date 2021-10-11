using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_program
{
    class Power2
    {
        static void Main(string[] args)
        {
            int Num = 0;
        int i = 1;
        Console.WriteLine("Enter the Number ");
            Num = int.Parse(Console.ReadLine());
            for (i = 1; i <= Num; i++)
            {


                double power = Math.Pow(2, i);
        Console.WriteLine("Power of Two = " + power);

            }
    Console.ReadLine();
        }
    }
}
