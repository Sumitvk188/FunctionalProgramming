using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Higherorder
{
    class Program
    {
        static void Main()
        {

            Func<int, int, int> operation = Add; 
            int result = ApplyOperation(operation, 4, 2);
            Console.WriteLine($"Result of applying Add(4, 2): {result}");
        }
        static int ApplyOperation(Func<int, int, int> operation, int x, int y)
        {
            return operation(x, y);
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
