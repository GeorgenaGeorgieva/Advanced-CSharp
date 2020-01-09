using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
            Queue<string> queue = new Queue<string>(input);
            int number = int.Parse(Console.ReadLine());
            int counter = 1;

            while (queue.Count > 1)
            {
                var currentChild = queue.Dequeue();

                if (counter % number != 0)
                {
                    queue.Enqueue(currentChild);
                }
                else
                {
                    Console.WriteLine($"Removed {currentChild}");
                }
                counter++;
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
