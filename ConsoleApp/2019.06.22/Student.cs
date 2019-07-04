using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._06._22
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Year { get; set; }

        public string Group { get; set; }

        public string Faculty { get; set; }

        public Queue<Task> ToDoList { get; set; }

        public Stack<Book> BooksBorrowed { get; set; }

        public Student(string firstName, string lastName, int year, string group, string faculty)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Year = year;
            this.Group = group;
            this.Faculty = faculty;
            this.ToDoList = new Queue<Task>();
            this.BooksBorrowed = new Stack<Book>();
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

        public void GetTask()
        {
            ToDoList.Enqueue(new Task());
        }

        public void CompleteTask()
        {
            if (ToDoList.Count>0)
            {
                Console.WriteLine(ToDoList.Peek().CompleteTask());
                ToDoList.Dequeue();
            }
            else
            {
                Console.WriteLine("No open tasks");
            }
        }

        public void BorrowBook(int number)
        {
            BooksBorrowed.Push(new Book(number));
            Console.WriteLine($"{BooksBorrowed.Peek().Name} was borrowed");
        }

        public void ReturnBook()
        {
            if (BooksBorrowed.Count>0)
            {
                Console.WriteLine($"{BooksBorrowed.Peek().Name} was returned");
                BooksBorrowed.Pop();
            }
            else
            {
                Console.WriteLine("Session is over");
            }
        }
    }
}
