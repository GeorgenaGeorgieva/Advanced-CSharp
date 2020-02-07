namespace CustomComparator
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int, int> compareEven = (a, b) =>
            {
                if (a % 2 == 0 && b % 2 == 0)
                {
                    if (a < b)
                    {
                        return -1;
                    }

                    if (a > b)
                    {
                        return 1;
                    }

                    return 0;
                }

                if (a % 2 != 0 && b % 2 != 0)
                {
                    if (a < b)
                    {
                        return -1;
                    }

                    if (a > b)
                    {
                        return 1;
                    }

                    return 0;
                }

                if (a % 2 == 0)
                {
                    return -1;
                }

                if (a % 2 != 0)
                {
                    return 1;
                }

                return 0;
            };

            Array.Sort(numbers, new Comparison<int>(compareEven));

            Action<int[]> printing = nums => Console.Write(string.Join(" ", nums));

            printing(numbers);
        }
    }
}
