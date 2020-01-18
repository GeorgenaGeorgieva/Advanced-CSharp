namespace SwapMethodStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SartUp
    {
        public static List<T> SwapStrings<T>(int firstIndex, int secondIndex, List<T> stringsList)
        {
            var firstElement = stringsList.ElementAt(firstIndex);
            var secondElement = stringsList.ElementAt(secondIndex);
            stringsList[secondIndex] = firstElement;
            stringsList[firstIndex] = secondElement;

            return stringsList;
        }

        public static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());
            List<string> stringsList = new List<string>();

            for (int i = 0; i < countOfLines; i++)
            {
                string inputLine = Console.ReadLine();
                stringsList.Add(inputLine);
            }

            int[] indexes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            SwapStrings<string>(firstIndex, secondIndex, stringsList);

            foreach (var line in stringsList)
            {
                Console.WriteLine($"{line.GetType()}: {line}");
            }
        }
    }
}
