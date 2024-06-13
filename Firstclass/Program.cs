using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstclass
{
    class Firstclass
    {

        public static void Main()
        {

            Func<int, int> operation = Square;   // Assign a function to a variable
            int result = operation(4);
            Console.WriteLine($"Result: {result}");

        }
        static int Square(int x)
        {
            return x * x;
        }
    }
}
