using System;
using System.Collections.Generic;

namespace TheyCameBefore
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static IEnumerable<T> ListItemsOfType<T>(
            IEnumerable<T> t, T otherT) where T : IComparable
        {
            foreach (T objT in t)
            {
                yield return objT;
            }

            yield return otherT;
        }
    }
}
