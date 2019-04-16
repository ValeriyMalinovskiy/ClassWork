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

            //Task2();

            //Task3();

            Task4();

            //Task5();

            Console.ReadKey();
        }

        static int[] GetArray()
        {
            int size = int.Parse(Console.ReadLine());
            int[] myArr = new int[size];
            Random rnd = new Random();
            Console.Clear();
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = rnd.Next(-20, 21);
            }
            Console.WriteLine("Sample array");
            foreach (var item in myArr)
            {
                Console.Write(item + " ");
            }
            return myArr;
        }

        static void Task1()
        {
            int maxVal = int.MinValue;
            int minVal = int.MaxValue;
            double sum = 0;
            int[] myArr = GetArray();
            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] > maxVal)
                    maxVal = myArr[i];
                if (myArr[i] < minVal)
                    minVal = myArr[i];
                sum += myArr[i];
            }
            Console.WriteLine("Average: " + (Math.Round((double)(sum / myArr.Length), 2)));
            Console.WriteLine("Max: " + maxVal);
            Console.WriteLine("Min: " + minVal);
            foreach (var item in myArr)
            {
                if (item % 2 != 0)
                    Console.WriteLine(item);
            }
        }

        static void Task2()
        {
            int[] arr = GetArray();
            string[] inclNum = new string[arr.Length]; //Create string array to fill it with non-duplicated values.
            bool isDuplicated = false;
            int uniqueCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++) //j<i - to search only among previously included numbers
                {
                    if (arr[i] == arr[j]) 
                        isDuplicated = true;
                }
                if (!isDuplicated)
                {
                    inclNum[i] = arr[i].ToString();
                    uniqueCount++;//Counter is subsequently used to create final array.
                }
                isDuplicated = false;
            }

            int[] resultArr = new int[uniqueCount];
            uniqueCount = 0;//Now it is used as an index. 
            for (int i = 0; i < inclNum.Length; i++)
            {
                if (int.TryParse(inclNum[i], out int number))
                {
                    resultArr[uniqueCount] = number;
                    uniqueCount++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Non-duplicate array");
            foreach (var item in resultArr)
            {
                Console.Write(item + " ");
            }
        }

        static void Task5()
        {
            int[] arr = GetArray();
            arr = MyReverse(arr);
            foreach (var item in arr)
            {
                Console.Write(item+" ");
            }
        }

        static int[] MyReverse(int[] arr)
        {
            int[] reversedArr = new int[arr.Length];
            for (int i = 0, j=arr.Length-1; i < arr.Length; i++, j--)
            {
                reversedArr[j] = arr[i];
            }
            return reversedArr;
        }

        static void Task3()
        {
            int[] arr = GetArray();
            int maxVal = 10;
            int minVal = -10;
            Console.WriteLine();
            Console.WriteLine($"Indexes of elements within {minVal} and {maxVal} range:");
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] > minVal && arr[i] < maxVal))
                    Console.Write(i+1 + " ");
            }
        }

        static void Task4()
        {
            int[] arr = GetArray();
            double sum = 0;
            double average = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            average = sum / arr.Length;
            Console.WriteLine();
            Console.WriteLine(average);
            foreach (var item in arr)
            {
                if (item > average)
                    Console.Write(item+" ");
            }
        }
    }
}
