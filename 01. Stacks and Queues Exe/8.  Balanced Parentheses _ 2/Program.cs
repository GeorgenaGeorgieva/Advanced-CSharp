namespace BalancedParentheses2
{
     using System;
     using System.Linq;
     using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            foreach (var bracket in input)
            {
                if (bracket == '{' || bracket == '(' || bracket == '[')
                {
                    stack.Push(bracket);
                }
                
                if ((bracket == '}' || bracket == ')' || bracket == ']') && stack.Count > 0)
                {
                    bool isValidFirstCase = stack.Peek() == '(' && bracket == ')';
                    bool isValidSecondCase = stack.Peek() == '{' && bracket == '}';
                    bool isValidThirdCase = stack.Peek() == '[' && bracket == ']';

                    if (isValidFirstCase || isValidSecondCase || isValidThirdCase)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
                
                break;
            }
            
            Console.WriteLine("YES");
        }
    }
}
