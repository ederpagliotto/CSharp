using System;

namespace DiferencaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, diferenca;

            Console.WriteLine("Digite 4 numeros inteiros para ser calculada a diferenca.");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            diferenca = A * B - C * D;

            Console.Write("Diferenca = " + diferenca);
        }
    }
}
