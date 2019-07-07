using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._07._07
{
    class Program
    {
        static void Main(string[] args)
        {
            //DeferedExample();

            UndeferedExample();
        }
        static void DeferedExample()
        {
            var employees = new List<Employee>
                {
                    new Employee("Vasaya", "Pupkin", 27, "M", "Intetics"),
                    new Employee("Anton", "Isaev", 28, "M", "Intetics"),
                    new Employee("Elena", "Zub", 24, "F", "Intetics")
                };
            var maleEmployees = employees.Where(e => e.Gender == "M");
            Display(maleEmployees);
            employees.Add(new Employee{FirstName = "Rob", LastName = "Starck", Age = 30, Gender = "M", Company = "Winterfell" });
            Display(maleEmployees);
        }

        static void UndeferedExample()
        {
            var employees = new List<Employee>
                {
                    new Employee("Vasaya", "Pupkin", 27, "M", "Intetics"),
                    new Employee("Anton", "Isaev", 28, "M", "Intetics"),
                    new Employee("Elena", "Zub", 24, "F", "Intetics")
                };
            var maleEmployees = employees.Where(e => e.Gender == "M").ToList();
            Display(maleEmployees);
            employees.Add(new Employee { FirstName = "Rob", LastName = "Starck", Age = 30, Gender = "M", Company = "Winterfell" });
            Display(maleEmployees);
        }

        static void Display(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine("{0},{1}", employee.LastName, employee.FirstName);
                Console.WriteLine("------------------");
            }
        }
    }

    class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string Company { get; set; }

        public Employee()
        {
        }

        public Employee(string firstName, string lastName, int age, string gender, string company)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
            this.Company = company;
        }
    }
}
