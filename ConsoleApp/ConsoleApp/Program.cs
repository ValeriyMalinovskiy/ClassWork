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

            Task5();

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
            return "The? string  to       look for ?the symbol";
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
    }
}
