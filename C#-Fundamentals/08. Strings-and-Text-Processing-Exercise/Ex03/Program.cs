using System;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            string fileInfo = filePath.Substring(filePath.LastIndexOf("\\") + 1);
            int dotIndex = fileInfo.LastIndexOf('.');
            string fileName = fileInfo.Substring(0, dotIndex);
            string fileExtenson = fileInfo.Substring(dotIndex + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtenson}");
        }
    }
}
