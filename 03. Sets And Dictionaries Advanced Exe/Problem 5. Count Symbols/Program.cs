namespace CountSymbols
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            var characters = new Dictionary<char, int>();
            var inputLine = Console.ReadLine();

            for (int i = 0; i < inputLine.Length; i++)
            {
                var symbol = inputLine[i];

                if (!characters.ContainsKey(symbol))
                {
                    characters.Add(symbol, 0);
                }
                
                characters[symbol]++;
            }

            characters = characters
                .OrderBy(x => x.Key)
                .ToDictionary(s => s.Key, y => y.Value);

            foreach (var kvp in characters)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
