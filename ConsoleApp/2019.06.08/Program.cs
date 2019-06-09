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
            Task1();

            //Task2();
        }

        public static void Task1()
        {
            int folderQuantity = 0;
            double folderSize = GetFolderNumberAndSize(@"C:\Windows\System32", ref folderQuantity) / 1073741824;
            Console.WriteLine($"{Math.Round(folderSize, 2)} Gb");
            Console.WriteLine($"{folderQuantity - 1} subfolders counted");
        }

        public static double GetFolderNumberAndSize(string folderPath, ref int folderQuantity)
        {
            double totalSize = 0;
            var directories = Directory.GetDirectories(folderPath);
            foreach (var item in directories)
            {
                try
                {
                    totalSize += GetFolderNumberAndSize(item, ref folderQuantity);
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine($"No access to {item}");
                }
            }

            var files = Directory.GetFiles(folderPath);
            foreach (var item in files)
            {
                FileInfo fi = new FileInfo(item);
                totalSize += fi.Length;
            }
            folderQuantity++;
            return totalSize;
        }

        public static void Task2()
        {
            string pathString = @"C:\Temp\userText.txt";
            if (true)
            {

            }
            if (Directory.Exists(@"C:\Temp\"))
            {

            };
            File.Create(pathString);
        }
    }
}
