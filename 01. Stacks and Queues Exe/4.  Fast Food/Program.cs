namespace FastFood
{
      using System;
      using System.Collections.Generic;
      using System.Linq;
    
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            
            int[] orders = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            Queue<int> queue = new Queue<int>(orders);

            if (queue.Any())
            {
                Console.WriteLine(queue.Max());
            }

            while (quantityOfFood > 0 && queue.Any())
            {
                int currentOrder = queue.Peek();

                if (quantityOfFood < currentOrder)
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
                    break;
                }
                else
                {
                    quantityOfFood -= currentOrder;
                    queue.Dequeue();
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine($"Orders complete");
            }
        }
    }
}
