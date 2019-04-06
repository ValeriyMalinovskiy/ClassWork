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

            //Task3();

            //Task4();

            Task5();

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

        static void Task4()
        {
            int x = 10;
            int y = 12;
            int z = 3;
            x += y - x++ * z;//x*z (30) x=11 then y-(30) then x=11+(-18) . x=-8.
            Console.WriteLine($"x={x}");
        }

        static void Task5()
        {
            Console.WriteLine("Type two numbers");
            double operand1 = Double.Parse(Console.ReadLine());
            double operand2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Choose the operation (+,-,*,/)");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Add:
                    {
                        Console.WriteLine(operand1 + operand2);
                    }
                    break;
                case ConsoleKey.Subtract:
                    {
                        Console.WriteLine(operand1 - operand2);
                    }
                    break;
                case ConsoleKey.Divide:
                    {
                        if (operand2 == 0)
                        {
                            Console.WriteLine("Can't divide by zero");
                            break;
                        }
                        Console.WriteLine(operand1 / operand2);
                    }
                    break;
                case ConsoleKey.Multiply:
                    {
                        Console.WriteLine(operand1 * operand2);
                    }
                    break;
            }
        }
    }
}
