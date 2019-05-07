using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Employee : User
    {
        private int salary;
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (salary > 0)
                {
                    salary = value;
                }
            }
        }
        public Employee(string name, int age, int salary) : base(name, age)
        {
            Salary = salary;
        }
    }

    class Student : User
    {
        private int scholarship;
        private int year;
        public int Scholarship
        {
            get
            {
                return scholarship;
            }
            set
            {
                scholarship = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public Student(string name, int age, int scholarship, int year) : base(name, age)
        {
        }

        class Driver : Worker
        {
            public int DrivingExperience { get; set; }
            public DrivingLicenseCategory DrivingLicenseCategory { get; set; }
            public Driver(string name, int age, int salary, int drivingExperience, DrivingLicenseCategory drivingLicenseCategory) : base(name, age, salary)
            {

            }
        }

        enum DrivingLicenseCategory
        {
            A,
            B,
            C
        }
    }

}
