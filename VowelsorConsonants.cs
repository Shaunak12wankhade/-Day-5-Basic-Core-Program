using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_program
{
    class VowelsorConsonants
    {
        static void Main(string[] args)
        {
            char a;
            Console.WriteLine("Please enter the alphabet");
            a = char.Parse(Console.ReadLine());

            if (a == 'a'| a == 'e'| a == 'i'| a== 'o'| a == 'u')
                {
                   Console.WriteLine("Alphabet is a Vowel");
                }
            else
            {
                Console.WriteLine("Alphabet is a consonant");
            }


        }
    }
}
