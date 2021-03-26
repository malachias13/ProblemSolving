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

        /// <summary>
        /// This function searchs for a world in a string(text), if it finds it it will tell you the index, if not then retun a string that it can find it.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="text"></param>
        public static void FindTheWord(string word, string text)
        {
            ConsoleExtras.ColoredText("Fin the word", ConsoleColor.Blue);
            string search = text.Contains(word) || text.Contains(word) ? $"The word [{word}] is in index {text.IndexOf(word)}" 
                : $"The world {word} is not found";
            Console.WriteLine(search);
            ConsoleExtras.ColoredText(text+"\n",ConsoleColor.DarkYellow);
        }

        /// <summary>
        /// It finds the largest number from three array list and put them in a arraylist.
        /// I just printed them insted because I dont feel like making a loop to print them all.
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <param name="list3"></param>
        public static void SortLargestArray(List<int> list1,List<int> list2,List<int> list3)
        {
            int numberOfElements = 0;
            int storedValue = 0;
            List<int> MasterList = new List<int>();

            ConsoleExtras.ColoredText("Sort the larger from three array list.", ConsoleColor.Cyan);
            for (int i = 0; i != 3; i++)
            {
                switch(i)
                {
                    case 0:
                        numberOfElements = list1.Count();
                         MasterList = list1;
                        break;
                    case 1:
                        numberOfElements = list2.Count();
                        MasterList = list2;
                        break;

                    case 2:
                        numberOfElements = list3.Count();
                        MasterList = list3;
                        break;
                }

                for(int t = 0; t < numberOfElements-1; t++)
                {
                    storedValue = MasterList[t];
                    if (storedValue > MasterList[t+1])
                        storedValue = MasterList[t];
                    else
                        storedValue = MasterList[t + 1];

                    if(t == numberOfElements-2)
                    Console.WriteLine(storedValue);
                    // I could add this to a list or an array, but I dont feel like looping to print it.
                }

            }
        }
    }
}
