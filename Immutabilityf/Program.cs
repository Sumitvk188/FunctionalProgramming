using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutabilityf
{
    public class Immutabilityf
    {
        static void Main()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };


            var newNumbers = new List<int>(numbers);

            newNumbers.Add(6);

            Console.WriteLine("Original Numbers: " + string.Join(", ", numbers));
            Console.WriteLine("New Numbers: " + string.Join(", ", newNumbers));
        }
    }
}
