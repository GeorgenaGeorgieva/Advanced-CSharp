namespace WordCount
{
    using System;
    using System.IO;
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"words.txt"))
            {
                using (var readSecondFile = new StreamReader(@"text.txt"))
                {
                    using (var writer = new StreamWriter(@"Output.txt"))
                    {
                        var words = new Dictionary<string, int>();

                        while (!reader.EndOfStream)
                        {
                            var currentLine = reader
                                .ReadLine()
                                .Split(' ');

                            for (int i = 0; i < currentLine.Length; i++)
                            {
                                var currentWord = currentLine[i];

                                if (!words.ContainsKey(currentWord))
                                {
                                    words.Add(currentWord, 0);
                                }
                            }
                        }

                        while (!readSecondFile.EndOfStream)
                        {
                            var SecondCurrentLine = readSecondFile
                                .ReadLine()
                                .Split(' ', ',', '-', '.', '?', '!');

                            for (int i = 0; i < SecondCurrentLine.Length; i++)
                            {
                                var currentWord = SecondCurrentLine[i].ToLower();

                                if (words.ContainsKey(currentWord))
                                {
                                    words[currentWord]++;
                                }
                            }
                        }

                        words = words
                            .OrderByDescending(x => x.Value)
                            .ToDictionary(a => a.Key, z => z.Value);

                        foreach (var kvp in words)
                        {
                            writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                        }
                    }
                }
            }
        }
    }
}

