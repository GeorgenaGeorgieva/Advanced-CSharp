namespace HotPotato
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            var queue = new Queue<string>(input);
            
            var number = int.Parse(Console.ReadLine());
            var counter = 1;

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
