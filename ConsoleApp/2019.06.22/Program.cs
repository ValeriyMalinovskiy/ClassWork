using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._06._22
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Vasya", "Pupkin", 2, "A1", "MBA"),
                new Student("Ira", "Zayats", 1, "F2", "IT")
            };

            foreach (var item in FindStudent("Vasya", "Pupkin", students))
            {
                Console.WriteLine(item);
            }

            students[0].GetTask();
            students[0].GetTask();
            students[0].CompleteTask();
            students[0].GetTask();
            students[0].CompleteTask();
            students[0].GetTask();
            students[0].GetTask();
            students[0].CompleteTask();
            students[0].GetTask();
            students[0].CompleteTask();
            students[0].CompleteTask();
            students[0].CompleteTask();
            students[0].CompleteTask();

            students[1].BorrowBook(1);
            students[1].BorrowBook(2);
            students[1].BorrowBook(3);
            students[1].ReturnBook();
            students[1].ReturnBook();
            students[1].ReturnBook();
            students[1].ReturnBook();
        }

        public static IEnumerable<Student> FindStudent(string firstName, string lastName, IEnumerable<Student> students)
        {
            return students.Where(student => student.FirstName == firstName && student.LastName == lastName);
        }

    }
}
