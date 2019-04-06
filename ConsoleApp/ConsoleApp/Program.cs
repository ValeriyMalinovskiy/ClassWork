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

            //Task6();

            //Task7();

            //Console.ReadKey();
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
            ConsoleKey lastPressedKey;
            do
            {
                Console.WriteLine("Type two numbers");
                try
                {
                    double operand1 = Double.Parse(Console.ReadLine());
                    double operand2 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Choose the operation (+,-,*,/)");
                    lastPressedKey = Console.ReadKey(true).Key;
                    switch (lastPressedKey)
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
                catch
                {
                Console.WriteLine("incorrect input");
                }
                Console.WriteLine("Press any key to continue");
                Console.WriteLine("Press Esc to exit");
                lastPressedKey = Console.ReadKey(true).Key;
                Console.Clear();
            }
            while (lastPressedKey != ConsoleKey.Escape);
        }

        static void Task6()
        {
            int input = Int32.Parse(Console.ReadLine());
            if ((input >= 0) && (input <= 14)) Console.WriteLine("Entered number is within 0 and 14 range");
            else if ((input >= 15) && (input <= 35)) Console.WriteLine("Entered number is within 15 and 35 range");
            else if ((input >= 36) && (input <= 50)) Console.WriteLine("Entered number is within 36 and 50 range");
            if ((input >= 50) && (input <= 100)) Console.WriteLine("Entered number is within 50 and 100 range");
            else if (input<0||input>100) Console.WriteLine("Entered number is outside of any range");
        }

        static void Task7()
        {
            string inputWord = Console.ReadLine();
            switch (inputWord)
            {
                case "дождь":
                    {
                        Console.WriteLine(WeatherWords.rain);
                    }
                    break;
                case "влажность":
                    {
                        Console.WriteLine(WeatherWords.humidity);
                    }
                    break;
                case "туман":
                    {
                        Console.WriteLine(WeatherWords.fog);
                    }
                    break;
                case "давление":
                    {
                        Console.WriteLine(WeatherWords.pressure);
                    }
                    break;
                case "солнце":
                    {
                        Console.WriteLine(WeatherWords.sun);
                    }
                    break;
                case "температура":
                    {
                        Console.WriteLine(WeatherWords.temperature);
                    }
                    break;
                case "ветер":
                    {
                        Console.WriteLine(WeatherWords.wind);
                    }
                    break;
                case "видимость":
                    {
                        Console.WriteLine(WeatherWords.visibility);
                    }
                    break;
                case "облачно":
                    {
                        Console.WriteLine(WeatherWords.overcast);
                    }
                    break;
                case "осадки":
                    {
                        Console.WriteLine(WeatherWords.percipation);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("The word does not exist in DB, sorry");
                    }
                    break;
            }
        }
        enum WeatherWords
        {
            rain,
            sun,
            humidity,
            percipation,
            fog,
            overcast,
            wind,
            pressure,
            temperature,
            visibility
        };      
    }
}
