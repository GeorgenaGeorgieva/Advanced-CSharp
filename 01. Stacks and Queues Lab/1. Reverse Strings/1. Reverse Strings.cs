namespace Reverse_Strings
{
     using System;
     using System.Collections.Generic;
     using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var symbol in input)
            {
                stack.Push(symbol);
            }

            while (stack.Any())
            {
                Console.Write(stack.Pop());
            }  
        }
    }
}
