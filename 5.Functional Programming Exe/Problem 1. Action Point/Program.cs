using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_1._Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Action<string> printingResult = x => Console.WriteLine(x);

            input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(printingResult);   
        }
    }
}
