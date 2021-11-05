using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.0;

            double a = x ?? 35;
            double b = y ?? 25;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
