namespace StackSum
{
     using System;
     using System.Collections.Generic;
     using System.Linq;
    
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            
            string[] numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            
            foreach (var number in numbers)
            {
                stack.Push(int.Parse(number));
            }
            
            while (true)
            {
                string[] comands = Console.ReadLine()
                    .ToLower()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                
                string comand = comands[0];

                if (comand == "end")
                {
                    break;
                }
                else if (comand == "add")
                {
                    int firstNumber = int.Parse(comands[1]);
                    int secondNumber = int.Parse(comands[2]);
                    
                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (comand == "remove")
                {
                    int countOfNumbers = int.Parse(comands[1]);
                    
                    if (stack.Count >= countOfNumbers)
                    {
                        for (int i = 1; i <= countOfNumbers; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
            
            int sumStackNumbers = 0;
            
            foreach (var number in stack)
            {
                sumStackNumbers += number;
            }
            
            Console.WriteLine($"Sum: {sumStackNumbers}");
        }
    }
}
