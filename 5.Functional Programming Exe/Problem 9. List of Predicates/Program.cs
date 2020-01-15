using System;
using System.Linq;
using System.Collections.Generic;
namespace Problem_9._List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var rangeBorder = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Distinct()
                .ToList();

            var numbersToDivide = new List<int>();

            for (int num = 1; num <= rangeBorder; num++)
            {
                var isDivisible = true;

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
