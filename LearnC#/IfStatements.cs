using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC_
{
    internal class IfStatements
    {
        public static void ShowDemo()
        {
            // If statement = basic form of decision making

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            

            // The order of if statements and conditional logic matter, so if you want to limit the
            // maximum age to sign up like up to 80, set it on the first condition followed by age >= 18

            /*if(age >= 18)
            {
                Console.WriteLine("You are qualified to register");
            }
            else if (age < 0) // in between additional conditions
            {
                Console.WriteLine("You haven't been born yet");
            }
            else // The last resort of the condition
            {
                Console.WriteLine("Sorry you're not allowed to register");
            }*/

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("You did not enter your name");
            }
            else
            {
                Console.WriteLine("Hello " + name);
            }
        }
    }
}
