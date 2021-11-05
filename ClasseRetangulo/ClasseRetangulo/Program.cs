using System;

namespace ClasseRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            Console.WriteLine("Entre com a largura e a altura do retangulo: ");
            ret.Largura = double.Parse(Console.ReadLine());
            ret.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine();


            Console.WriteLine("Area = " + ret.Area().ToString("F2"));
            Console.WriteLine("Perimetro = " + ret.Perimetro().ToString("F2"));
            Console.WriteLine("Diagonal = " + ret.Diagonal().ToString("F2"));
        }
    }
}
