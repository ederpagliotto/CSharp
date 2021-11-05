using System;

namespace ClasseFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Func = new Funcionario();

            Console.Write("Nome: ");
            Func.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            Func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            Func.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine("Funcionario: " + Func);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcent = double.Parse(Console.ReadLine());
            Func.AumentarSalario(porcent);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + Func);


        }
    }
}
