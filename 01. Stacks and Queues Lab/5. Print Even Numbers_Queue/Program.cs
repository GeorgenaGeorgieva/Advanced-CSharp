namespace PrintEvenNumbersQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            
            int[] numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0)
                {
                    queue.Enqueue(currentNumber);
                }
            }
            
            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
