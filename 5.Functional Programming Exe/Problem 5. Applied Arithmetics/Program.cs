using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_5._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            Func<int, int> operationAdd = x => ++x;
            Func<int, int> operationMultiply = x => x *= 2;
            Func<int, int> operationSubtract = x => --x;
            Action<int[]> printing = nums => Console.WriteLine(string.Join(" ", nums));

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }
                else if (command == "add")
                {
                    numbers = numbers.Select(operationAdd).ToArray();
                }
                else if (command == "multiply")
                {
                    numbers = numbers.Select(operationMultiply).ToArray();
                }
                else if (command == "subtract")
                {
                    numbers = numbers.Select(operationSubtract).ToArray();
                }
                else if (command == "print")
                {
                    printing(numbers);
                }  
            }
        }
    }
}
