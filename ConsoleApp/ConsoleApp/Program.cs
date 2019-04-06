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
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            Task8();
        }
        static void Task4()
        {
            short num1 = short.Parse(Console.ReadLine());
            short num2 = short.Parse(Console.ReadLine());
            Console.WriteLine($"{num1}+{num2}={Program.Sum(num1, num2)}");
        }
        static int Sum(int x, int y)
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
        static void Task7()
        {
            const double Pi = 3.14;
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("area = " + Pi * Math.Pow(r, 2));
            Console.ReadKey();
        }
        static void Task8()
        {
            const double Pi = 3.14;
            double r = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            //S=2(PiR^2)+2PiR*h=2PiR(R+h)
            //V = PiR ^ 2 * h
            double s = 2 * Pi * r*(r + h);
            double v = Pi * Math.Pow(r,2) * h;
            Console.WriteLine($"S = {s}\nV = {v}");
            Console.ReadKey();
        }
    }
}
