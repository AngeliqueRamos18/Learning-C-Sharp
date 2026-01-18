using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LearnC_
{
    internal class Arithmetic
    {
        public static void ShowDemo()
        {
            // For addition
            int x = 3;
            int y = 5;
            x = x + 1; // 3 + 1
            // shortcut for this would be x += 1
            Console.WriteLine("Addition: " + x);
            // Increment
            x++;
            Console.WriteLine("incremented: " + x);

            // same way for reducing, or decrementing

            // MULTIPLICATION (Same thing)
            y = y * 2;
            Console.WriteLine("Multiplied: " + y);

            // DIVISION
            // However you have to consider when it comes to division for example
            y = 5 / 2;
            Console.WriteLine("Division: " + y); // This will not store as 2.5 since y is an INT data type

            // MODULUS 
            int remainder = x % 3;
            Console.WriteLine("Modulus: " + remainder);

            Console.WriteLine();
            // METHOD OF MATHS =======================================

            double a = 3;
            double b = Math.Pow(a, 2); // 3 ^ 2
            Console.WriteLine("Power: " + b);

            // Square root
            double c = Math.Sqrt(a);
            Console.WriteLine("Square Root: " + c);

            // Absolute value (turn any negative value into positive)
            double e = -3;
            e = Math.Abs(e);
            Console.WriteLine("Absolute: " + e);

            // Rounding
            double f = 3.14;
            f = Math.Round(f);
            Console.WriteLine("Rounded: " + f); // 3, but you can always round the number up using ceiling method

            // Ceiling
            double g = 3.14;
            g = Math.Ceiling(g);
            Console.WriteLine("Ceiling: " + g);

            // Round down (Floor)
            double i = 3.99;
            i = Math.Floor(i);
            Console.WriteLine("Floor: " + i); // 3

            // Max, we can find the maximum value of two values or variablses
            double first = 3.99;
            double second = 5;

            Console.WriteLine("Higher value: " + Math.Max(first, second)); // Stores the one with higher value

            // Min, selects the lower value
            Console.WriteLine("Lower value: " + Math.Min(first, second));


        }
    }
}
