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

        private T[] listItself;

       
        public void Add(T type)
        {
            T[] tempList = new T[Count + 1];
            listItself.CopyTo(tempList, 0);
            tempList[Count] = type;
            listItself = tempList;
            Count++;
        }

        public T this[int index]
        {
            get
            {
                return listItself[index];
            }
        }
    }
}
