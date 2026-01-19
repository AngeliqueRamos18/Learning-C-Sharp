using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC_
{
    internal class LogicalOperator
    {
        
        public static void ShowDemo()
        {
            // Logical operators = can be used to check if more than 1 condition = true/false result

            // && (AND)
            // || (OR)
            Console.WriteLine("What's the temperature outside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if(temp > 10 && temp < 25) // Should meet both conditions in order to proceed in this code block
            {
                Console.WriteLine("It's warm outside");
            }
            else if(temp <= -50 || temp >= 50) // Should only just meet one condition to be true
            {
                Console.WriteLine("Do not go outside");
            }
        }
    }
}
