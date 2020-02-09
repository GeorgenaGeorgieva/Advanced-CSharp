namespace DefiningClasses
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] personalInformation = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = personalInformation[0];
                int age = int.Parse(personalInformation[1]);

                Person currentPerson = new Person(name, age);
                people.Add(currentPerson);
            }

            var sortedList = people
                .Select(x => x)
                .Where(x => x.Age > 30)
                .OrderBy(x => x.Name)
                .ToList();

            foreach (var person in sortedList)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
