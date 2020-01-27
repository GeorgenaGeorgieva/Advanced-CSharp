namespace BasicQueueOperations
{
      using System;
      using System.Collections.Generic;
      using System.Linq;
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            int numberToAdd = input[0];
            int numberToRemove = input[1];
            int element = input[2];

            int[] numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < numberToAdd; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < numberToRemove; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(element))
            {
                Console.WriteLine($"true");
            }
            else
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine($"0");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}
