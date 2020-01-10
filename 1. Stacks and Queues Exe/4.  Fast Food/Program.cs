using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4.__Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split(" ").Select(int.Parse);
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
