using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_10.___Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, string, bool> startsWithFunc = (name, pattern) => name.StartsWith(pattern);
            Func<string, string, bool> endsWithFunc = (name, pattern) => name.EndsWith(pattern);
            Func<string, int, bool> lengthFunc = (name, length) => name.Length == length;

            while (true)
            {
                var inputLine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var command = inputLine[0];

                if (command == "Party!")
                {
                    break;
                }
                else
                {
                    var definition = inputLine[1];
                    var specification = inputLine[2];

                    if (command == "Double")
                    {
                        if (definition == "StartsWith")
                        {
                            var temp = names.Where(name => startsWithFunc(name, specification)).ToList();
                            MyAddRange(names, temp);
                        }
                        else if (definition == "EndsWith")
                        {
                            var temp = names.Where(name => endsWithFunc(name, specification)).ToList();
                            MyAddRange(names, temp);
                        }
                        else if(definition == "Length")
                        {
                            var length = int.Parse(specification);
                            var temp = names.Where(name => lengthFunc(name, length)).ToList();
                            MyAddRange(names, temp);
                        }
                    }
                    else if (command == "Remove")
                    {
                        if (definition == "StartsWith")
                        {
                            names = names.Where(name => !startsWithFunc(name, specification)).ToList();
                        }
                        else if (definition == "EndsWith")
                        {
                            names = names.Where(name => !endsWithFunc(name, specification)).ToList();
                        }
                        else if (definition == "Length")
                        {
                            var length = int.Parse(specification);
                            names = names.Where(name => !lengthFunc(name, length)).ToList();
                        }
                    }
                }
            }

            if (names.Count > 0)
            { 
                Console.Write($"{string.Join(", ", names)} are going to the party!");
                return;
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void MyAddRange(List<string> names, List<string> temp)
        {
            foreach (var currentName in temp)
            {
                var index = names.IndexOf(currentName);
                names.Insert(index, currentName);
            }
        }
    }
}
