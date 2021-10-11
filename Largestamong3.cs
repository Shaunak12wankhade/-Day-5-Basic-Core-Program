using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_program
{
    class Largestamong3
    {
        static void Main(string[] args)
        {

            int Num1;
            int Num2;
            int Num3;

            Console.WriteLine("Enter the Number 1 ");
            Num1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter the Number 2 ");
            Num2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter the Number 3");
            Num3 = int.Parse(Console.ReadLine());

            if (Num1 > Num2 || Num1 > Num3)
            {
                Console.WriteLine("Entered Number 1  is greater =" + Num1);

            }
            else if (Num2 > Num1 || Num2 > Num3)
            {
                Console.WriteLine("Entered Number 2  is greater = " + Num2);

            }
            else if (Num3 > Num1 || Num3 > Num2)
            {
                Console.WriteLine("Entered Number 3  is greater = " + Num3);
            }
            Console.ReadLine();
        }
    }
}
