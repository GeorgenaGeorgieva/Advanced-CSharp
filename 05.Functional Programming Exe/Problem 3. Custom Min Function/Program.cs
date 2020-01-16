using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_3._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine()
                 .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList()
                 .Min(x => x)
                 .ToString();

            Console.WriteLine(number);
        }
    }
}
