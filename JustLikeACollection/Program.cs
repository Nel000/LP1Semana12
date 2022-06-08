using System;

namespace JustLikeACollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Guarda3<string> valString = new Guarda3<string>() 
            { 
                "Hello",
                "World",
                "!",
            };

            Guarda3<float> valFloat = new Guarda3<float>()
            {
                27.5f,
                33.2f,
                51.4f
            };

            foreach (string s in valString)
                Console.WriteLine(s);

            foreach (float f in valFloat)
                Console.WriteLine(f);
        }
    }
}
