﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Arboreal : Mammal
    {
        public Arboreal(int age) : base(age)
        {
        }

        public override void Eat(int food)
        {
            this.Weight += food * 5;
        }
    }
}
