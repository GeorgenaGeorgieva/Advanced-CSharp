namespace CitiesByContinentAndCountry
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            var continentsContent = new Dictionary<string, Dictionary<string, List<string>>>();
            
            var countOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfLines; i++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
                var continent = inputLine[0];
                var country = inputLine[1];
                var city = inputLine[2];

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
