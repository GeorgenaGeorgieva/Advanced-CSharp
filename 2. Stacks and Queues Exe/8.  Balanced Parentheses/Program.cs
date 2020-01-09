using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_8.__Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().Trim().ToCharArray();
            Queue<char> firstPart = new Queue<char>();   //"{[(" - FIFO
            Stack<char> secondPart = new Stack<char>();  //")]}" - LIFO

            if (input.Length % 2 != 0)
            {
                Console.WriteLine($"NO");
                return;
            }

            for (int i = 0; i < (input.Length / 2); i++)
            {
                firstPart.Enqueue(input[i]);
            }

            for (int i = (input.Length / 2); i < input.Length; i++)
            {
                secondPart.Push(input[i]);
            }

            int counter = 0;

            if (secondPart.Count > 0 && secondPart.Count > 0)
            {
                while (firstPart.Any())
                {
                    bool isBalancedFirstCase = firstPart.Peek() == '{' && secondPart.Peek() == '}';
                    bool isBalancedSecondCase = firstPart.Peek() == '[' && secondPart.Peek() == ']';
                    bool isBalancedThirdCase = firstPart.Peek() == '(' && secondPart.Peek() == ')';
                    bool isBalancedForthCase = firstPart.Peek() == '}' && secondPart.Peek() == '{';
                    bool isBalancedFifthCase = firstPart.Peek() == ']' && secondPart.Peek() == '[';
                    bool isBalancedsSixthCase = firstPart.Peek() == ')' && secondPart.Peek() == '(';

                    if (isBalancedFirstCase || isBalancedSecondCase || isBalancedThirdCase || isBalancedForthCase || isBalancedFifthCase || isBalancedsSixthCase)
                    {
                        firstPart.Dequeue();
                        secondPart.Pop();
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine($"NO");
                        return;
                    }
                }

                if (counter == (input.Length / 2))
                {
                    Console.WriteLine($"YES");
                }
            }
        }
    }
}
