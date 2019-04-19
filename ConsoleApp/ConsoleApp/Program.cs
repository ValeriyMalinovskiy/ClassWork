using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task2();

            //Task3();

            //Task4();

            //Task5();

            //Task1();

            //Task6();

            //Task7();

            Task8();

            Console.ReadKey();
        }

        static void Task2()
        {
            char symbol = 'o';
            int counter = 0;
            string str = GetString();
            Console.WriteLine(str);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==symbol)
                {
                    counter++;
                }
            }
            Console.WriteLine($"the {symbol} symbol is encountered {counter} time(s)");
        }

        static string GetString()
        {
            return "The? string to look for ?the symbol";
        }

        static void Task3()
        {
            string str = GetString();

            StringBuilder sb = new StringBuilder(str);
            sb.Insert(27, "CORRECT " +
                "");
            Console.WriteLine(sb);
        }

        static void Task4()
        {
            string str = GetString();
            int firstOccur = str.IndexOf('?');
            int secondOccur = str.LastIndexOf('?');
            for (int i = firstOccur; i < secondOccur; i++)
            {
                firstOccur = str.IndexOf('?');
                secondOccur = str.LastIndexOf('?');
                if (str[i] == ' ')
                {
                    str = str.Remove(i,1);
                }
            }
            Console.WriteLine(str);
        }

        static void Task5()
        {
            string str = GetString();
            string[] tempStrArr = str.Split(' ');
            for (int i = 0; i < tempStrArr.Length; i++)
            {
                if (tempStrArr[i].IndexOf(' ') != -1)
                {
                    tempStrArr[i]=tempStrArr[i].Remove(tempStrArr[i].IndexOf(' '),1);
                }
            }

            string resultStr="";
            foreach (var item in tempStrArr)
            {
                if (!String.IsNullOrWhiteSpace(item))
                {
                    resultStr = resultStr +  item + " ";
                }
            }
            Console.WriteLine(resultStr);
        }

        static void Task1()
        {
            string str = GetString();
            StringBuilder sb = new StringBuilder();
            bool isRepeated = false;
            for (int i = 0; i < str.Length; i++)
            {
                isRepeated = false;
                for (int j=1;j<i;j++)
                {
                    if ((str[i]==str[j]))
                    {
                        isRepeated = true;
                    }
                }
                if (!isRepeated)
                {
                    sb.Append(str[i]);
                }

            }
            Console.WriteLine(sb);
        }

        static void Task6()
        {
            string str = "Nayti slovo, stoyaschee v tekste pod opredelennyim nomerom," +
                " i vyivesti ego pervuyu bukvu.";
            Console.WriteLine(str);
            string[] wordArray = str.Split(' ');
            Console.WriteLine("Enter the number of the word");
            int wordNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(wordArray[wordNumber].ElementAt(0));
        }

        static void Task7()
        {
            string str = GetString();
            string[] arrayToReverse = str.Split(' ');
            string[] reversedString = new string[arrayToReverse.Length];
            for (int i = 0, j= arrayToReverse.Length-1; i < arrayToReverse.Length; i++, j--)
            {
                reversedString[j] = arrayToReverse[i];
            }
            foreach (var item in reversedString)
            {
                Console.Write(item+" ");
            }
        }

        static void Task8()
        {
            string str = GetString();
            string[] auxStringArray = str.Split(' ');
            int longestWord = int.MinValue;
            int shortestWord = int.MaxValue;
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 0; i < auxStringArray.Length; i++)
            {
                if(auxStringArray[i].Length>longestWord)
                {
                    longestWord = auxStringArray[i].Length;
                    maxIndex = i;
                }
                if (auxStringArray[i].Length<shortestWord)
                {
                    shortestWord = auxStringArray[i].Length;
                    minIndex = i;
                }
            }
            Console.WriteLine(str);
            Console.WriteLine($"The shortest word is: {auxStringArray[minIndex]}");
            Console.WriteLine($"The longest word is: {auxStringArray[maxIndex]}");
        }
    }
}
