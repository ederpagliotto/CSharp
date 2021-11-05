using System;

namespace Intervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            double N = double.Parse(Console.ReadLine());

            if (N < 0 || N > 100)
            {
                Console.WriteLine("Intervalo invalido!");
            }
            else if (N <= 25)
            {
                Console.WriteLine("Intervalo {0, 25}");
            }
            else if (N <= 50)
            {
                Console.WriteLine("Intervalo {25, 50}");
            }
            else if (N <= 75)
            {
                Console.WriteLine("Intervalo {50, 75}");
            }
            else if (N <= 100)
            {
                Console.WriteLine("Intervalo {75, 100}");
            }
         }
    }
}
