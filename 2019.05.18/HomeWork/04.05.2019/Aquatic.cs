using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Aquatic : Mammal
    {
        public Aquatic(int age) : base(age)
        {
        }

        public override void Eat(int food)
        {
            this.Weight += food * 4;
        }

        public override void Move(int distance)
        {
            Console.WriteLine($"{this.GetType().Name} dived for {distance} meters");
        }
    }
}
