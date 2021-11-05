using System;

namespace MembrosEstaticos2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotacao do dolar? ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Quantos dolares voce vai comprar? ");
            double quantia = double.Parse(Console.ReadLine());

            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

            Console.WriteLine();
            Console.WriteLine("Valor a ser pago em reais : R$ " + result.ToString("F2"));
        }
    }
}
