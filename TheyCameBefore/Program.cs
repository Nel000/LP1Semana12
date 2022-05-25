using System;
using System.Collections.Generic;

namespace TheyCameBefore
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> intItems = new List<int>()
            {
                5, 7, 12, 24, 48
            };

            IEnumerable<string> stringItems = new List<string>()
            {
                "Hello", "world", "!", "I", "am", "a", "list", "of", "strings"
            };

            int intSingle = 96;
            string stringSingle = ".";

            IEnumerable<int> mergedInts = ListItemsOfType<int>(
                intItems, intSingle);
            
            IEnumerable<string> mergedStrings = ListItemsOfType<string>(
                stringItems, stringSingle);

            Console.WriteLine("List of ints");
            foreach (int i in mergedInts)
                Console.WriteLine($"- {i}");

            Console.WriteLine();

            Console.WriteLine("List of strings");
            foreach (string s in mergedStrings)
                Console.WriteLine($"- {s}");
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
