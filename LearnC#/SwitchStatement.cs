using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC_
{
    internal class SwitchStatement
    {
        public static void ShowDemo()
        {
            // Switch = an efficient alternative to many else if statements

            Console.WriteLine("What day is it today?");
            string day = Console.ReadLine();

            switch(day)
            {
                //The same like if(day == "Monday"){} but a less hassle one
                case "Monday":
                    Console.WriteLine("It's Monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Tuesday");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Thursday");
                    break;
                case "Friday":
                    Console.WriteLine("It's Friday");
                    break;
                case "Saturday":
                    Console.WriteLine("It's Saturday");
                    break;
                case "Sunday":
                    Console.WriteLine("It's Sunday");
                    break;
                default: // This is used when there's no matching cases
                    Console.WriteLine("That's not a name of the day");
                    break;


            }
        }
    }
}
