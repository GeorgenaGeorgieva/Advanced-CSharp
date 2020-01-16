using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_Strings
{
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
