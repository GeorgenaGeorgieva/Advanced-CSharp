namespace ListOfPredicates
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            int rangeBorder = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Distinct()
                .ToList();

            List<int> numbersToDivide = new List<int>();

            for (int num = 1; num <= rangeBorder; num++)
            {
                bool isDivisible = true;

                foreach (var divider in dividers)
                {
                    Func<int, bool> isNotDivider = x => num % x != 0;

                    if (isNotDivider(divider))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    numbersToDivide.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", numbersToDivide));
        }
    }
}
