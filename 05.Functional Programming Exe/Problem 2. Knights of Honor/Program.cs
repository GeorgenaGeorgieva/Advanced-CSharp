namespace KnightsOfHonor
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string title = "Sir";

            Action<string> knighthoodCeremony = x => Console.WriteLine($"{title} {x}");

            names
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(knighthoodCeremony);
        }
    }
}
