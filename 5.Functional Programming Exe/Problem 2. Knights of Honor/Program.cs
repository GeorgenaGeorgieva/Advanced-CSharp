using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_2._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine();
            var title = "Sir";

            Action<string> knighthoodCeremony = x => Console.WriteLine($"{title} {x}");

            names
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(knighthoodCeremony);
        }
    }
}
