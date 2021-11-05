using System;

namespace MaisVelho
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Console.WriteLine("First person data: ");
            Console.Write("Name: ");
            p1.Name = Console.ReadLine();
            Console.Write("Age:");
            p1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Second person data: ");
            Console.Write("Name: ");
            p2.Name = Console.ReadLine();
            Console.Write("Age: ");
            p2.Age = int.Parse(Console.ReadLine());

            if (p1.Age > p2.Age)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Name);
            }
            else if (p2.Age > p1.Age)
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Name);
            }
            else
            {
                Console.WriteLine("As duas pessoas tem a mesma idade!");
            }
        }
    }
}
