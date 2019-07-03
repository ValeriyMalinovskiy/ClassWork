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

        public MyLinkedList<T> PreviousElement
        {
            get
            {
                return this.previousElement;
            }
        }

        public MyLinkedList()
        {
            this.previousElement = null;
        }

        private MyLinkedList(MyLinkedList<T> prev, T tValue)
        {
            if (tValue != null)
            {
                this.previousElement = prev;
                prev.tValue = tValue;
            }
        }

        public void Add(T type)
        {
            MyLinkedList<T> newElement = new MyLinkedList<T>(previousElement, tValue);
            this.tValue = type;
            this.previousElement = newElement;
            this.Count++;
        }

        private void GetValues(MyLinkedList<T> myLinkedList, StringBuilder sb)
        {
            sb.Append(this.tValue);
            if (myLinkedList.previousElement != null)
            {
                if (this.tValue != null)
                {
                    sb.Append(" -> ");
                }
                var temp = PreviousElement;
                temp.GetValues(temp, sb);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            GetValues(this.previousElement, sb);
            return sb.ToString();
        }
    }
}
