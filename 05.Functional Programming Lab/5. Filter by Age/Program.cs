namespace FilterByAge
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());
            var people = new List<Person>();

            for (int i = 0; i < countOfLines; i++)
            {
                var personInfo = Console.ReadLine()
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var person = new Person();
                person.Name = personInfo[0];
                person.Age = int.Parse(personInfo[1]);

                people.Add(person);
            }

            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            Func<Person, bool> filterPredicate;

                if (condition == "older")
                {
                    filterPredicate = p => p.Age >= age;
                }
                else
                {
                    filterPredicate = p => p.Age < age;
                }

            var formatPrinting = Console.ReadLine();

            Func<Person, string> selectFunc;

            if (formatPrinting == "name age")
            {
                selectFunc = p => $"{p.Name} - {p.Age}";
            }
            else if (formatPrinting == "name")
            {
                selectFunc = p => $"{p.Name}";
            }
            else
            {
                selectFunc = p => $"{p.Age}";
            }
   
            people
                .Where(filterPredicate)
                .Select(selectFunc)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
