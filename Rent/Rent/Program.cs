using System;

namespace Rent
{
    class Program
    {
        static void Main(string[] args)
        {
            Rooms[] vect = new Rooms[10];       //Criacao do vetor
            Console.WriteLine("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)      
            {
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                vect[room] = new Rooms(name, email);     //chamando o construtor
            }

            Console.WriteLine();
            Console.WriteLine("Busy Rooms: ");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);      //se for diferente de null vai exibir.
                }
            }
        }
    }
}
