using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class DynamicProgramming
    {
        public static int FibonacciSequence(int number)
        {
            if(number == 0) {  return 0; }
            if(number == 1) {  return 1; }
            else
            {
                 int fib = FibonacciSequence(number - 1) + FibonacciSequence(number - 2);
                    return fib;
            }
            
        }
        public static ulong FibonacciSequenceMemoizion(ulong number)
        {
            ulong[] fib = new ulong[number + 1];

            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i < fib.Length;i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            return fib[number];
        }
      /*  public void RadixSort()
        {
            int[] arrayOfInt = {328,449,782,124,152};
            int[] dumpArray = new int[arrayOfInt.Length];
            int[] counts = new int[10];
            int[] prefix = new int[counts.Length + 1];
            int numbersPlace = 0;
            int sum = 0;
            for (int i = 0; i != 2;i++)
            {
                for(int t = 0; t < arrayOfInt.Length;t++)
                {
           
                    if(i == 0)
                    {
                        string numString = arrayOfInt[t].ToString();
                        numbersPlace = Convert.ToInt32(numString.Substring(numString.Length));
                        
                    }
                    else if (i == 1)
                    {
                        string numString = arrayOfInt[t].ToString();
                        numbersPlace = Convert.ToInt32(numString.Substring(numString.Length-1));
                    }
                    else if (i == 2)
                    {
                        string numString = arrayOfInt[t].ToString();
                        numbersPlace = Convert.ToInt32(numString.Substring(numString.Length-2));
                    }
                    switch (numbersPlace)
                    {
                        case 0:
                            counts[0] += 1;
                            break;
                        case 1:
                            counts[1] += 1;
                            break;
                        case 2:
                            counts[2] += 1;
                            break;
                        case 3:
                            counts[3] += 1;
                            break;
                        case 4:
                            counts[4] += 1;
                            break;
                        case 5:
                            counts[5] += 1;
                            break;
                        case 6:
                            counts[6] += 1;
                            break;
                        case 7:
                            counts[7] += 1;
                            break;
                        case 8:
                            counts[8] += 1;
                            break;
                        case 9:
                            counts[9] += 1;
                            break;
                    }
                    prefix[0] = counts[0];
                    for(int a = 0; a < counts.Length;a++)
                    {
                        prefix[a] = prefix[a - 1] + counts[a];
                    }

                    if (i == 0)
                    {
                        string numString = arrayOfInt[t].ToString();
                        numbersPlace = Convert.ToInt32(numString.Substring(numString.Length));

                    }
                    else if (i == 1)
                    {
                        string numString = arrayOfInt[t].ToString();
                        numbersPlace = Convert.ToInt32(numString.Substring(numString.Length - 1));
                    }
                    else if (i == 2)
                    {
                        string numString = arrayOfInt[t].ToString();
                        numbersPlace = Convert.ToInt32(numString.Substring(numString.Length - 2));
                    }
                }
            }


        }*/

        /* Find the total amout of ways to move from the top-left corner to the bottom-right. 
         * Only moving down or right. */
        public static int GridTravler(int rows,int columns)
        {
            if(rows == 1 && columns == 1) { return 1; }
            if(rows == 0 || columns == 0) { return 0; }

            return GridTravler(rows - 1, columns) + GridTravler(rows, columns - 1);
            
        }
        public static ulong GridTravlerMemoize(ulong rows,ulong columns,Dictionary<string,ulong> gridDictionary)
        {
            // ulong[,] grid = new ulong[rows + 1, columns + 1];
            string key = $"{rows},{columns}";
            
         // Dictionary<string, ulong> gridDictionary = new Dictionary<string, ulong>();

            if (gridDictionary.ContainsKey(key)) return gridDictionary[key]; 
            if (rows == 1 && columns == 1) { return 1; }
            if (rows == 0 || columns == 0) { return 0; }

            gridDictionary[key] = GridTravlerMemoize(rows - 1, columns,gridDictionary) + GridTravlerMemoize(rows, columns - 1,gridDictionary);
            return gridDictionary[key];
        }

        /// <summary>
        /// Binary Search.
        /// It search for an index in a ordered list.
        /// </summary>
        /// <param name="Array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int BinarySearch(int[]Array, int target)
        {
            bool leaseToGreater = false;
            // Checking to see is Array is order from lease to greatest.
            for(int i = 0; i < Array.Length; i++)
            {
                if (i + 1 > Array.Length - 1) { break; }
                if (Array[i] == Array[i + 1]) { continue; }
                if(Array[i] < Array[i + 1]) 
                { 
                    leaseToGreater = true;
                    break;
                }
                else 
                {
                    leaseToGreater = false;
                    break;
                }
            }

            int low = 0, high = Array.Length-1, mid = 0;

            switch (leaseToGreater)
            {
                case true:
                    while(low <= high)
                    {
                        mid = (low + high) / 2;
                        if (Array[mid] == target) { return mid; }
                        else if(Array[mid] > target) { high = mid - 1; }
                        else if(Array[mid] < target) { low = mid + 1; }
                    }
                    break;
                case false:
                    while(low <= high)
                    {
                        mid = (low + high) / 2;
                        if(Array[mid] == target) { return mid; }
                        else if(Array[mid] < target) { high = mid - 1; }
                        else if(Array[mid] > target) { low = mid + 1; }
                    }
                    break;
            }
            return -1;
        }

    }
}
