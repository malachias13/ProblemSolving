using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public static class ConsoleExtras
    {
        /// <summary>
        /// It changes the text color in console. 
        /// ConsoleExtras is someting you made Remember that!!!!!!
        /// </summary>
        /// <param name="text"></param>
        /// <param name="color"></param>
        public static void ColoredText(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        
    }
}
