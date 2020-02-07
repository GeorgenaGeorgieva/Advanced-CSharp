namespace SortEvenNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            var selectedNumbers = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToList();

            Console.Write(string.Join(", ", selectedNumbers));
        }
    }
}
