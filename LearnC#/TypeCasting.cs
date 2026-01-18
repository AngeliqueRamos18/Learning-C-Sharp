using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC_
{
    internal class TypeCasting
    {
        public static void ShowTypeCasting()
        {
            // TYPE CASTING =====================
            // Converting a value to a different data type
            // Useful when we accept user input (string)

            double a = 3.14;
            int b = Convert.ToInt32(a); // This will truncate the decimal part

            Console.WriteLine(b);

            //This one allows you to get the data type of the current variable
            Console.WriteLine(b.GetType());


            // convert int to double
            int c = 123;
            double d = Convert.ToDouble(c); 
            Console.WriteLine(d + " " + d.GetType());

            // Convert int to string
            int e = 321;
            string f = Convert.ToString(e);
            Console.WriteLine(f + " " + f.GetType());

            // Convert string to char
            string g = "$";
            char h = Convert.ToChar(g);
            Console.WriteLine(h + " " + h.GetType());

            // Convert string to a boolean
            string i = "true";
            bool j = Convert.ToBoolean(i);
            Console.WriteLine(j + " " + j.GetType());
        }
    }
}
