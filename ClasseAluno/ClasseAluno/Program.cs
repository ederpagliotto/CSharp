using System;

namespace ClasseAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno Aln = new Aluno();

            Console.Write("Nome do aluno: ");
            Aln.Nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno: ");
            Aln.Nota1 = double.Parse(Console.ReadLine());
            Aln.Nota2 = double.Parse(Console.ReadLine());
            Aln.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Nota Final = " + Aln.NotaFinal());

            
            if (Aln.NotaFinal() >= 60.0)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado!");
                Console.WriteLine("Faltaram " + Aln.NotaRestante() + " pontos!");
            }
        }
    }
}
