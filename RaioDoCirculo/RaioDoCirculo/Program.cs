using System;

namespace RaioDoCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area, pi = 3.14159;
            Console.Write("Digite o raio do circulo: ");
            raio = double.Parse(Console.ReadLine());
            area = pi * raio * raio;
            Console.Write("Area = " + area.ToString("F4"));
        }
    }
}
