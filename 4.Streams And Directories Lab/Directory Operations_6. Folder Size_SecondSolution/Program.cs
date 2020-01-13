using System;
using System.IO;

namespace Directory_Operations_6._Folder_Size_SecondSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = GetLength(Environment.CurrentDirectory);
            Console.WriteLine(length);
        }

        static long GetLength(string directory)
        {
            var totalLength = 0L;
            var files = Directory.GetFiles(directory);

            var subDirectories = Directory.GetDirectories(directory);

            foreach (var subDirectory in subDirectories)
            {
                totalLength += GetLength(subDirectory);
            }

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                totalLength += fileInfo.Length;
            }
            return totalLength;
        }
    }
}
