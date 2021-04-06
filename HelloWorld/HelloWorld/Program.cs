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
            Console.WriteLine("Hello World!");
            int var = Console.Read();
            Console.WriteLine("ASCII value is {0}:", var);
            Console.ReadKey();
        }
    }
}
