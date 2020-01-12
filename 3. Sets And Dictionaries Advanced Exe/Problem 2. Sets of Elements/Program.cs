using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] countOfLengths = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstSetLength = countOfLengths[0];
            int secondSetLength = countOfLengths[1];

            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            List<int> allNumbers = new List<int>();

            for (int i = 0; i < firstSetLength; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                firstSet.Add(currentNumber);
                allNumbers.Add(currentNumber);
            }

            for (int k = 0; k < secondSetLength; k++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                secondSet.Add(currentNumber);
                allNumbers.Add(currentNumber);
            }

            for (int i = 0; i < allNumbers.Count; i++)
            {
                if (!(firstSet.Contains(allNumbers[i]) && secondSet.Contains(allNumbers[i])))
                {
                    firstSet.Remove(allNumbers[i]);
                    secondSet.Remove(allNumbers[i]);
                }
            }

            Console.WriteLine($"{string.Join(" ", firstSet)}");
        }
    }
}
