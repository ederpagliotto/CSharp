using System;

namespace ForEachTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Carlos", "Manoel" };

            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
