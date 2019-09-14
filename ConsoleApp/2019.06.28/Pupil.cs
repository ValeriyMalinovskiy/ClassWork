using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._06._28
{
    internal class Pupil
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int School { get; set; }

        public Pupil(string firstName, string lastName, int school)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.School = school;
        }
    }
}
