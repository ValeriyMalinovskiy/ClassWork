using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2019._06._08
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSize = 0;
            var pathString  = @"C:\Windows\System32";
            var directories = Directory.GetDirectories(pathString);
            Console.WriteLine($"there are {directories.Length} directories in {pathString}");

            string[] files = Directory.GetFiles(pathString);

            foreach (var item in files)
            {
                FileInfo fi = new FileInfo(item);
                totalSize += fi.Length;
            }
            Console.WriteLine($"with the total space occupied of {totalSize}");
        }
    }
}
