using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_6._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numCollection = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var divider = int.Parse(Console.ReadLine());

            Func<int, bool> operation = num => num % divider != 0;
            Action<int[]> printing = nums => Console.Write(string.Join(" ", nums));

            numCollection = numCollection
                 .Where(operation)
                 .Reverse()
                 .ToArray();

            printing(numCollection);
        }
    }
}
