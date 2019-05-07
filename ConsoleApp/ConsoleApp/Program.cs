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
            //Worker w1 = new Worker("Иван", 25, 1000);
            //Worker W2 = new Worker("Вася", 26, 2000);
            //W2.Age = 0;
            //Console.WriteLine(w1.Salary+W2.Salary);
            //Console.WriteLine(W2.Age);

            Employee e1 = new Employee("Иван",25 , 1000);
            Employee e2 = new Employee("Вася",26 ,2000);
            Console.WriteLine(e1.Salary + e2.Salary);

            Console.ReadKey();
        }
    }
}
