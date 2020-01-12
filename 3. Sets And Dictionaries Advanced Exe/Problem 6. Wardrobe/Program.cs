using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_6._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var inputLine = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                var color = inputLine[0];
                var clothes = inputLine[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int k = 0; k < clothes.Length; k++)
                {
                    var currentClothes = clothes[k];

                    if (!wardrobe[color].ContainsKey(currentClothes))
                    {
                        wardrobe[color].Add(currentClothes, 0);
                    }
                    wardrobe[color][currentClothes]++;
                }
            }

            string[] selectedClothing = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string selectedColor = selectedClothing[0];
            string selectedType = selectedClothing[1];

            foreach (var kvp in wardrobe)
            { 
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var clothes in kvp.Value)
                {
                    if (selectedColor == kvp.Key && selectedType == clothes.Key)
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value}");
                    }
                }
            }
        }
    }
}
