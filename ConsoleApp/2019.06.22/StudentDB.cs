using System.Collections.Generic;
using System.Linq;

namespace _2019._06._22
{
    internal class StudentDB
    {
        private Dictionary<string, List<Student>> Students { get; set; }

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

        public bool DeleteStudent(Student student)
        {
            if (this.Students.TryGetValue(student.FirstName + student.LastName, out List<Student> value))
            {
                if (value.Count == 1 && student.Equals(value[0]))
                {
                    this.Students.Remove(student.FirstName + student.LastName);
                    return true;
                }
                else if (value.Count > 1)
                {
                    for (int i = 0; i < this.Students[student.FirstName + student.LastName].Count; i++)
                    {
                        if (student.Equals(value[i]))
                        {
                            this.Students[student.FirstName + student.LastName].RemoveAt(i);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public List<Student> GetStudents()
        {
            List<Student> tempList = new List<Student>();
            foreach (var list in this.Students.Values)
            {
                foreach (var student in list)
                {
                    tempList.Add(student);
                }
            }
            return tempList;
        }

        public int GetStudentsNumber()
        {
            int tempNumber = 0;
            foreach (var list in this.Students.Values)
            {
                tempNumber += list.Count;
            }
            return tempNumber;
        }

        public List<Student> FindStudent(string firstName, string lastName)
        {
            return this.Students[firstName + lastName];
        }
    }
}
