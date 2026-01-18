using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC_
{
    internal class VariablesDemo
    {
        public static void ShowVariablesDemo()
        {
            int x; // Declaration
            x = 1; // Initialization

            int y = 10;
            int z = x + y;

            

            Console.WriteLine(x);
            Console.WriteLine(z);

            int age = 24;

            Console.WriteLine("Your age is " + age);

            //Double is like decimal, like a floating point number but with precision
            double height = 300.5;
            bool alive = true; // can either store true or false only
            char symbol = '@';

            Console.WriteLine("Your height is " + height + " cm");

            // CONSTANTS ================
            // Constants are immutable value which are known at compile time, and do not change for the life of the program

            const double pi = 3.14;
        }
    }
}
