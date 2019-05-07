using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Worker
    {
        public string Name { get; set; }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if ((value>=1)&(value<=100))
                {
                    age = value;
                }
            }
        }
        public int Salary { get; set; }

        public Worker(string name, int age, int salary)
            {
            Name = name;
            Age = age;
            Salary = salary;
            }
    }
}
