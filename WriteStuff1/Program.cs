using System;
using System.Collections.Generic;

namespace WriteStuff1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Queue<string> strings = new Queue<string>();

            do
            {
                input = " ";

                input = Console.ReadLine();

                strings.Enqueue(input);
            }
            while (input != "");

            foreach(string s in strings)
            {
                Console.WriteLine(s);
            }
        }
    }
}
