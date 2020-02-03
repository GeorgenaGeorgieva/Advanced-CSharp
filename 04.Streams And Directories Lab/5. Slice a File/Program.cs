namespace SliceАFile
{
    using System;
    using System.IO;
    
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfPiece = 4;
            var totalSize = new FileInfo($"sliceMe.txt").Length;
            var sizePerFile = (int)Math.Ceiling(totalSize / numberOfPiece);

            using (var reader = new FileStream($"sliceMe.txt", FileMode.OpenOrCreate))
            {
                for (int i = 1; i <= numberOfPiece; i++)
                {
                    var buffer = new byte[sizePerFile];
                    var readBytes = reader.Read(buffer, 0, sizePerFile);

                    using (var writer = new FileStream($"Part-{i}.txt", FileMode.OpenOrCreate))
                    {
                        writer.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
