using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
            int elementsToPush = int.Parse(input[0]);
            int elementsToPop = int.Parse(input[1]);
            int elementsToLook = int.Parse(input[2]);

            var numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < elementsToPush; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(elementsToLook))
            {
                Console.WriteLine($"true");
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine($"0");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
