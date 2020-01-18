namespace BoxOfInteger
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfNumbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                Box<int> integersBox = new Box<int>(currentNumber);

                Console.WriteLine(integersBox.ToString());
            }  
        }
    }
}
