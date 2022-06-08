using System;
using System.Collections;
using System.Collections.Generic;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T[] val = new T[3];

        public Guarda3()
        {
            for (int i = 0; i < val.Length; i++)
                val[i] = default;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < val.Length; i++)
                yield return val[i];
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            bool itemAdded = false;

            for (int i = 0; i < val.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(val[i], default)
                    && !itemAdded)
                {
                    val[i] = item;
                    itemAdded = true;
                }

            }
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