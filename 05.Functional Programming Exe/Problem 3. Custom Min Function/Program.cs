namespace CustomMinFunction
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                 .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList()
                 .Min(x => x)
                 .ToString();

            Console.WriteLine(number);
        }
    }
}
