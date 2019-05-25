using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Feeder
    {
        public static void Feed(Mammal[] mammals)
        {
            Random rnd = new Random();
            foreach (var creature in mammals)
            {
                creature.Eat(rnd.Next(1, 10));
                Console.WriteLine($"Current weight is {creature.Weight}");
            }
        }
    }
}
