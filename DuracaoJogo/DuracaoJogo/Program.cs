using System;

namespace DuracaoJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o horario de inicio e do fim do jogo separados por espaco: ");
            string[] horario = Console.ReadLine().Split();
            int inicio = int.Parse(horario[0]);
            int fim = int.Parse(horario[1]);

            int duracao = 0;
            
            if (inicio > fim)
            {
                duracao = 24 - inicio + fim;
            }
            else
            {
                duracao = fim - inicio;
            }

            Console.WriteLine($"Duracao = {duracao} horas!");
        }
    }
}
