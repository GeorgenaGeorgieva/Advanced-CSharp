using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ").ToArray();
            Stack<string> symbols = new Stack<string>(input.Reverse());
            var result = int.Parse(symbols.Pop());

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
