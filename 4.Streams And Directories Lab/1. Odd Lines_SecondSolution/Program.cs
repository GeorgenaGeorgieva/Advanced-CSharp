using System;
using System.IO;

namespace File_Operations_1._Odd_Lines_SecondSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleOutput = new StreamWriter("SecondOutput.txt");
            Console.SetOut(consoleOutput);

            using (var reader = new StreamReader($"Input.txt"))
            {
                var counter = 0;

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    if (counter % 2 == 1)
                    {
                        consoleOutput.WriteLine(line);
                    }
                    counter++;
                }
            }
            consoleOutput.Close();
        }
    }
}
