using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC_
{
    internal class StringDemo
    {
        public static void ShowStringDemo()
        {
            // PRINTING OUTPUT ================

            Console.Write("Hey");
            Console.WriteLine("Hello!"); // This one creates a new line compared to the Write() function

            // Shortcut for the WriteLine, type cw and enter to auto generate

            // COMMENTS ==========
            // Comments can be put inside the code but will not be revealed in the output

            // This is a single line comment

            /* This is a multi-line comment
             * Hello
             * World
             */

            // ESCAPE SEQUENCES ==================

            // To create an escape sequence you start it with back slashes \
            Console.WriteLine("\tThis one has tab at the start");

            // To do the backspace
            Console.WriteLine("Hello W\borld");


            // This next line prevents the program from ending without pressing any key
            // Console.ReadKey();
        }
    }
}
