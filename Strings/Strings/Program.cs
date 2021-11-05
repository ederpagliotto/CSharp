using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "Hello World! abcd ABCD AbCd     ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();

            Console.WriteLine(original);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
