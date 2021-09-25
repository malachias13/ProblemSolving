using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
        /// <summary>
        /// Color text.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="color"></param>
        public static void ColoredWrite(string text,ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }

        public static void DotLoadingAnimation(string text, int milliseconds, int times)
        {
            int x, y;
            Console.Write(text);
            x = Console.CursorLeft;
            y = Console.CursorTop;
            int count = 0;
            while (count < times)
            {
                // Add dots.
                Console.SetCursorPosition(x, y);
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(milliseconds);
                }
                Console.SetCursorPosition(x, y);
                // Remove dots.
                for (int i = 0; i < 5; i++)
                {
                    //Console.SetCursorPosition(x, y);
                    Console.Write(" ");
                    Thread.Sleep(milliseconds);
                }
                count++;
            }
            ClearCurrentLine();

        }
        
        /// <summary>
        /// Removes text on current line.
        /// </summary>
        public static void ClearCurrentLine()
        {
            int x = Console.CursorLeft, y = Console.CursorTop;
            int windowbuffer = Console.BufferWidth;
            
            Console.SetCursorPosition(0, y);
            Console.Write("                                                           " +
                "                                       \n");
        }
        
    }
}
