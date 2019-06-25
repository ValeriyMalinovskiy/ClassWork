using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._06._15
{
    class CarCollection<T> where T : Car
    {
        public int Count { get; private set; }

        private T[] collectionItself = new T[1];

        public void Add(T type)
        {
            T[] tempList = new T[Count + 1];
            collectionItself.CopyTo(tempList, 0);
            tempList[Count] = type;
            collectionItself = tempList;
            Count++;
        }

        public T this[string name]
        {
            get
            {
                foreach (var item in collectionItself)
                {
                    if (name.Equals(item.Name))
                    {
                        return item;
                    }
                }
                return default(T);
            }
        }

        public void Clear()
        {
            for (int i = 0; i < Count; i++)
            {
                collectionItself[i] = default(T);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in collectionItself)
            {
                sb.Append(item.Name + " " + item.Year + Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}

