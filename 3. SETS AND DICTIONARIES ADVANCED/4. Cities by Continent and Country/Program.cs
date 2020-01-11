using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());
            var continentsContent = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < countOfLines; i++)
            {
                var inputLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string continent = inputLine[0];
                string country = inputLine[1];
                string city = inputLine[2];

                if (!continentsContent.ContainsKey(continent))
                {
                    continentsContent.Add(continent, new Dictionary<string, List<string>>());  
                }

                if (continentsContent.ContainsKey(continent))
                {
                    if (!continentsContent[continent].ContainsKey(country))
                    {
                        continentsContent[continent].Add(country, new List<string>());
                    }
                    continentsContent[continent][country].Add(city);
                }
            }

            foreach (var kvp in continentsContent)
            {
                var continents = kvp.Key;
                var countriesAndCities = kvp.Value;

                Console.WriteLine($"{continents}:");

                foreach (var place in countriesAndCities)
                {
                    var countries = place.Key;
                    var cities = place.Value;

                    Console.WriteLine($"{countries} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}
