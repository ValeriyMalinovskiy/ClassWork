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

            Task3();

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
            return "The string to look for the symbol";
        }

        static void Task3()
        {
            string str = GetString();

            StringBuilder sb = new StringBuilder(str);
            sb.Insert(27, "CORRECT ");
            Console.WriteLine(sb);
        }
    }
}
