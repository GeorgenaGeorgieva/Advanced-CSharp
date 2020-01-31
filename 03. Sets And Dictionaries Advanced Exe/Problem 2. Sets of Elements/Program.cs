namespace SetsOfElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            List<int> allNumbers = new List<int>();
            
            int[] countOfLengths = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            int firstSetLength = countOfLengths[0];
            int secondSetLength = countOfLengths[1];

            for (int i = 0; i < firstSetLength; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                firstSet.Add(currentNumber);
                allNumbers.Add(currentNumber);
            }

            for (int k = 0; k < secondSetLength; k++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
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
