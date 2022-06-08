using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        private T[] val = new T[] {val1, val2, val3};

        public Guarda3()
        {
            val1 = default;
            val2 = default;
            val3 = default;
        }

        public T GetItem(int i)
        {
            if (i < 0 || i > 2)
                throw new IndexOutOfRangeException();

            return val[i];
        }

        public void SetItem(int i, T item)
        {
            if (i < 0 || i > 2)
                throw new IndexOutOfRangeException();

            val[i] = item;
        }
    }
}