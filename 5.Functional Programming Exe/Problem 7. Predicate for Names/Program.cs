using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_7._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            var lengthOfNames = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Func<string, bool> conditionalLength = x => x.Length <= lengthOfNames;
            Action<string> printing = x => Console.WriteLine(x);

            names
                .Where(conditionalLength)
                .ToList()
                .ForEach(printing);
        }
    }
}
