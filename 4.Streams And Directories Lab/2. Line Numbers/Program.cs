using System;
using System.IO;

namespace File_Operations_2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("Input.txt"))
            {
                using (var writer = new StreamWriter("Output.txt"))
                {
                    var lineNumber = 1;
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        writer.WriteLine($"{lineNumber}. {line}");
                        lineNumber++;
                    }
                }
            }
        }
    }
}
