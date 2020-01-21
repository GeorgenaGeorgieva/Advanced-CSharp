namespace CountMethodDoubles
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int countOfInputs = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();

            for (int i = 0; i < countOfInputs; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                box.Add(currentNumber);
            }

            double comparator = double.Parse(Console.ReadLine());
            int result = GetCountOfGreaterElements<double>(box.Elements, comparator);

            Console.WriteLine(result);
        }

        public static int GetCountOfGreaterElements<T>(List<T> listWithData, T comparator)
            where T: IComparable
        {
            int counter = 0;

            foreach (var item in listWithData)
            {
                if (item.CompareTo(comparator) > 0)
                {
                    counter++;
                }
            }
  
            return counter;
        }
    }
}
