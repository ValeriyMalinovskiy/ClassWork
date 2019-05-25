using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    abstract class Mammal
    {
        private int age;

        private int weight;

        public int Age
        {
            get
            {
                return age;
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }
            protected set
            {
                weight = value;
            }
        }

        public Mammal(int age)
        {
            this.age = age;
        }

        public abstract void Eat(int foodAmount);

        public abstract void Move(int distance);
    }
}
