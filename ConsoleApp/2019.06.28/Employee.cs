﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._06._28
{
    class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public char Gender { get; set; }

        public string Company { get; set; }

        public Employee(string firstName, string lastName, int age, char gender, string company)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
            this.Company = company;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
