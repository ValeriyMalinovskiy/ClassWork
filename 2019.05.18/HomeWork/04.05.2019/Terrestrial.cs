using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
