using System;

namespace Ternaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor: ");
            double valor = double.Parse(Console.ReadLine());

            double desconto = (valor < 20.0) ? valor * 0.1 : valor * 0.05;

            Console.WriteLine("Valor do desconto: " + desconto);
        }
    }
}
