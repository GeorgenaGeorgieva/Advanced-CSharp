namespace TriFunction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            Func<string, char[]> funcToCharArray = n => n.ToCharArray();
            Func<char, int> castFunc = z => (int)z;
            Func<string, bool> funcFinal = n => funcToCharArray(n).Select(castFunc).Sum() >= inputNumber;

            string[] namesLine = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .FirstOrDefault(funcFinal);

            Console.WriteLine(namesLine);
        }
    }
}
