using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNames = int.Parse(Console.ReadLine());
            var uniqueUsers = new HashSet<string>();

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
