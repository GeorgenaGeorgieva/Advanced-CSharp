using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_4._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var condition = Console.ReadLine();

            Func<int, bool> numberInRange;

            if (condition == "odd")
            {
                numberInRange = x => x % 2 != 0;
            }
            else
            {
                numberInRange = x => x % 2 == 0;
            }

            var numbers = new List<int>();

            for (int i = range[0]; i <= range[1]; i++)
            {
                numbers.Add(i);
            }

            Action<int> printingList = x => Console.Write($"{x} ");

            numbers
                .Where(numberInRange)
                .ToList()
                .ForEach(printingList);
        }
    }
}
