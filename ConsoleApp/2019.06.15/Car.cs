using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._06._15
{
    class Car
    {
        public string Name { get; }
        public int Year { get; }
        public Car(string name, int year)
        {
            this.Name = name;
            this.Year = year;
        }
    }
}
