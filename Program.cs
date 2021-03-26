using System;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  ProblemMedium.ArrayOfMultiples(7, 5);
              ProblemMedium.ArrayOfMultiples(12, 10);
              ProblemMedium.ArrayOfMultiples(17, 6);*/

            // ProblemMedium.FindTheWord("Diver", "I like to Diver Cards.");

            VariablesThings variables = new VariablesThings();
            variables.AddListValuesSort(); // This adds all the values to all three array list. didn't want to messy up program class.
            ProblemMedium.SortLargestArray(variables.NumberTest1,variables.NumberTest2,variables.NumberTest3);
        }
    }
}
