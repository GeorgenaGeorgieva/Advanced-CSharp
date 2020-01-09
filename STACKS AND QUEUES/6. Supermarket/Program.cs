using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            string input = Console.ReadLine();
            int countOfPeople = 0;
            while (input != "End")
            {
                if (input != "Paid")
                {
                    string currentName = input;
                    queue.Enqueue(currentName);
                    countOfPeople++;
                }
                else
                {
                    while (queue.Any())
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                   countOfPeople = 0;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{countOfPeople} people remaining.");
        }
    }
}
