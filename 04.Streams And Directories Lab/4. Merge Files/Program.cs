namespace MergeFiles
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            using (var readerOne = new StreamReader(@"FileOne.txt"))
            {
                using (var readerTwo = new StreamReader(@"FileTwo.txt"))
                {
                    using (var writerOutput = new StreamWriter(@"Output.txt"))
                    {
                        var counter = 1;

                        while (!readerOne.EndOfStream || !readerTwo.EndOfStream)
                        {
                            var currentLine = "";

                            if (counter % 2 == 1)
                            {
                                currentLine = readerOne.ReadLine();
                                writerOutput.WriteLine(currentLine);
                            }
                            else
                            {
                                currentLine = readerTwo.ReadLine();
                                writerOutput.WriteLine(currentLine);
                            }
                            
                            counter++;
                        }
                    }
                }
            }
        }
    }
}
