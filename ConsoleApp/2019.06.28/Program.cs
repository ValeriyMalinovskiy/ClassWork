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
            new Employee("Vasya","Pupkin",24,'M',"Oracle"),
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

            Employee[] employees2 = {
            new Employee("Vasiliy","Pupkin",24,'M',"Oracle"),
            new Employee("Anton","Isaev",28,'M',"Intetics"),
            new Employee("Elena","Sosnova",23,'F',"Acompany"),
            new Employee("Valeriy","Belich",29,'M',"Intetics"),
            };

            //string[] tempCollection = employees.Select(e => e.FirstName + e.LastName).ToArray();
            //string[] tempCollection = employees.Where(e => e. FirstName[0] == 'O' && e.Age > 25 && e.Gender == 'F').Select(e => e.LastName).ToArray();
            //tempCollection = employees.SelectMany(e => e).Where(e => e.FirstName.en);

            //ShowAToZ(employees);
            //ShowOlderThan30(employees);
            //ShowFemalesOnly(employees);
            //ShowMalesOnly(employees);
            //ShowFirstNameAndLastName(employees);
            //ShowFemaleLastNameStartingWithOOlderThan20(employees);
            //ShowStaffNumberPerCompany(employees);
            //ShowFirstEmployee(employees);
            //ShowLastEmployee(employees);
            //ShowFirstEmployeeOlderThan25(employees);
            //OlegGoBackToSchool(employees, 3);
            //PrintResult(JoinTwoCollections(employees, employees2));
            //PrintResult(JoinTwoCollectionsNoDuplicates(employees, employees2));
            //PrintResult(JoinTwoCollectionsDuplicates(employees, employees2));
            PrintResult(ConvertTwoCollectionsToListAndAddEmployee(employees, employees2, new Employee("Shawn", "Green", 50, 'M', "Intel")));
        }

        public static void ShowAToZ(IEnumerable<Employee> employees)
        {
            foreach (var item in employees.OrderBy(e => e.FirstName).ThenBy(e => e.LastName))
            {
                Console.WriteLine(item);
            }
        }

        public static void ShowOlderThan30(IEnumerable<Employee> employees)
        {
            foreach (var item in employees.Select(e => e).Where(a => a.Age > 30))
            {
                Console.WriteLine(item);
            }
        }

        public static void ShowFemalesOnly(IEnumerable<Employee> employees)
        {
            foreach (var item in employees.Select(e => e).Where(e => e.Gender == 'F'))
            {
                Console.WriteLine(item);
            }
        }

        public static void ShowMalesOnly(IEnumerable<Employee> employees)
        {
            foreach (var item in employees.Select(e => e).Where(e => e.Gender == 'M'))
            {
                Console.WriteLine(item);
            }
        }

        public static void ShowFirstNameAndLastName(IEnumerable<Employee> employees)
        {
            foreach (var item in employees.Select(e => e.FirstName + " " + e.LastName))
            {
                Console.WriteLine(item);
            }
        }

        public static void ShowFemaleLastNameStartingWithOOlderThan20(IEnumerable<Employee> employees)
        {
            foreach (var item in employees.Where(e => e.FirstName[0] == 'O' && e.Age > 25 && e.Gender == 'F').Select(e => e.LastName))
            {
                Console.WriteLine(item);
            }
        }

        public static void ShowStaffNumberPerCompany(Employee[] employees)
        {
            var tempCollection = employees.Select(e => e.Company).Distinct();
            foreach (var item in tempCollection)
            {
                Console.WriteLine($"{item} {employees.Count(e => e.Company == item)}");
            }
        }

        public static void ShowFirstEmployee(IEnumerable<Employee> employees)
        {
            Console.WriteLine(employees.First<Employee>());
        }

        public static void ShowLastEmployee(IEnumerable<Employee> employees)
        {
            Console.WriteLine(employees.Last<Employee>());
        }

        public static void ShowFirstEmployeeOlderThan25(IEnumerable<Employee> employees)
        {
            Console.WriteLine(employees.First(e => e.Age > 25));
        }

        public static void OlegGoBackToSchool(IEnumerable<Employee> employees, int school)
        {
            Pupil exEmployee  = new Pupil(employees.First(e => e.FirstName == "Oleg").FirstName, employees.First(e => e.FirstName == "Oleg").LastName, school);
        }

        public static IEnumerable<Employee> JoinTwoCollections(IEnumerable<Employee> employees, IEnumerable<Employee> employees2)
        {
            return employees.Concat(employees2);
        }

        public static IEnumerable<Employee> JoinTwoCollectionsNoDuplicates(IEnumerable<Employee> employees, IEnumerable<Employee> employees2)
        {
            return employees.Concat(employees2).Distinct();
        }

        public static IEnumerable<Employee> JoinTwoCollectionsDuplicates(IEnumerable<Employee> employees, IEnumerable<Employee> employees2)
        {
            return employees.Intersect(employees2);
        }

        public static List<Employee> ConvertTwoCollectionsToListAndAddEmployee(IEnumerable<Employee> employees, IEnumerable<Employee> employees2, Employee employee)
        {
            return employees.Concat(employees2).Distinct().Append(employee).ToList();
        }

        public static void PrintResult(IEnumerable<Employee> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }
    }
}

