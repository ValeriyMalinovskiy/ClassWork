using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019Apr20
{
    class Task6
    {
        public static void StringJoiner(string str1, string str2)
        {
            string tempString;
            tempString = AppendNonDuplicatedChars(str1+str2);
            tempString = StringSorter(tempString);
            Console.WriteLine(tempString);
        }

        private static string AppendNonDuplicatedChars(string inStr)
        {
            StringBuilder outStr = new StringBuilder();
            outStr.Append(inStr[0]);
            bool isDuplicagted;
            for (int i = 1; i < inStr.Length; i++)
            {
                isDuplicagted = false;
                for (int j = 0; j < outStr.Length; j++)
                {
                    if (outStr[j] == inStr[i])
                    {
                        isDuplicagted = true;
                    }
                }
                if (!isDuplicagted)
                {
                    outStr.Append(inStr[i]);
                }
            }
            return outStr.ToString();
        }

        private static string StringSorter(string str)
        {
            int[] tempArr = new int[str.Length];
            for (int i = 0; i < tempArr.Length; i++)
            {
                tempArr[i] = (int)str[i];
            }
            Array.Sort(tempArr);
            StringBuilder outStr = new StringBuilder();
            for (int i = 0; i < tempArr.Length; i++)
            {
                outStr.Append((char)tempArr[i]);
            }
            return outStr.ToString();
        }

    }
}
