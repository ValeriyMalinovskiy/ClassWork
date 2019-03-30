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
            Task4();
            Task5();
            Task6();
        }
        static void Task4()
        {
            short num1 = short.Parse(Console.ReadLine());
            short num2 = short.Parse(Console.ReadLine());
            Console.WriteLine($"{num1}+{num2}={Program.Sum(num1, num2)}");
        }
        static int Sum(int x,int y)
        {
            return x + y;
        }
        static void Task5()
        {
            int i1 = 455;
            int i2 = 84500;
            decimal dec = 7.98845m;
            //
            //Приводим два числа типа int short.
            //
            Console.WriteLine((short)i1);
            Console.WriteLine((short)i2);

            //
            //Приводим число типа decimal к типу int.
            //
            Console.WriteLine((int)dec);
            Console.ReadKey();
        }
        static void Task6()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            double average = (double)(num1 + num2 + num3) / 3;
            Console.WriteLine(average);
        }
    }
}
