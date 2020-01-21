namespace CreateTuple
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string firstName = input[0];
            string lastName = input[1];
            string address = input[2];

            Tuple<string, string> firstTuple = new Tuple<string, string>(firstName + " " + lastName, address);
            Console.WriteLine(firstTuple);

            input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string name = input[0];
            int litersOfBeer = int.Parse(input[1]);

            Tuple<string, int> secondTuple = new Tuple<string, int>(name, litersOfBeer);
            Console.WriteLine(secondTuple);

            input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int integerNumber = int.Parse(input[0]);
            double doubleNumber = double.Parse(input[1]);

            Tuple<int, double> thirdTuple = new Tuple<int, double>(integerNumber, doubleNumber);
            Console.WriteLine(thirdTuple);
        }
    }
}
