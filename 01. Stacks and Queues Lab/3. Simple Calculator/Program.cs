namespace SimpleCalculator
{
     using System;
     using System.Collections.Generic;
     using System.Linq;
    
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            
            Stack<string> symbols = new Stack<string>(input.Reverse());
            int result = int.Parse(symbols.Pop());

            while (symbols.Any())
            {
                var nextSymbol = symbols.Pop();

                if (nextSymbol == "+")
                {
                    result += int.Parse(symbols.Pop());
                }
                else if (nextSymbol == "-")
                {
                    result -= int.Parse(symbols.Pop());
                }
            }
            
            Console.WriteLine(result);
        }
    }
}
