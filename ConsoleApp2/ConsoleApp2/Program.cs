using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int uberflu = 1;
            int _Identifier = 2;
            int \u006fIdentifier = 3;
            int myVar = 4;
            int myVariable = 5;

            const decimal Pi = 3.141592653m;
            const decimal E = 2.7182818284590452m;
            Console.WriteLine($"число Эйлера {E} число Pi {Pi}");
            Console.ReadKey();

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
