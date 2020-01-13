using System;
using System.Linq;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Problem_2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"text.txt"))
            {
                using (var writer = new StreamWriter(@"Output.txt"))
                {
                    var counter = 1;

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var words = line.Split(' ');

                        var countOfLetters = 0;
                        var countOfPunctuations = 0;

                        for (int i = 0; i < words.Length; i++)
                        {
                            var currentWord = words[i];

                            for (int k = 0; k < currentWord.Length; k++)
                            {
                                var currentChar = currentWord[k];

                                if (Char.IsLetter(currentChar))
                                {
                                    countOfLetters++;
                                }
                                else if (Char.IsPunctuation(currentChar))
                                {
                                    countOfPunctuations++;
                                }
                            }
                        }

                        writer.WriteLine($"Line {counter}: {line} ({countOfLetters})({countOfPunctuations})");
                        counter++;
                    }
                }
            }
        }
    }
}
