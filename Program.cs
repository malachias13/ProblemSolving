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
            //  Dictionary<string, ulong> gridDictionary = new Dictionary<string, ulong>();
            //  Console.WriteLine(dynamicProgramming.GridTravlerMemoize(100, 100,gridDictionary));


            //ApplyedMath applyedMath = new ApplyedMath();

            //applyedMath.DivideComplexNumbers("6+3i/7-5i");
            //applyedMath.DivideComplexNumbers("-32+8i/5+3i");
            //applyedMath.DivideComplexNumbers("25+19i/5-3i");
            //applyedMath.DivideComplexNumbers("-23+11i/5+1i");
            //applyedMath.DivideComplexNumbers("2-8i/3+5i");
            //applyedMath.DivideComplexNumbers("2-16i / - 3 - 1i");

            // Remove Duplicates from Sorted Array

            /*  int[] DuplicatedArray = { 4, 4, 4, 5, 5, 8, 8, 10,10, 22 };

              int len = ProblemMedium.RemoveDuplicates(DuplicatedArray);
              for (int i = 0; i < len; i++)
              {
                  Console.Write(DuplicatedArray[i] +", ");
              }
            */


             int[] numList = { 100, 80, 20, 10, 7, 6 };
           // int[] numList = { 20, 20, 40, 44, 48, 50, 54 };
            Console.WriteLine(DynamicProgramming.BinarySearch(numList,54));

        }
    }
}
