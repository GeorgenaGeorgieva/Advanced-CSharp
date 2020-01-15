using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var filesExtension = new Dictionary<string, Dictionary<string, long>>();
            var directory = new DirectoryInfo(Environment.CurrentDirectory);
            var files = directory.GetFiles();

            foreach (var file in files)
            {
                var extension = file.Extension;
                var nameFile = file.Name;
                var lengthFile = file.Length;

                if (!filesExtension.ContainsKey(extension))
                {
                    filesExtension.Add(extension, new Dictionary<string, long>());
                }

                if (!filesExtension[extension].ContainsKey(nameFile))
                {
                    filesExtension[extension].Add(nameFile, lengthFile);
                }
            }

            filesExtension = filesExtension
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(y => y.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            using (var writer = new StreamWriter(@"../../../report.txt"))
            {
                foreach (var kvp in filesExtension)
                {
                    writer.WriteLine(kvp.Key);

                    var orderedBySize = kvp.Value
                        .OrderBy(x => x.Value)
                        .ToDictionary(y => y.Key, z => z.Value);

                    foreach (var fileInfo in orderedBySize)
                    {
                        writer.WriteLine($"--{fileInfo.Key} - {(fileInfo.Value/1024.0):F3}kb");
                    }
                }
            }
        }
    }
}
