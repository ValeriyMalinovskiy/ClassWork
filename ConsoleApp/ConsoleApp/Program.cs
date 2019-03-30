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
        }
        static void Task4()
        {
            short num1 = 10;
            short num2 = 15;
            Console.WriteLine($"{num1}+{num2}={Program.Sum(num1, num2)}");
        }
        static int Sum(int x,int y)
        {
            return x + y;
        }
    }
}
