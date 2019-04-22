using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Task2
    {
        public static void UserInterface()
        {
            decimal dollars = 0;
            Console.WriteLine("Enter the amont");
            decimal toExchange = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Currency to exchange from:\nEURO - press 1\nDOLLAR - press 2\nUAH - press 3");
            string currencyFrom = Console.ReadLine();
            Console.WriteLine($"Currency to exchange to:\nEURO - press 1\nDOLLAR - press 2\nUAH - press 3");
            string currencyTo = Console.ReadLine();

            //switch (currencyFrom)
            //{
            //    //case "1":
            //    //    {

            //    //    }
            //    //default:
            //    //    break;
            //}

            
        }

        // bool = true - convert to dollars.
        static decimal DollarExchange(decimal uah, decimal eur)
        {
            const decimal dollarToUah = 28;
            const decimal dollarToEur = 0.9m;
            if (uah!=0)
            {
                return uah / dollarToUah;
            }
            else if (eur != 0)
            {
                return eur / dollarToEur;
            }
            return 0;
        }

    }
}
