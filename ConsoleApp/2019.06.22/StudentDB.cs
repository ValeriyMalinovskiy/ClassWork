using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._06._22
{
    class StudentDB
    {
        public Dictionary<string, List<Student>> Students{ get; set; }

        public StudentDB()
        {
            this.Students = new Dictionary<string, List<Student>>();
        }

        public void AddStudent(Student student)
        {
            if (this.Students.ContainsKey(student.FirstName + student.LastName))
            {
                this.Students[student.FirstName + student.LastName].Add(student);
            }
            else
            {
                this.Students.Add(student.FirstName + student.LastName, new List<Student>());
                this.Students[student.FirstName + student.LastName].Add(student);
            }
        }

        public List<Student> FindStudent(string firstName, string lastName)
        {
            return this.Students[firstName + lastName];
        }
    }
}
