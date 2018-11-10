using System;

namespace Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            const float Pi = 3.14f;
            Console.WriteLine(Pi);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
        }
    }
}
