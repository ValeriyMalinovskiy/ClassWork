using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._06._15
{
    public class MyList<T>
    {
        public int Count { get; private set; }

        private T[] listItself;
        public MyList()
        {
            listItself = new T[1];
        }

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

        public void Clear()
        {
            for (int i = 0; i < Count; i++)
            {
                listItself[i] = default(T);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.GetType().Name + Environment.NewLine + "Elements number: " + Count + Environment.NewLine);
            foreach (var item in listItself)
            {
                sb.Append(item + " ");
            }
            return sb.ToString();
        }

        public bool Contains(T sample)
        {
            foreach (var item in listItself)
            {
                if (item.Equals(sample))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
