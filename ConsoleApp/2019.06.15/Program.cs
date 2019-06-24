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
            MyList<int> myList = new MyList<int>();
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.Clear();
            Console.WriteLine(myList.ToString());
            Console.WriteLine(myList.Contains(8));
        }
    }
}
