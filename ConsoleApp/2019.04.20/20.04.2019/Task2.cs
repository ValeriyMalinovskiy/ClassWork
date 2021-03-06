﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;


namespace _2019Apr20
{
    class Task2
    {
        public static decimal GetUsdRate(string currencyIso)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"C:\Users\vmalinov\Downloads\ClassWork-20.04.2019.zip\ClassWork-20.04.2019\ConsoleApp\ConsoleApp\20.04.2019\USD_rate_to_other_currencies.xlsx",
                0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            range = xlWorkSheet.UsedRange;
            int rw = range.Rows.Count;
            decimal usdRate = 0;
        
            bool isCurrencyFound = false;
            int i = 1;
            while (!isCurrencyFound)
            {
                for (; i < rw; i++)
                {
                    if (xlWorkSheet.Cells[i, 1].Value2.ToString() == currencyIso)
                    {
                        usdRate = Convert.ToDecimal(xlWorkSheet.Cells[i, 3].Value2);
                        xlWorkBook.Close(true, null, null);
                        xlApp.Quit();
                        Marshal.ReleaseComObject(xlWorkBook);
                        Marshal.ReleaseComObject(xlApp);
                        return usdRate;
                    }
                }
                ConsoleMessagePrinter("Wrong currency ISO code. Press Down Arrow to print the list or esc to try again");
                if (Console.ReadKey(true).Key == ConsoleKey.DownArrow)
                {
                    for (int j = 2; j < rw; j++)
                    {
                        Console.WriteLine(xlWorkSheet.Cells[j, 1].Value2 + "\t" + xlWorkSheet.Cells[j, 2].Value2);
                    }
                }
                else
                {
                    i = 1;
                    currencyIso = ConsoleTextToString();
                }
            }
            return 1;
        }

        public static void CurrencyExchange()
        {

            decimal moneyToExchange;
            decimal moneyExchanged;
            do
            {
                ConsoleMessagePrinter("Enter the amount of money you want to exchange");
            }
            while (decimal.TryParse(ConsoleTextToString(), out moneyToExchange) == false);
            moneyExchanged = decimal.Round(Exchanger(moneyToExchange, true, "Type the currency to exchange from:"), 3);
            ConsoleMessagePrinter(moneyExchanged.ToString());
        }

        static void ConsoleMessagePrinter (string msg)
        {
            Console.WriteLine(msg);
        }

        static string ConsoleTextToString()
        {
            return Console.ReadLine().ToUpper();
        }
        //
        //Exchanger firstly converts to USD, then to the desired currency.
        //
        static decimal Exchanger (decimal moneyToExchange, bool isFirstConversion, string msg)
        {
            decimal exchangedMoney = 0;
            string currencyName;
            string message = "Type the currency to exchange to:";
            bool isInputCorrect = false;
            while (!isInputCorrect)
            {
                ConsoleMessagePrinter(msg);
                currencyName = ConsoleTextToString();
                
                if (isFirstConversion)
                    return exchangedMoney = Exchanger(moneyToExchange / GetUsdRate(currencyName), false, message);
                else
                    return exchangedMoney = moneyToExchange * GetUsdRate(currencyName);

            }
            return exchangedMoney;
        }
    }
}
