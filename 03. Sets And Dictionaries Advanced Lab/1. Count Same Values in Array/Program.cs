using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> commonNumbers = new Dictionary<double, int>();

            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                double currentNumber = input[i];

                if (!commonNumbers.ContainsKey(currentNumber))
                {
                    commonNumbers.Add(currentNumber, 0);
                }
                commonNumbers[currentNumber]++;
            }

            foreach (var kvp in commonNumbers)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
