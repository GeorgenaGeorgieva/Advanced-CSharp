namespace CountSameValuesInArray
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> commonNumbers = new Dictionary<double, int>();

            double[] input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

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
