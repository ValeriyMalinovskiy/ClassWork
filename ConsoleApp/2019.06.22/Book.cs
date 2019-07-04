using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._06._22
{
    class Book
    {
        public string Name { get; private set; }

        public Book(int number)
        {
            this.Name = "Interesting book" + number;
        }
    }
}
