using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC_
{
    internal class StringMethods
    {
        public static void ShowDemo()
        {

            // TO LOWER and UPPER
            string fullName = "Angel Louise";
            Console.WriteLine(fullName.ToUpper()); // Capitalizes all of the string
            // opposite of this is .ToLower()

            // REPLACE
            string phoneNumber = "123-456-7890";
            phoneNumber = phoneNumber.Replace("-", "/");
            Console.WriteLine("Replaced: " + phoneNumber);

            // INSERT
            // We can set isnert a character or string at a given index

            string userName = fullName.Insert(0, "@"); // Insert the character at the beginning
            Console.WriteLine("Insert: " + userName);

            // LENGTH
            // This one is not a method but a property but it's accessed the same way as method
            Console.WriteLine("Length: " + fullName.Length);
            // Length also includes the space

            // SUBSTRING
            // We can take a section from an original string and create an entirely new string
            // Though positions of how many characters are needed

            string firstName = fullName.Substring(0, 5);
            Console.WriteLine("Substring: " + firstName);

            string lastName = fullName.Substring(6, 6); // The first parameter is where it should start, then the second parameter is how many character it should take
            Console.WriteLine("Substring 2: " + lastName);

        }
    }
}
