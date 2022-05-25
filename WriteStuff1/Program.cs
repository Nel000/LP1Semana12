using System;
using System.Collections.Generic;
using System.IO;

namespace WriteStuff1
{
    class Program
    {
        private static string filePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            "Test",
            "input.txt");

        static void Main(string[] args)
        {
            string input;

            Queue<string> strings = new Queue<string>();

            Console.WriteLine("Write lines of text to add to a new file.");
            Console.WriteLine("When done, leave an empty line to exit program.");

            Console.WriteLine();

            do
            {
                input = " ";

                Console.Write("> ");

                input = Console.ReadLine();

                if (input != "")
                    strings.Enqueue(input);
            }
            while (input != "");

            File.WriteAllLines(filePath, strings);
        }
    }
}
