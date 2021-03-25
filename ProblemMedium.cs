using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProblemSolving
{
    public static class ProblemMedium
    {
        /// <summary>
        /// Take a number and returns the specified amount of multiple of that number. Yes this is a static function.
        /// </summary>
        /// <param name="multiple"></param>
        /// <param name="lenght"></param>
        public static void ArrayOfMultiples(int multiple, int lenght)
        {
            ConsoleExtras.ColoredText("Array Of Multiples.", ConsoleColor.Cyan);
            Console.Write($"Array of multiples({multiple}, {lenght}) ->[");
            int solution = multiple;
            for(int i = 0; i != lenght;i++)
            {
                solution = multiple * (i + 1);
                var print = (i + 2) <= lenght ? $"{solution}, " : $"{solution}" ;
                Console.Write(print);
            }
            Console.Write("]\n\n");
        }
    }
}
