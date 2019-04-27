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
            //RailwayInfo rwi = new RailwayInfo();
            //rwi.ShowTrainInfo();

            Handler hndlr = new Handler();
            hndlr.Execute();

            Console.ReadKey();
        }
    }
}
 