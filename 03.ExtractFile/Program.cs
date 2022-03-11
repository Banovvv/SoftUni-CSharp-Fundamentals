using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main()
        {
            string filePath = Console.ReadLine();

            ExtractFile(filePath);
        }

        static void ExtractFile(string filePath)
        {
            int indexOfLastSlash = filePath.LastIndexOf('\\');
            int indexOfLastDot = filePath.LastIndexOf('.');
            string fileName = filePath.Substring(indexOfLastSlash + 1, indexOfLastDot - indexOfLastSlash - 1);
            string fileExtension = filePath.Substring(indexOfLastDot + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }

}
