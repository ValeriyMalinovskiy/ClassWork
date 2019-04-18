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
            Task2();

            Console.ReadKey();
        }

        static void Task2()
        {
            char symbol = 'o';
            int counter = 0;
            string str = "The string to look for the symbol";
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
    }
}
