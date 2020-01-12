using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_3._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());
            var uniqueChemicalElements = new HashSet<string>();

            for (int i = 0; i < countOfLines; i++)
            {
                var chemicalCompounds = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int k = 0; k < chemicalCompounds.Length; k++)
                {
                    var currentElement = chemicalCompounds[k];
                    uniqueChemicalElements.Add(currentElement);
                }
            }

            uniqueChemicalElements = uniqueChemicalElements
                .OrderBy(x => x)
                .ToHashSet();

            foreach (var element in uniqueChemicalElements)
            {
                Console.Write(element + " ");
            }
        }
    }
}
