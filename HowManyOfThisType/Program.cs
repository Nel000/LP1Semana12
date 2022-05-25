using System;
using System.Collections;
using System.Collections.Generic;

namespace HowManyOfThisType
{
    class Program
    {
        static void Main(string[] args)
        {
            int objectNum;

            List<object> objectList = new List<object>();

            int intObj = 5, intObj2 = 7;
            string strObj = "coiso";
            float dblObj = 7.5f;
            char chObj = 'c';
            bool boolObj = true;

            objectList.Add(intObj);
            objectList.Add(intObj2);
            objectList.Add(strObj);
            objectList.Add(dblObj);
            objectList.Add(chObj);
            objectList.Add(boolObj);

            objectNum = NumberOfItemsOfType<int>(objectList);
            Console.WriteLine($"Number of ints:     {objectNum}");
            objectNum = NumberOfItemsOfType<string>(objectList);
            Console.WriteLine($"Number of strings:  {objectNum}");
            objectNum = NumberOfItemsOfType<float>(objectList);
            Console.WriteLine($"Number of floats:   {objectNum}");
            objectNum = NumberOfItemsOfType<char>(objectList);
            Console.WriteLine($"Number of chars:    {objectNum}");
            objectNum = NumberOfItemsOfType<bool>(objectList);
            Console.WriteLine($"Number of bools:    {objectNum}");
        }

        private static int NumberOfItemsOfType<T>(List<object> objects)
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
