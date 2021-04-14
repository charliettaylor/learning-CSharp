using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //using console
            Console.WriteLine("Hello World!");
            int var = Console.Read();
            Console.WriteLine("ASCII value is {0}:", var);
            
            //conversions
            int myInt = 4;
            double myDouble = 13.37;
            //explicit conversion
            myInt = (int)myDouble;
            string myString = myDouble.ToString();
            Console.WriteLine(myInt);
            Console.WriteLine(myString);
            //convert strings of ints into ints
            myString = "14";
            int convertString = Int32.Parse(myString);
            Console.WriteLine(convertString);

            //string methods
            myString = "Hello World!";
            string sub = myString.Substring(5);
            Console.WriteLine("Substring: " + sub);
            //use ToLower() or ToUpper() on it too
            //Trim() works like strip() in Python, remove whitespace
            int pos = myString.IndexOf("Hello");
            Console.WriteLine("First hello is at " + pos);

            Console.ReadKey();
        }
    }
}
