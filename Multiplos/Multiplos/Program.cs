using System;

namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite dois numeros inteiros separados por espaco: ");
            string[] numeros = Console.ReadLine().Split(' ');
            int n1 = int.Parse(numeros[0]);
            int n2 = int.Parse(numeros[1]);

                if (n1 % n2 == 0 || n2 % n1 == 0)
                {
                    Console.WriteLine("SAO MULTIPLOS!");
                }
                else
                {
                    Console.WriteLine("NAO SAO MULTIPLOS!");
                }

           

        }
    }
}
