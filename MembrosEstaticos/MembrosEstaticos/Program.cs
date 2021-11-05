using System;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            Console.Write("Valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);
            Console.WriteLine("Circunferencia = " + circ.ToString("F2"));
            Console.WriteLine("Volume = " + vol.ToString("F"));
            Console.WriteLine("Valor de Pi = " + Calculadora.Pi);
        }
    }
}
