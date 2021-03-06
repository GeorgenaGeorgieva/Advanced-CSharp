namespace FindEvensOrOdds
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] rangeNumbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string condition = Console.ReadLine();

            Func<int, bool> numberInRange;

            if (condition == "odd")
            {
                numberInRange = x => x % 2 != 0;
            }
            else
            {
                numberInRange = x => x % 2 == 0;
            }

            List<int> numbers = new List<int>();

            for (int i = rangeNumbers[0]; i <= rangeNumbers[1]; i++)
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
