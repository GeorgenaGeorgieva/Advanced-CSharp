namespace UniqueUsernames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    class Program
    {
        static void Main(string[] args)
        {
            var uniqueUsers = new HashSet<string>();
            
            int countOfNames = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfNames; i++)
            {
                var currentName = Console.ReadLine();
                uniqueUsers.Add(currentName);
            }

            foreach (var user in uniqueUsers)
            {
                Console.WriteLine(user);
            }
        }
    }
}
