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

        public MyLinkedList()
        {
            this.previousElement = null;
        }

        private MyLinkedList(MyLinkedList<T> prev, T tValue, int count)
        {
            this.previousElement = prev;
            this.tValue = tValue;
            this.Count = count;
        }

        public void Add(T type)
        {
            MyLinkedList<T> newElement = new MyLinkedList<T>(this.previousElement, this.tValue, this.Count);
            this.tValue = type;
            this.previousElement = newElement;
            this.Count++;
        }

        public void Delete()
        {
            this.tValue = this.previousElement.tValue;
            this.Count = this.previousElement.Count;
            this.previousElement = this.previousElement.previousElement;
        }

        private void GetValues(MyLinkedList<T> myLinkedList, StringBuilder sb)
        {
            sb.Append(this.tValue);
            if (myLinkedList.Count>1)
            {
                sb.Append(" -> ");
                var temp = previousElement;
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
