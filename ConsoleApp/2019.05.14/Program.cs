using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019May14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape s = new Shape();
            //Rectangle r = new Rectangle();
            //Image i = new Image();

            //Employee e = new Employee("Vasya", "Pupkin", "Intetics");
            //e.Display();


        }
    }

    //public class Shape
    //{
    //    public virtual void Draw()
    //    { Console.WriteLine(); }
    //}

    //public class Rectangle : Shape
    //{
    //    public override void Draw()
    //    {
    //        base.Draw();
    //    }
    //}

    //public class Image : Shape
    //{

    //}

    //public class Person
    //{
    //    public string FirstName { get; set; }

    //    public string LastName { get; set; }

    //    public Person(string firstName, string lastName)
    //    {
    //        this.FirstName = firstName;
    //        this.LastName = lastName;
    //    }

    //    public void VirtualDisplay()
    //    {
    //        Console.WriteLine($"{this.FirstName} {this.LastName}");
    //    }

    //    public void NewDisplay()
    //    {
    //        Console.WriteLine($"{this.FirstName} {this.LastName}");
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine($"{this.FirstName} {this.LastName}");
    //    }

    //}
    //public class Employee : Person
    //{
    //    public string Conpany { get; set; }

    //    public Employee(string firstName, string lastName, string company) : base(firstName, lastName)
    //    {
    //        this.FirstName = firstName;
    //        this.LastName = lastName;
    //        this.Conpany = company;
    //    }

    //    public override void Display()
    //    {
    //        base.Display();
    //            Console.WriteLine($"work in company{this.Conpany}");
    //    }
    //}

    public abstract class Vehicle
    {
        protected int licensePlate;
        public int Fuel { get; set; }
        public abstract int LicensePlate { get; set; } 
        public abstract void Move(int meters);
        public virtual void AddFuel(int count)
        {
            this.Fuel += count;
        }
    }

    public class Car: Vehicle
    {
        public override int LicensePlate
        {
            get
            {
                return this.licensePlate;
            }
            set
            {
                this.licensePlate = value;
            }
        }


        public override void Move(int meters)
        {
            Console.WriteLine($"Car is moving");
        }
    }

}
