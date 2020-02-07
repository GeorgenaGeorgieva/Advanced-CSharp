namespace PredicateForNames
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfNames = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
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
