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

            Box test = new Box(4, 4, 4);

            Console.WriteLine("H: {0}, W: {1}, L: {2}", test.Height, test.Width, test.length);
            Console.WriteLine("Box volume is: {0}", test.Volume);


            // foreach loops and arrays
            int[] nums = { 1, 2, 3, 4, 5 };
            // nums.Rank returns the dimensions of the array
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }

        //switch(dataType)
        //{
        // case var:
        // ...
        // default:
        //}

    }

    class Box
    {
        public int length;
        //private int width;
        private int height;

        public Box(int length, int width, int height)
        {
            this.length = length;
            Width = width;
            Height = height;
        }

        // get/set for private member height
        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                if(value < 0)
                {
                    throw new Exception("Height can not be negative");
                }
                else
                {
                    height = value;
                }
            }
        }

        // automatic get/set for private member width
        public int Width { get; set; }

        public int Volume
        { 
            get { return height * Width * length; }
        }
    }
}
