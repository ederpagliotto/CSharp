using System;

namespace Negativos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero inteiro: ");
            int N = int.Parse(Console.ReadLine());

            while (N != 0)
            {
                if (N < 0)
                {
                    Console.WriteLine("Numero negativo!");
                }
                else
                {
                    Console.WriteLine("Numero positivo!");
                }
                Console.WriteLine();
                Console.Write("Digite um numero inteiro: ");
                N = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("**********Fim da execucao do programa**********");
            Console.WriteLine();
        }
    }
}
