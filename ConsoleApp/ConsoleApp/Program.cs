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
            //Task1();

            //Task2();

            Task3();

            Console.ReadKey();
        }

        static void Task1()
        {
            int secondsPassed = Int32.Parse(Console.ReadLine());
            //
            //hour=3600 secs.
            //
            int hoursPassed = secondsPassed / 3600;
            Console.WriteLine($"Since midnight {hoursPassed} hours passed");
        }

        static void Task2()
        {
            int numA = Int32.Parse(Console.ReadLine());
            int numB = Int32.Parse(Console.ReadLine());
            int numC = Int32.Parse(Console.ReadLine());
            Console.WriteLine(((numA < numB) && (numB < numC)) ? "True" : "False");
        }

        static void Task3()
        {
            double inputNum = Int32.Parse(Console.ReadLine());
            bool isFirstCond = false;
            bool isSecondCond = false;
            isFirstCond = ((inputNum / 1000 > 0) && (inputNum / 1000 <= 1)) ;
            isSecondCond = (inputNum % 2 == 0);
            if (isFirstCond & isSecondCond) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}
