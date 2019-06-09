using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2019._06._08
{
    class _Task3
    {
        public static void Task3()
        {
            string filePath = @"C:\Temp\userText.txt";
            string fileContents = File.ReadAllText(filePath);
            int wordCount = 1;

            string[] tempArrNewLine = fileContents.Split('\n');
            List<string> tempArr = new List<string>();
            foreach (var item in tempArrNewLine)
            {
                tempArr.AddRange(item.Split(' ').ToList());
            }

            foreach (var item in tempArr)
            {
                if ((item != string.Empty) ^ (!string.IsNullOrWhiteSpace(item)))
                {
                    wordCount++;
                }
            }
            Console.WriteLine($"Words : {wordCount}\nLines : {tempArrNewLine.Length}\nCharacters : {fileContents.Length}");
        }
    }
}
