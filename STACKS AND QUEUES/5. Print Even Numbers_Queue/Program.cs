using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();

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
