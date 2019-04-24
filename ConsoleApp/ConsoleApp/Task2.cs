using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Task2
    {
        public static void CurrencyExchange()
        {
            decimal toExchange;
            do
            {
                Console.WriteLine("Enter the amount of money you want to exchange");
            }
            while (decimal.TryParse(Console.ReadLine(), out toExchange) == false);
            Console.WriteLine(decimal.Round(Exchanger(toExchange,true ,"Type the currency to exchange from:\tEUR\tUSD\tUAH"),3));
        }

        static void MessagePrinter (string msg)
        {
            Console.WriteLine(msg);
        }

        static decimal Exchanger (decimal moneyToExchange, bool toUsd, string msg)
        {
            decimal exchangedMoney = 0;
            string message = "Type the currency to exchange to:\tEUR\tUSD\tUAH";
            bool isInputCorrect = false;
            while (!isInputCorrect)
            {
                MessagePrinter(msg);
                switch (Console.ReadLine().ToUpper())
                {
                    case "UAH":
                        {
                            if (toUsd)
                                return exchangedMoney = Exchanger(moneyToExchange / 27, false, message);
                            else
                                return exchangedMoney = moneyToExchange * 27;
                        }
                    case "EUR":
                        {
                            if (toUsd)
                                return exchangedMoney = Exchanger(moneyToExchange / 0.9m, false, message);
                            else
                                return exchangedMoney = moneyToExchange * 0.9m;
                        }
                    case "USD":
                        {
                            if (toUsd)
                                return exchangedMoney = Exchanger(moneyToExchange, false, message);
                            else
                                return exchangedMoney = moneyToExchange;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong input, try again");
                            break;
                        }
                }
            }
            return exchangedMoney;
        }
    }
}
