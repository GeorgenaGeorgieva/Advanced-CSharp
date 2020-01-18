using System;

namespace GenericScale
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string leftElement = "Pesho";
            string rightElement = "Gosho";

            EqualityScale<string> scaleString = new EqualityScale<string>(leftElement, rightElement);

            Console.WriteLine(scaleString.AreEqual());

            int leftInteger = 5;
            int rightInteger = 5;

            EqualityScale<int> scaleInteger = new EqualityScale<int>(leftInteger, rightInteger);

            Console.WriteLine(scaleInteger.AreEqual());
        }
    }
}
