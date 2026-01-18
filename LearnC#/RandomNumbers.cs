using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC_
{
    internal class RandomNumbers
    {
        public static void ShowDemo()
        {
            Random random = new Random(); //Initialize random object

            // To access, and set its range

            // If we want to set random numbers from 1-6 set it like this
            int num = random.Next(1, 7); // The 7 is not included in the counting
            Console.WriteLine("Generated number: " + num);

            // For generating random double
            double num2 = random.NextDouble(); // this is between 0-1
            Console.WriteLine("Generated double: " + num2);
        }
    }
}
