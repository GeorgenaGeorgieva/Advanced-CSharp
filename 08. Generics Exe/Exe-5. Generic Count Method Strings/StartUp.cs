namespace CountMethodStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int countOfInputLines = int.Parse(Console.ReadLine());
            Box<string> boxWithData = new Box<string>();

            for (int i = 0; i < countOfInputLines; i++)
            {
                var inputLine = Console.ReadLine();
                boxWithData.Elements.Add(inputLine);
            }

            string comparator = Console.ReadLine();

            var result = GetCountOfGreaterElements<string>(boxWithData.Elements, comparator);

            Console.WriteLine(result);
        }

        public static int GetCountOfGreaterElements<T>(List<T> listWithData, T element)
            where T: IComparable
        {
            int counter = 0;

            foreach (var item in listWithData)
            {
                if (item.CompareTo(element) > 0)
                {
                    counter++;
                }
            }
         
            return counter;
        }
    }
}
