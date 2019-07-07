using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._07._07
{
    internal class Task1
    {
        public void DeferedExample()
        {
            var employees = new List<Employee>
                {
                    new Employee("Vasaya", "Pupkin", 27, "M", "Intetics"),
                    new Employee("Anton", "Isaev", 28, "M", "Intetics"),
                    new Employee("Elena", "Zub", 24, "F", "Intetics")
                };
            var maleEmployees = employees.Where(e => e.Gender == "M");
            Display(maleEmployees);
            employees.Add(new Employee { FirstName = "Rob", LastName = "Starck", Age = 30, Gender = "M", Company = "Winterfell" });
            Display(maleEmployees);
        }

        public void UndeferedExample()
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

        private void Display(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine("{0},{1}", employee.LastName, employee.FirstName);
                Console.WriteLine("------------------");
            }
        }
    }
}
