using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC_
{
    internal class UserInput
    {
        public static void ShowDemo()
        {
            Console.Write("Type your name: "); //Let the user know what to type
            String name = Console.ReadLine(); // ReadLine waits for the input of the user then stores in the variable
            
            // For int input
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + " years old");
        }
    }
}
