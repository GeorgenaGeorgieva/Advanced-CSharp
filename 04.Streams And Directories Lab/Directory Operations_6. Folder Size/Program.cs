namespace FolderSize
{
    using System;
    using System.IO;
    
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles(@"D:\SoftUni\Advance\04.Streams And Directories\Solutions\Directory Operations_6. Folder Size\TestFolder\TestFolder2\");
            var totalLength = 0L;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                totalLength += fileInfo.Length;
            }

            var inMegabytes = totalLength * 0.00000095367432; //bytes to Megabytes conversation
            Console.WriteLine(inMegabytes);
        }
    }
}
