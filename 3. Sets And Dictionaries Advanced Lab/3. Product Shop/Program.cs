using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shopsAndProducts = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "Revision")
                {
                    break;
                }

                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!shopsAndProducts.ContainsKey(shop))
                {
                    shopsAndProducts[shop] = new Dictionary<string, double>();
                }
                shopsAndProducts[shop][product] = price;
            }
            
            foreach (var shops in shopsAndProducts)
            {
                Console.WriteLine($"{shops.Key}->");

                foreach (var product in shops.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
