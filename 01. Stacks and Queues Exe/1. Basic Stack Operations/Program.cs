namespace BasicStackOperations
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
            
            int elementsToPush = input[0];
            int elementsToPop = input[1];
            int elementsToLook = input[2];

            int[] numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
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
