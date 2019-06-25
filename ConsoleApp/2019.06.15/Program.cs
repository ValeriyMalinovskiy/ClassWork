using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._06._15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();

            Task2();
        }

         static void Task1()
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.Clear();
            Console.WriteLine(myList.ToString());
            Console.WriteLine(myList.Contains(8));
        }

        static void Task2()
        {
            CarCollection<Car> carCollection = new CarCollection<Car>();

            carCollection.Add(new Car("Dodge Ram", 2000));
            carCollection.Add(new Car("Lada Kalina", 2010));
            Console.WriteLine(carCollection.Count);
            Console.WriteLine(carCollection["Lada Kalina"].Year);
            Console.WriteLine();
            Console.WriteLine(carCollection.ToString());
        }
    }
}
