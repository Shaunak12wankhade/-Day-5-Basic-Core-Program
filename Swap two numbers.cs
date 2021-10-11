using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_program
{
    class Swap_two_numbers
    {
        static void Main(string[] args)
        {
            
            int num1, num2;
            int temp = 0;


            Console.Write("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("First number after swapping: "+num1);
            Console.WriteLine("Second number after swapping: "+num2);
            Console.ReadKey();
        }

        
    }
}
