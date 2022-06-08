using System;

namespace MyEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Guarda3<string> valString = new Guarda3<string>();
            Guarda3<float> valFloat = new Guarda3<float>();

            valString.SetItem(0, "Hello world");
            valFloat.SetItem(0, 25.7f);

            foreach (string s in valString)
                Console.WriteLine(s);

            foreach (float f in valFloat)
                Console.WriteLine(f);
        }
    }
}
