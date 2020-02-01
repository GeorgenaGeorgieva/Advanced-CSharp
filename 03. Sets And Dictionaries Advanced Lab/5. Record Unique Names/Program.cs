namespace RecordUniqueNames
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> uniqueNmaes = new HashSet<string>();
            
            int countOfNames = int.Parse(Console.ReadLine());

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
