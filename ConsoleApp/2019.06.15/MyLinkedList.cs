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

        private T tValue;

        private MyLinkedList<T> previousElement;

        private MyLinkedList<T> headElement;

        //private MyLinkedList<T> tempElement;

        public MyLinkedList()
        {
            this.previousElement = null;
        }

        private MyLinkedList(MyLinkedList<T> prev, T tValue)
        {
            try
            {
                this.previousElement = prev;
                prev.tValue = tValue;
            }
            catch (Exception)
            {
            }
        }

        public void Add(T type)
        {
            MyLinkedList<T> newElement = new MyLinkedList<T>(previousElement, tValue);
            this.tValue = type;
            previousElement = newElement;
            this.headElement = newElement;
            this.Count++;
        }
    }
}
