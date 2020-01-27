namespace MaximumAndMinimumElement
{
      using System;
      using System.Collections.Generic;
      using System.Linq;
    
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfQueries = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numberOfQueries; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                
                int currentQuerie = input[0];

                if (currentQuerie == 1)
                {
                    int numberToPush = input[1];
                    
                    if (numberToPush >= 1 && numberToPush <= 109)
                    {
                        stack.Push(numberToPush);
                    }
                }
                else if (currentQuerie == 2 && stack.Any())
                {
                    stack.Pop();
                }
                else if (currentQuerie == 3 && stack.Any())
                {
                    Console.WriteLine(stack.Max());
                }
                else if (currentQuerie == 4 && stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
            }
            
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
