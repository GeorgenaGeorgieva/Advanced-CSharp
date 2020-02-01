namespace ProductShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    class Program
    {
        static void Main(string[] args)
        {
            var shopsAndProducts = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "Revision")
                {
                    break;
                }

                var shop = input[0];
                var product = input[1];
                var price = double.Parse(input[2]);

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
