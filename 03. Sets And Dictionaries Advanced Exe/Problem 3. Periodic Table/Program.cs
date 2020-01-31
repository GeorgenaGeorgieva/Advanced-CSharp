namespace PeriodicTable
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            var uniqueChemicalElements = new HashSet<string>();
            var countOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfLines; i++)
            {
                var chemicalCompounds = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

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
