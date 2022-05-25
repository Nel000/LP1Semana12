using System;
using System.Collections.Generic;

namespace HowManyOfThisType
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static int NumberOfItemsOfType<T>(object[] objects)
        {
            foreach (object o in objects)
            {
                if (o is T) return true;
            }
            return false;
        }
    }
}
