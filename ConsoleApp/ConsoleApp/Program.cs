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
            Task1();

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
    }
}
