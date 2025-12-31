using System;

namespace SharedLibrary1
{
    public class Calculator : MarshalByRefObject
    {
        public int Add(int a, int b)
        {
            Console.WriteLine($"Add called with {a} and {b}");
            return a + b;
        }
    }
}
