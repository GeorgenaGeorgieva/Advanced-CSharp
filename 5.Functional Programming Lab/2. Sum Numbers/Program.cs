using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Func<string, int> parser = n => int.Parse(n);

            int[] numbers = input
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .ToArray();

            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());
        }
    }
}
