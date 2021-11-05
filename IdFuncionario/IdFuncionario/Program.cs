using System;

namespace IdFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Id do funcionario: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());

            Console.Write("Salario por hora: ");
            double salarioHora = double.Parse(Console.ReadLine());

            double salarioTotal = horas * salarioHora;

            Console.WriteLine("Id: " + id);
            Console.WriteLine("Salario total: U$" + salarioTotal.ToString("F2"));
        }
    }
}
