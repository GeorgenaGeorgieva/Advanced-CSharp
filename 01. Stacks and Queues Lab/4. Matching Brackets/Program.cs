namespace MatchingBrackets
{
     using System;
     using System.Collections.Generic;
     using System.Linq;
     using System.Text;
     using System.Globalization;
    
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            string input = Console.ReadLine();
            
            for (int i = 0; i < input.Length; i++)
            {
                string currentSymbol = input[i].ToString();

                if (currentSymbol == "(")
                {
                    stack.Push(i);
                }
                else if (currentSymbol == ")")
                {
                    var openBracketIndex = stack.Pop();
                    Console.WriteLine(input.Substring(openBracketIndex, (i - openBracketIndex + 1))); 
                }
            }
        }
    }
}
