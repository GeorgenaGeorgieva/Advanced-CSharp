namespace SwapMethodIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());
            Box<int> boxWithNumbers = new Box<int>();

            for (int i = 0; i < countOfLines; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                boxWithNumbers.Elements.Add(currentNumber);
            }

            int[] indexes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            List<int> newSwapedElementsBox = boxWithNumbers.SwapElements(firstIndex, secondIndex);

            foreach (var num in newSwapedElementsBox)
            {
                Console.WriteLine($"{num.GetType()}: {num}");
            }
        }
    }
}
