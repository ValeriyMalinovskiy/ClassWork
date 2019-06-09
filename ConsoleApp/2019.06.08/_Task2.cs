using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _2019._06._08
{
    class _Task2
    {
        public static void Task2()
        {
            string folderPath = @"C:\Temp";
            string filePath = @"C:\Temp\userText.txt";
            Directory.CreateDirectory(folderPath);
            File.AppendAllText(filePath, Console.ReadLine());
        }
    }
}
