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
            Task1();
            Task2();
            Task3();
        }
        static void Task1()
        {
            int uberflu = 1;
            int _Identifier = 2;
            int \u006fIdentifier = 3;
            int myVar = 4;
            int myVariable = 5;
        }
        static void Task2()
        {
            const decimal Pi = 3.141592653m;
            const decimal E = 2.7182818284590452m;
            Console.WriteLine($"число Эйлера {E} число Pi {Pi}");
            Console.ReadKey();
        }
        static void Task3()
        {
            string firstStr = "\nмоя строка1";
            string secodStr = "\tмоя строка2";
            string thirdStr = "\aмоя строка3";

            Console.WriteLine(firstStr);
            Console.WriteLine(secodStr);
            Console.WriteLine(thirdStr);
            Console.ReadKey();
        }



    }
}
