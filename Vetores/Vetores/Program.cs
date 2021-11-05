using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine());
                soma = soma + vet[i];
            }

            double media = soma / n;

            Console.WriteLine("Media = " + media.ToString("F2"));
        }
    }
}
