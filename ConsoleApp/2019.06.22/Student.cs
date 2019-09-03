using System;
using System.Collections.Generic;
using System.Linq;

namespace _2019._06._22
{
    internal class Student
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
            return this.FirstName + " " + this.LastName + " " + this.Group;
        }

        public void GetTask()
        {
            this.ToDoList.Enqueue(new Task());
        }

        public void CompleteTask()
        {
            if (this.ToDoList.Any())
            {
                Console.WriteLine(this.ToDoList.Peek().CompleteTask());
                this.ToDoList.Dequeue();
            }
            else
            {
                Console.WriteLine("No open tasks");
            }
        }

        public void BorrowBook(int number)
        {
            this.BooksBorrowed.Push(new Book(number));
            Console.WriteLine($"{this.BooksBorrowed.Peek().Name} was borrowed");
        }

        public void ReturnBook()
        {
            if (this.BooksBorrowed.Any())
            {
                Console.WriteLine($"{this.BooksBorrowed.Peek().Name} was returned");
                this.BooksBorrowed.Pop();
            }
            else
            {
                Console.WriteLine("Session is over");
            }
        }
    }
}
