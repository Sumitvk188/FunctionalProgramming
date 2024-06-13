using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purefucntion
{
    class PureFunction
    {
        static int Add(int x, int y) => x + y;

        static void Main()
        {
            int result = Add(4, 2);
            Console.WriteLine($"Result of Add(4, 2): {result}");
        }
    }
}
