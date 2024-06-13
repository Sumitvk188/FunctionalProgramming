using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functioncomposition
{
    class Program
    {
        static void Main()
        {
            Func<int, int> square = Square;
            Func<int, int> increment = Increment;
            Func<int, int> squareAndIncrement = Compose(square, increment);
            int result = squareAndIncrement(4);
            Console.WriteLine($"Result of composing square and increment: {result}");
        }
        static int Square(int x)
        {
            return x * x;
        }
        static int Increment(int x)
        {
            return x + 1;
        }
        static Func<int, int> Compose(Func<int, int> f1, Func<int, int> f2)
        {
            return x => f2(f1(x));
        }
        
    }
}
