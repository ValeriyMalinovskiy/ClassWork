using System;

namespace HomeWork
{
    class Terrestrial : Mammal
    {
        public Terrestrial(int age) : base(age)
        {
        }

        public override void Eat(int food)
        {
            this.Weight += food;
        }

        public override void Move(int distance)
        {
            Console.WriteLine($"{this.GetType().Name} moved for {distance} meters");
        }
    }
}
