using System;

namespace CodigoPecas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre com o codigo, numero de pecas e valor separados por espaco:");
            
            string[] vet1 = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            int a = int.Parse(vet1[0]);
            int b = int.Parse(vet1[1]);
            double c = double.Parse(vet1[2]);

            int d = int.Parse(vet2[0]);
            int e = int.Parse(vet2[1]);
            double f = double.Parse(vet2[2]);

            double total = b * c + e * f;

            Console.Write("Valor Total: $" + total.ToString("F2"));



        }
    }
}
