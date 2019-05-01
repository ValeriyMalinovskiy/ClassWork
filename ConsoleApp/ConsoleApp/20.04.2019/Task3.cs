using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Task3
    {
        public static void BankLoanApp()
        {
            Console.WriteLine("Enter the loan sum");
            decimal initialMoney = 0;
            while (!decimal.TryParse((Console.ReadLine()), out initialMoney))
            {
                Console.WriteLine("Incorrect input. Try again.");
                System.Threading.Thread.Sleep(600);
                Console.Clear();
                Console.WriteLine("Enter the loan sum");
            }
            decimal moneyToPayBack = initialMoney;
            decimal moneyPayed = 0;

            Console.WriteLine("Enter the loan period in month");
            int monthToPayback = int.Parse(Console.ReadLine());
            int currentMonth = 0;

            decimal minimumPayment = Math.Round(moneyToPayBack / monthToPayback, 2);
            Console.WriteLine($"Your minimum monthly payment: {minimumPayment}.");
            decimal moneyToPayForNearrestPayment = minimumPayment;

            while (initialMoney != moneyPayed)
            {
                Console.WriteLine("Press P to make payment\nPress S to get loan status");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.P:
                        {
                            MakePayment(ref monthToPayback, ref moneyToPayBack, ref currentMonth, minimumPayment, ref moneyToPayForNearrestPayment, ref moneyPayed, initialMoney);
                            break;
                        }
                    case ConsoleKey.S:
                        {
                            GetLoanStatus(monthToPayback - currentMonth, moneyToPayBack, moneyToPayForNearrestPayment, currentMonth);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Incorrect button. Try again.");
                            System.Threading.Thread.Sleep(600);
                            Console.Clear();
                            break;
                        }
                }
                if (initialMoney == moneyPayed)
                {
                    Console.WriteLine("Congratulations! Your have no debt");
                }
            };
        }

        public static void MakePayment(ref int monthToPayback, ref decimal moneyToPayBack, ref int currentMonth,
                                        decimal minimumPayment, ref decimal moneyToPayForNearrestPayment, ref decimal moneyPayed, decimal initialMoney)
        {
            if(currentMonth==monthToPayback-1)
            {
                decimal payment;
                do
                {
                    Console.WriteLine($"This is the last payment. To pay back the loan you need to pay {initialMoney - moneyPayed}");
                    while(!(decimal.TryParse(Console.ReadLine(), out payment)))
                    {
                        Console.WriteLine("Incorrect input. Try again.");
                    }
                }
                while ((payment != initialMoney - moneyPayed));
                moneyPayed += payment;
            }
            else
            {
                if (moneyToPayForNearrestPayment > 0)
                {
                    Console.WriteLine($"Enter the sum. Current payment must be at least {moneyToPayForNearrestPayment}.");
                }
                else
                {
                    Console.WriteLine("You can skip this payment by paying zero");
                }
                decimal payment;
                while (!decimal.TryParse((Console.ReadLine()), out payment))
                {
                    Console.WriteLine("Incorrect input. Try again.");
                    System.Threading.Thread.Sleep(600);
                    Console.Clear();
                    Console.WriteLine("Enter the payment");
                }
                if (payment + moneyPayed > initialMoney)
                {
                    Console.WriteLine("You can't return more than you took. Payment wasn't processed.");
                }
                else if ((payment >= minimumPayment) || (payment >= moneyToPayForNearrestPayment))
                {
                    moneyToPayBack -= payment;
                    moneyPayed += payment;
                    currentMonth++;
                    moneyToPayForNearrestPayment = currentMonth * minimumPayment + minimumPayment - moneyPayed;
                }
                else
                {
                    Console.WriteLine($"Current payment can't be less than {moneyToPayForNearrestPayment}. Payment wasn't processed.");
                }
            }
        }

        public static void GetLoanStatus(int monthToPayback, decimal moneyToPayBack, decimal moneyToPayForNearrestPayment, int currentMonth)
        {
            if (moneyToPayBack == 0)
            {
                Console.WriteLine("Congratulations! Your have no debt");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Current month: {currentMonth}.");
                Console.WriteLine($"Money to pay back: {moneyToPayBack}");
                Console.WriteLine($"Money for the nearrest payment: {moneyToPayForNearrestPayment}");
                Console.WriteLine($"Month left: {monthToPayback}");
                Console.WriteLine();
            }
        }
    }
}
