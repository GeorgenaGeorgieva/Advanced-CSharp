namespace EvenLines
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"text.txt"))
            {
                using (var writer = new StreamWriter(@"Output.txt"))
                {
                    var counter = 0;
                    var symbolsToReplace = new[] { '-', ',', '.', '!', '?' };

                    while (!reader.EndOfStream)
                    {
                        var lines = reader.ReadLine();

                        if (counter % 2 == 0)
                        {
                            var words = lines.Split(' ');

                            for (int i = 0; i < words.Length; i++)
                            {
                                var currentWord = words[i];

                                foreach (var symbol in symbolsToReplace)
                                {
                                    currentWord = currentWord.Replace(symbol, '@');
                                }

                                words[i] = currentWord;
                            }

                            var result = string.Join(" ", words.Reverse());
                            writer.WriteLine(result);
                        }

                        counter++;
                    }
                }
            }
        }
    }
}
