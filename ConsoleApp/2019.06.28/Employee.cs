using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._06._28
{
    internal class Employee : IEquatable<Employee> 
    {
        internal string FirstName { get; set; }

        internal string LastName { get; set; }

        internal int Age { get; set; }

        internal char Gender { get; set; }

        internal string Company { get; set; }

        internal Employee(string firstName, string lastName, int age, char gender, string company)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
            this.Company = company;
        }

        public bool Equals(Employee other)
        {
            if (this.FirstName == other.FirstName && this.LastName == other.LastName && this.Age == other.Age && this.Gender == other.Gender && this.Company == other.Company)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hashFirstName = this.FirstName == null ? 0 : this.FirstName.GetHashCode();
            int hashLastName = this.LastName == null ? 0 : this.LastName.GetHashCode();
            int hashAge = this.Age.GetHashCode();
            int hashGender = this.Gender.GetHashCode();
            int hashCompany = this.Company == null ? 0 : this.Company.GetHashCode();

            return hashFirstName ^ hashLastName;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
