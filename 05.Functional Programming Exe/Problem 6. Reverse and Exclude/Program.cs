namespace ReverseAndExclude
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] numCollection = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            int divider = int.Parse(Console.ReadLine());

            Func<int, bool> operation = num => num % divider != 0;
            Action<int[]> printing = nums => Console.Write(string.Join(" ", nums));

            numCollection = numCollection
                 .Where(operation)
                 .Reverse()
                 .ToArray();

            printing(numCollection);
        }
    }
}
