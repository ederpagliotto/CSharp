using System;

namespace TriangulosMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com os lados do primeiro triangulo: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os lados do segundo triangulo: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();
            double areaY = y.Area();
            
            Console.WriteLine("Area de X = " + areaX.ToString("F4"));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4"));
            
            if (areaX > areaY)
            {
                Console.WriteLine("Maior Area = X");
            }
            else if (areaY > areaX)
            {
                Console.WriteLine("Maior Area = Y");
            }
            else
            {
                Console.WriteLine("Empate!");
            }
        }
    }
}
