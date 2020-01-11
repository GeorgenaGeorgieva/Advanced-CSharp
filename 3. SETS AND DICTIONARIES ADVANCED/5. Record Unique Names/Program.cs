using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNames = int.Parse(Console.ReadLine());
            HashSet<string> uniqueNmaes = new HashSet<string>();

            for (int i = 0; i < countOfNames; i++)
            {
                var name = Console.ReadLine();
                uniqueNmaes.Add(name);
            }

            foreach (var names in uniqueNmaes)
            {
                Console.WriteLine(names);
            }
        }
    }
}
