using System;

namespace _2019._06._22
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StudentDB studentDB = new StudentDB();
            studentDB.AddStudent(new Student("Vasya", "Pupkin", 2, "A1", "MBA"));
            studentDB.AddStudent(new Student("Ira", "Zayats", 1, "F2", "IT"));
            studentDB.AddStudent(new Student("Vasya", "Pupkin", 2, "F3", "IT"));

            //
            //Search by name check.
            //
            foreach (var item in studentDB.FindStudent("Vasya", "Pupkin"))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //
            //Queue check
            //
            Student tempstudent = new Student("Petya", "Pupkin", 2, "V2", "IT");
            tempstudent.GetTask();
            tempstudent.GetTask();
            tempstudent.CompleteTask();
            tempstudent.GetTask();
            tempstudent.CompleteTask();
            tempstudent.GetTask();
            tempstudent.GetTask();
            tempstudent.CompleteTask();
            tempstudent.GetTask();
            tempstudent.CompleteTask();
            tempstudent.CompleteTask();
            tempstudent.CompleteTask();
            tempstudent.CompleteTask();
            Console.WriteLine();

            //
            //Stack check
            //
            tempstudent.BorrowBook(1);
            tempstudent.BorrowBook(2);
            tempstudent.BorrowBook(3);
            tempstudent.ReturnBook();
            tempstudent.ReturnBook();
            tempstudent.ReturnBook();
            tempstudent.ReturnBook();
        }
    }
}
