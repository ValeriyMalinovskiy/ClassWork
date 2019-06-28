using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._06._28
{
    class Program
    {
        //    public delegate void MyDelegate();

        //    public static void Method1()
        //    {
        //        Console.WriteLine("Method1");
        //    }

        //    public static void Method2()
        //    {
        //        Console.WriteLine("Method2");
        //    }

        //    public static void Method3()
        //    {
        //        Console.WriteLine("Method3");
        //    }

        //    static void Main()
        //    {
        //        MyDelegate myDelegate = null;
        //        MyDelegate myDelegate1 = new MyDelegate(Method1);
        //        MyDelegate myDelegate2 = new MyDelegate(Method2);
        //        MyDelegate myDelegate3 = new MyDelegate(Method3);

        //        myDelegate = myDelegate1 + myDelegate2 + myDelegate3;

        //        Console.WriteLine("Введите число от 1 до 7");
        //        string choice = Console.ReadLine();

        //        switch (choice)
        //        {
        //            case "1":
        //                {
        //                    myDelegate1.Invoke();
        //                    break;
        //                }
        //            case "2":
        //                {
        //                    myDelegate2.Invoke();
        //                    break;
        //                }
        //            case "3":
        //                {
        //                    myDelegate3.Invoke();
        //                    break;
        //                }
        //            case "4":
        //                {
        //                    MyDelegate myDelegate4 = myDelegate - myDelegate1;
        //                    myDelegate4.Invoke();
        //                    break;
        //                }
        //            case "5":
        //                {
        //                    MyDelegate myDelegate5 = myDelegate - myDelegate2;
        //                    myDelegate5.Invoke();
        //                    break;
        //                }
        //            case "6":
        //                {
        //                    MyDelegate myDelegate6 = myDelegate - myDelegate3;
        //                    myDelegate6.Invoke();
        //                    break;
        //                }
        //            case "7":
        //                {
        //                    myDelegate.Invoke();
        //                    break;
        //                }
        //            default:
        //                {
        //                    Console.WriteLine("Вы ввели недопустимое значение.");
        //                    break;
        //                }
        //        }
        //        Console.ReadKey();
        //    }
        //}

        static void Main(string[] args)
        {
            Helper helper = new Helper();
            var calculator = new Calculator();

            helper.Execute(calculator.Divide);
            helper.Execute(calculator.Add);
            helper.Execute(calculator.Subtract);
            helper.Execute(calculator.Multiply);
        }

        public class Helper
        {
            public void Execute(Func<double, double, double> funk)
            {
                double firstArgument = 10;
                double secondArgument = 20;

                var calculationResult = funk.Invoke(firstArgument, secondArgument);

                Console.WriteLine(calculationResult);
            }
        }

        //public delegate double CalculateDelegate(double firstValue, double secondValue);

        class Calculator
        {
            public double Add(double firstValue, double secondValue)
            {
                return (firstValue + secondValue);
            }
            public double Subtract(double firstValue, double secondValue)
            {
                return (firstValue - secondValue);
            }
            public double Multiply(double firstValue, double secondValue)
            {
                return (firstValue * secondValue);
            }
            public double Divide(double firstValue, double secondValue)
            {
                try
                {
                    return firstValue / secondValue;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("can't divide by zero");
                }
                return 0;
            }
        }
    }
}

