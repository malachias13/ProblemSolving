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

        /// <summary>
        /// The function calulate the area of both Inner and outter square, and print the differences.
        /// They are two squares: a smaller and a bigger one. The smaller square is in a cirle circumcircles and
        /// bigger square is on the incircle(outside).
        /// </summary>
        /// <param name="radius"></param>
        public static void DiffercesOfTwoSquare(double radius)
        {
            /* Problem: A cirle and two squares
             * _______________________________________________________________________________________
             * Imagine a circle and two squares: a smaller and a bigger one. 
             * For the smaller one, the circle is a circumcircle and for the bigger one, an incircle.
             * _______________________________________________________________________________________
             * 
             * So we are givin the radius of the circle. Which we use to find the area of the inner sqaure
             * and outter square. Then subtrace both areas to find the differces. 
             *  Formula for differences --------> Outter square - Innder square = Differences.
             */
            
            double diameter = radius * 2;
            double side = (diameter/2) * Math.Sqrt(2);

          /* The formula of a square is [side * side = Area]*/
            double area1 = side * side; 
            double area2 = diameter * diameter;

            /* The formula for differences. */
            double difference = Math.Ceiling((area2 - area1));

            ConsoleExtras.ColoredText($"A circle and two squares. Radius: {radius}",ConsoleColor.Yellow);
            Console.WriteLine($"The differences of the Inner and outter." +
                $"\nArea: {difference}\n");

        }

        /// <summary>
        /// calculates how many dots exist in a pentagonal shape around the center dot on the Nth iteration.
        /// Formula: (5(n^2) - 5n + 2) / 2
        /// </summary>
        /// <param name="number"></param>
        public static void CenteredPentagonal(int number)
        { 
            double soultion;
            soultion = ((5 * (Math.Pow(number, 2)) - (5 * number) + 2)) / 2;

            ConsoleExtras.ColoredText("Centerd Pentagonal", ConsoleColor.Green);
            Console.WriteLine(soultion+"\n");
        }

        public static int RemoveDuplicates(int [] nums)
        {
            if (nums.Length == 0) return 0;
            int i = 0;
            for(int j = 1; j < nums.Length; j++)
            {
                if(nums[i] != nums[j])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }


    }
}
