using System;
using System.Collections.Generic;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicProgramming dynamicProgramming = new DynamicProgramming();

            /*  ProblemMedium.ArrayOfMultiples(7, 5);
              ProblemMedium.ArrayOfMultiples(12, 10);
              ProblemMedium.ArrayOfMultiples(17, 6);*/

            // ProblemMedium.FindTheWord("Diver", "I like to Diver Cards.");

            /*VariablesThings variables = new VariablesThings();
            variables.AddListValuesSort(); // This adds all the values to all three array list. didn't want to messy up program class.
            ProblemMedium.SortLargestArray(variables.NumberTest1,variables.NumberTest2,variables.NumberTest3);*/

            /* ProblemMedium.DiffercesOfTwoSquare(5);
             ProblemMedium.DiffercesOfTwoSquare(6);
             ProblemMedium.DiffercesOfTwoSquare(7);*/

            /*ProblemMedium.CenteredPentagonal(1);
            ProblemMedium.CenteredPentagonal(2);
            ProblemMedium.CenteredPentagonal(3);
            ProblemMedium.CenteredPentagonal(8);*/

            //  ConsoleExtras.ColoredText("Fibonacci",ConsoleColor.Cyan);
            //  Console.WriteLine( dynamicProgramming.FibonacciSequence(12));

            //  Console.WriteLine(dynamicProgramming.FibonacciSequenceMemoizion(200));

            //Console.WriteLine(dynamicProgramming.GridTravler(18, 18));
            Dictionary<string, ulong> gridDictionary = new Dictionary<string, ulong>();
            Console.WriteLine(dynamicProgramming.GridTravlerMemoize(18, 18,gridDictionary));
        }
    }
}
