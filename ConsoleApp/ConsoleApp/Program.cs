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

            Task2();

            Console.ReadKey();
        }

        static void Task1()
        {
            int size = int.Parse(Console.ReadLine());
            int[] myArr = new int[size];
            Random rnd = new Random();
            int maxVal = int.MinValue;
            int minVal = int.MaxValue;
            double sum = 0;

            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = rnd.Next(0,101);
                if (myArr[i] > maxVal)
                    maxVal = myArr[i];
                if (myArr[i] < minVal)
                    minVal = myArr[i];
                sum += myArr[i];
            }
            Console.WriteLine("Average: "+(Math.Round((double)(sum / myArr.Length),2)));
            Console.WriteLine("Max: "+ maxVal);
            Console.WriteLine("Min: " + minVal);
            foreach (var item in myArr)
            {
                if (item % 2 != 0)
                    Console.WriteLine(item);
            }
        }

        static void Task2()
        {

        }
    }
}
