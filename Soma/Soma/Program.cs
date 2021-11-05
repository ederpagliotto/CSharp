using System;

namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os numeros para efetuar a soma:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.Write("Soma = " + soma);
        }
    }
}
