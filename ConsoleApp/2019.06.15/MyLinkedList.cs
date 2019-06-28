using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._06._15
{
    class MyLinkedList<T>
    {
        public int Count { get; private set; }

        private T previousElement;

        private T currentElement;

        private T tempElement;

        private T nextElement;

        public void Add(T type)
        {
            while (previousElement!=null)
            {
                previousElement = currentElement;
            }
        }


    }
}
