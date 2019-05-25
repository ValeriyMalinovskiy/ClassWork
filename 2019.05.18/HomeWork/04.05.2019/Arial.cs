using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Arial : Mammal
    {
        public Arial(int age) : base(age)
        {
        }

        public override void Eat(int food)
        {
            this.Weight += food * 3;
        }

        public override void Move(int distance)
        {
            Console.WriteLine($"{this.GetType().Name} flew for {distance} meters");
        }
    }
}
