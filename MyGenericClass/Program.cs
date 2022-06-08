using System;

namespace MyGenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Guarda3<string> valString = new Guarda3<string>();
            Guarda3<float> valFloat = new Guarda3<float>();

            valString.SetItem(0, "Hello world");
            valFloat.SetItem(0, 25.7f);

            Console.WriteLine(valString.GetItem(0));
            Console.WriteLine(valFloat.GetItem(0));
        }
    }
}
