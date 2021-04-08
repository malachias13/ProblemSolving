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
        public int FibonacciSequence(int number)
        {
            if(number == 0) {  return 0; }
            if(number == 1) {  return 1; }
            else
            {
                 int fib = FibonacciSequence(number - 1) + FibonacciSequence(number - 2);
                    return fib;
            }
            
        }
        public int FibonacciSequenceMemoizion(int number)
        {
            int[] fib = new int[number + 1];

            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i < fib.Length;i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            return fib[number];
        }
    }
}
