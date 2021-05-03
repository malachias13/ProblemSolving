using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class ApplyedMath
    {

        public void DivideComplexNumbers(string problem)
        {
            // Problem --> (6+3i) / (7-5i)
            /* OUTPUT
             * 6,
             * 43 == '+',
             * 3,
             * 105 == 'i',
             * 47 == '/',
             * 7,
             * 45 == '-',
             * 5,
             * 105 == 'i'
             */
            string[] parseEquation = new string[problem.Length + 1];
            int index = 0;

            int a =  0, a1 = 0, b = 0, b1 = 0;
            int conjugate = 0;
            string[] faction = new string[2];

            for (int i = 0; i < problem.Length; i++)
            {
                switch (problem[i])
                {
                    case '+':
                        if(i != 0)
                            index++;
                        parseEquation[index]  = problem[i].ToString();
                        break;
                    case '-':
                        if(i != 0)
                            index++;
                        parseEquation[index] = problem[i].ToString();
                        break;
                    case '/':
                        index++;
                        parseEquation[index] = problem[i].ToString();
                        break;
                    case 'i':
                        index++;
                        parseEquation[index] = problem[i].ToString();
                        break;
                    case ' ':
                        break;
                    default:
                        parseEquation[index] += int.Parse(problem[i].ToString()).ToString();
                        break;
                }

            }
            for(int i = 0; i < parseEquation.Length;i++)
            {
                Console.WriteLine(parseEquation[i]);
            }

            int loop = 0;
            for (int i = 0; i < parseEquation.Length;i++)
            {
                int num = 0;
                
                switch(parseEquation[i])
                {
                    case "+":
                        i++;
                        num = int.Parse(parseEquation[i]);
                        break;
                    case "-":
                        i++;
                        num = int.Parse(parseEquation[i]);
                        num = -num;
                        break;
                    case "/":
                        break;
                    case "i":
                        break;
                    case " ":
                        break;
                    default:
                        int.TryParse(parseEquation[i],out num);
                        break;
                }
                if (i >= parseEquation.Length)
                    break;

                if(loop == 0)
                {
                    a = num;
                }
                else if(loop ==1)
                {

                    a1 = num;
                }
                else if(loop == 4)
                {

                    b = num;
                }
                else if (loop == 5)
                {

                    b1 = num;
                }
                loop++;
            }

            // Run a check of If statement

            conjugate = -1 * b1;
            faction[0] = Convert.ToInt32((a * b) + (-1 * (a1 * conjugate))).ToString();
            faction[0] += " + "+ Convert.ToInt32((a*conjugate) + (a1*b)).ToString()+"i";

            //(a1 * conjugate) + (a1 * b) + (a*conjugate)

            faction[1] = Convert.ToInt32((b*b) + (b*conjugate) + (b1*b) +  (-1 *(b1 * conjugate))).ToString();

            Console.WriteLine($"{faction[0]} / {faction[1]}");

          //  Console.WriteLine("\nA "+a);
          //  Console.WriteLine("A1 "+a1);
          //  Console.WriteLine("B "+b);
          //  Console.WriteLine("B1 "+b1);
          //  Console.WriteLine("Conjugate "+conjugate);

            


        }

    }
}
