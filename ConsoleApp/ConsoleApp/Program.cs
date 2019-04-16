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

            //Task4();

            //Task5();

            //SubArray(GetArray(), 2,3 );

            //Task7();

            Task8();

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

        static int[] SubArray(int[] array, int index, int count)
        {
            int[] arr = array;
            int[] modifiedArr = new int[count];
            Console.WriteLine();
            for (int i = index, j=0; j < modifiedArr.Length; i++,j++)
            {
                if(j<array.Length-index)
                {
                    modifiedArr[j] = arr[i];
                }
                else
                {
                    modifiedArr[j] = 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Modified array:");
            foreach (var item in modifiedArr)
            {
                Console.Write(item+ " ");
            }
            return modifiedArr;
        }

        static void Task7()
        {
            int[] arr = GetArray();
            //int[] increasedArr = ArrayIncrementor(arr);
            int[] increasedArr = ArrayIncrementor(arr,8);
            Console.WriteLine();
            Console.WriteLine("Increased array:");
            foreach (var item in increasedArr)
            {
                Console.Write(item+" ");
            }
        }

        static int[] ArrayIncrementor (int[] arr)
        {
            int[] increasedArr = new int[arr.Length + 1];
            for (int i = 0; i < increasedArr.Length-1; i++)
            {
                increasedArr[i] = arr[i];
            }
            return increasedArr;
        }

        static int[] ArrayIncrementor(int[] arr, int value)
        {
            int[] increasedArr = new int[arr.Length + 1];
            for (int i = 0; i < increasedArr.Length; i++)
            {
                if (i == 0)
                    increasedArr[i] = value;
                else
                    increasedArr[i] = arr[i-1];
            }
            return increasedArr;
        }

        static int[,] GetTwoDimArray()
        {
            int rows = 4;
            int colunms = 5;
            int[,] arr = new int[rows,colunms];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length/colunms; i++)
            {
                for (int j = 0; j < arr.Length/rows; j++)
                {
                    arr[i, j] = rnd.Next(0, 11);
                    Console.Write(arr[i,j]+"\t");
                }
                Console.WriteLine();
            }
            return arr;
        }

        static void Task8()
        {
            int[,] arr = GetTwoDimArray();
            int valueToSearch = int.Parse(Console.ReadLine());
            int counter = 0;
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j]==valueToSearch)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine($"Value {valueToSearch} is found {counter} times");
        }
    }
}
