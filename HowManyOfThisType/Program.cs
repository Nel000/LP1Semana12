using System;
using System.Collections;
using System.Collections.Generic;

namespace HowManyOfThisType
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> objectList = new List<object>();

            int intObj = 5;
            string strObj = "coiso";
            float dblObj = 7.5f;
            char chObj = 'c';
            bool boolObj = true;

            objectList.Add(intObj);
            objectList.Add(strObj);
            objectList.Add(dblObj);
            objectList.Add(chObj);
            objectList.Add(boolObj);
        }

        private static int NumberOfItemsOfType<T>(object[] objects)
        {
            int objectNum = 0;

            foreach (object o in objects)
            {
                if (o is T) objectNum++;
            }
            return objectNum;
        }
    }
}
