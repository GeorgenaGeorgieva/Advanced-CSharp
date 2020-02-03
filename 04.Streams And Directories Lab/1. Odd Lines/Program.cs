namespace FileOperationsOddLines
{
    using System;
    using System.IO;
    
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader($"Input.txt"))
            {
                using (var writer = new StreamWriter("Output.txt"))
                {
                    var counter = 0 ;

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        
                        if (counter % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        
                        counter++;
                    }
                }
            }
        }
    }
}
