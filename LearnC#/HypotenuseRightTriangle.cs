using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC_
{
    internal class HypotenuseRightTriangle
    {
        /// <summary>
        /// This program finds a hypotenuse of the right triangle.
        /// The formula is square root(a^2 + b^2)
        /// </summary>
        public static void ShowDemo()
        {
            Console.Write("Input Side A: ");
            double firstNum = Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);
            Console.Write("Input Side B: ");
            double secondNum = Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);

            double result = Math.Sqrt(firstNum + secondNum);
            Console.WriteLine("The hypotenuse is: " + result);
        }
    }
}
