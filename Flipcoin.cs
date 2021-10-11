using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_program
{
    class Flipcoin
    {
        static void Main(string[] args)
        {
            //variable

            int Num;

            Console.WriteLine("Enter the Number");
            Num = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int countofHeads = 0;
            int countofTail = 0;
            int i = 0;
            while (i <= Num)
            {

                i++;

                Random random = new Random();
                double Flip = random.NextDouble();

                if (Flip < 0.5)
                {

                    Console.WriteLine("Tails");
                    countofTail++;
                }

                else if (Flip > 0.5)
                {


                    Console.WriteLine("Head");
                    countofHeads++;
                }

                double PercentageofHeads = (countofHeads * 100 / Num);
                Console.WriteLine("Percentage of Tail is = " + PercentageofHeads);
                double PercentageOfTails = 100 - PercentageofHeads;
                Console.WriteLine("Percentage of Head is = " + PercentageOfTails);
            }
        }
    }
}
