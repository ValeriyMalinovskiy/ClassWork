using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019Apr27
{
    class Pupil
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly DateTime dateOfBirth;
        private int schoolNumber;
        private string className;

        public Pupil(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
        }

        public string ClassName
        {
            set
            {
                className = value;
            }
            get
            {
                return className;
            }
        }

        public int SchoolNumber
        {
            set
            {
                schoolNumber = value;
            }
            get
            {
                return schoolNumber;
            }
        }

        public int GetAge()
        {
            return DateTime.Now.Year-dateOfBirth.Year;
        }

        public string GetName()
        {
            return $"{firstName} {lastName}";
        }

        public int GetYear()
        {
            return dateOfBirth.Year;
        }
    }
}
