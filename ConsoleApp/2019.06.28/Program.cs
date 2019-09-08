using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._06._28
{
    class Program
    {
        static void Main()
        {
            Task1();
        }

        private static void Task1()
        {
            Employee[] employees = {
            new Employee("Vasya","Pupkin",26,'M',"Oracle"),
            new Employee("Anton","Isaev",28,'M',"Intetics"),
            new Employee("Oleg","Employee",36,'M',"Acompany"),
            new Employee("Valeriy","Belich",29,'M',"Intetics"),
            new Employee("Performer","Top", 24,'F', "Apple"),
            new Employee("Performer","Low", 26,'M', "ATB"),
            new Employee("Olga","Pavlenko", 30, 'F', "AVK"),
            new Employee("Evgeniya","Gladisheva", 32, 'F', "Intetics"),
            new Employee("Self","Employed", 40, 'M', null),
            new Employee("Job","Less", 20, 'F', null)
            };

            IEnumerable<Employee> tempCollection;
            //tempCollection = employees.OrderBy(e => e.FirstName).ThenBy(e => e.LastName);
            //tempCollection = employees.Select(e => e).Where(a => a.Age > 30);
            //tempCollection = employees.Select(e => e).Where(e => e.Gender == 'F');
            //tempCollection = employees.Select(e => e).Where(e => e.Gender == 'M');
            //string[] tempCollection = employees.Select(e => e.FirstName + e.LastName).ToArray();
            //tempCollection = employees.Select(e => e).Where(e => e.FirstName[0] == 'O' && e.Age > 25);
            tempCollection = employees.SelectMany(e => e).Where(e => e.FirstName.en);

            foreach (var item in tempCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}

