namespace ActionPoint
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Action<string> printingResult = x => Console.WriteLine(x);

            input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(printingResult);   
        }
    }
}
