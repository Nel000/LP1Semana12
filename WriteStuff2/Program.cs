using System;
using System.IO;

namespace WriteStuff2
{
    class Program
    {
        private static string filePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            "Test",
            "input.txt");

        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(filePath);

            string input;

            Console.WriteLine("Write lines of text to add to a new file.");
            Console.WriteLine("When done, leave an empty line to exit program.");

            Console.WriteLine();

            do
            {
                input = " ";

                Console.Write("> ");

                input = Console.ReadLine();

                if (input != "")
                    sw.WriteLine(input);
            }
            while (input != "");

            sw.Close();
        }
    }
}
