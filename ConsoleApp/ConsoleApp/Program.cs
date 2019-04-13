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

            Task2();

            Console.ReadKey();
        }

        static int[] Task1()
        {
            int size = int.Parse(Console.ReadLine());
            int[] myArr = new int[size];
            Random rnd = new Random();
            int maxVal = int.MinValue;
            int minVal = int.MaxValue;
            double sum = 0;

            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = rnd.Next(-10,11);
                if (myArr[i] > maxVal)
                    maxVal = myArr[i];
                if (myArr[i] < minVal)
                    minVal = myArr[i];
                sum += myArr[i];
            }
            //Console.WriteLine("Average: "+(Math.Round((double)(sum / myArr.Length),2)));
            //Console.WriteLine("Max: "+ maxVal);
            //Console.WriteLine("Min: " + minVal);
            //foreach (var item in myArr)
            //{
            //    if (item % 2 != 0)
            //        Console.WriteLine(item);
            //}
            return myArr;
        }

        static void Task2()
        {
            int[] arr = Task1();
            Console.WriteLine("Sample arr:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            string[] inclNum = new string[arr.Length];
            bool isDuplicated = false;
            int uniqueCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                        isDuplicated = true;
                }
                if (!isDuplicated)
                {
                    inclNum[i] = arr[i].ToString();
                    uniqueCount++;
                }
                isDuplicated = false;
            }

            int[] resultArr = new int[uniqueCount];
            uniqueCount = 0;
            for (int i = 0; i < inclNum.Length; i++)
            {
                if (int.TryParse(inclNum[i], out int number))
                {
                    resultArr[uniqueCount] = number;
                    uniqueCount++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Included numbers");
            foreach (var item in resultArr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
