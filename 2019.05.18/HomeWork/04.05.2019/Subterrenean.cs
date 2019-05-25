using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Subterrenean : Mammal
    {
        public Subterrenean(int age) : base(age)
        {
        }

        public override void Eat(int food)
        {
            this.Weight += food * 2;
        }

        public override void Move(int distance)
        {
            Console.WriteLine($"{this.GetType().Name} dug for {distance} cm deeper");
        }
    }
}
