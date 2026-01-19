using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC_
{
    internal class WhileLoopDemo
    {
        public static void ShowDemo()
        {
            // While loop = repeats the code while some condition remains true

            string name = "";
            
            // This while loop forces the user to have an input of name before printing out "Hello" output
            while(name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);
        }
    }
}
