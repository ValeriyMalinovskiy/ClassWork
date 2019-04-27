using System;

namespace ConsoleApp
{
    public class Task1
    {
        public static void Calculator()
        {
            Console.WriteLine("Enter the first number");
            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Select operation");
            ConsoleKey operation = Console.ReadKey(false).Key;
            Console.WriteLine();
            Console.WriteLine("Enter the second number");
            decimal num2 = decimal.Parse(Console.ReadLine());
            PrintResult(UserInputAnalyzer(operation, num1, num2));
        }

        private static decimal UserInputAnalyzer(ConsoleKey key, decimal num1, decimal num2)
        {
            if (key == ConsoleKey.Add)
            {
                return Add(num1, num2);
            }
            else if (key == ConsoleKey.Subtract)
            {
                return Subtract(num1, num2);
            }
            else if (key == ConsoleKey.Multiply)
            {
                return Multiply(num1, num2);
            }
            else if (key == ConsoleKey.Divide)
            {
                return Divide(num1, num2);
            }
            else Console.WriteLine("invalid input");
            return 0;
        }

        private static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        static decimal Subtract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        static decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        private static decimal Divide(decimal num1, decimal num2)
        {
            try
            {
                return (decimal)num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero");
                return 0;
            }
        }

        private static void PrintResult(decimal res)
        {
            Console.WriteLine(res);
        }
    }

}
