using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LearnC_
{
    internal class ForLoopDemo
    {
        public static void ShowDemo()
        {
            // For loop = repeats the code block in a Finite amount of times

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n============================= Print in even numbers only");
            for(int j = 2; j <= 20; j += 2)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("\n============================ Countdown");
            for(int x = 10; x > 0; x--)
            {
                Console.WriteLine(x);
            }

            // NESTED FOR LOOPS
            // Creating rectangle shape output
            
        }

        public static void CreateBorder(int rows, int columns)
        {
            for(int x = 0; x < rows; x++)
            {
                string asterisk = "";

                for(int y = 0; y < columns; y++)
                {
                    asterisk += "*"; // Can be implemented with user input here depending on the value of the symbol
                }
                Console.WriteLine(asterisk);
            }
        }
    }
}
