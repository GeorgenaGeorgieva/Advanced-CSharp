namespace BoxOfString
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int countOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfInputs; i++)
            {
                string inputLine = Console.ReadLine();

                Box<string> stringBox = new Box<string>(inputLine);

                Console.WriteLine(stringBox.ToString());
            }
        }
    }
}
