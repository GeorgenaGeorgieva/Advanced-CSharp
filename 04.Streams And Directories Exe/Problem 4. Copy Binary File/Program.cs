namespace CopyBinaryFile
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            var totalFileSize = new FileInfo("copyMe.png").Length;

            using (var binaryReader = new FileStream(@"copyMe.png", FileMode.OpenOrCreate, FileAccess.Read))
            {
                var buffer = new byte[totalFileSize];
                var readBytes = binaryReader.Read(buffer, 0, (int)totalFileSize);

                using (var binaryWriter = new FileStream(@"Output.png", FileMode.OpenOrCreate, FileAccess.Write))
                {
                    binaryWriter.Write(buffer, 0, readBytes);
                }
            }
        }
    }
}
