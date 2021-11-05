using System;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero inteiro: ");
            int N = int.Parse(Console.ReadLine());

            if (N % 2 == 0)
            {
                Console.WriteLine($"O numero {N} e par!");
            }
            else
            {
                Console.WriteLine($"O numero {N} e impar!");
            }
        }
    }
}
