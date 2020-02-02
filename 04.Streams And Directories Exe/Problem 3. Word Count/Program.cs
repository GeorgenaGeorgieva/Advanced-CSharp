namespace WordCount
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            var allWords = File.ReadAllLines(@"words.txt");
            var allTextLines = File.ReadAllLines(@"text.txt");
            var dictMatchingWords = new Dictionary<string, int>();

            for (int i = 0; i < allWords.Length; i++)
            {
                var currentWord = allWords[i];

                if (!dictMatchingWords.ContainsKey(currentWord))
                {
                    dictMatchingWords.Add(currentWord, 0);
                }
            }

            for (int k = 0; k < allTextLines.Length; k++)
            {
                var currentTextLine = allTextLines[k].Split(' ', ',', '?', '!', '-', '.');

                for (int m = 0; m < currentTextLine.Length; m++)
                {
                    var word = currentTextLine[m].ToLower();

                    if (dictMatchingWords.ContainsKey(word))
                    {
                        dictMatchingWords[word]++;
                    }
                }
            }

            var firstResultPath = @"actualResult.txt";
            PrintingResult(dictMatchingWords, firstResultPath);

            dictMatchingWords = dictMatchingWords
                .OrderByDescending(x => x.Value)
                .ToDictionary(z => z.Key, y => y.Value);

            var secondResultPath = @"expectedResult.txt";
            PrintingResult(dictMatchingWords, secondResultPath);
        }

        static void PrintingResult(Dictionary<string, int> dictMatchingWords, string path)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (var kvp in dictMatchingWords)
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }
        }
    }
}
