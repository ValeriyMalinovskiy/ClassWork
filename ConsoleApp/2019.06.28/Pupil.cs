using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._06._28
{
    internal class Pupil
    {
        internal string FirstName { get; set; }

        internal string LastName { get; set; }

        internal int School { get; set; }

        internal Pupil(string firstName, string lastName, int school)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.School = school;
        }
    }
}
