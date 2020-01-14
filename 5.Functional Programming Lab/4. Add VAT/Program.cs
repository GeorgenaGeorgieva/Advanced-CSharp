using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => $"{(x * 1.2):F2}")
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
