using System;

namespace QuantidadeItem
{
    class Program
    {
        static void Main(string[] args)
        {
            double hotDog, salada, bacon, torrada, refri;
            Console.WriteLine("Digite o codigo e a quantidade do item separados por espaco: ");
            string[] item = Console.ReadLine().Split();
            int codigo = int.Parse(item[0]);
            int qtd = int.Parse(item[1]);

            double valorTotal = 0.00;
            if (codigo == 1)
            {
                valorTotal = qtd * 4.00;
            }
            if (codigo == 2)
            {
                valorTotal = qtd * 4.50;
            }
            if (codigo == 3)
            {
                valorTotal = qtd * 5.00;
            }
            if (codigo == 4)
            {
                valorTotal = qtd * 2.00;
            }
            if (codigo == 5)
            {
                valorTotal = qtd * 1.50;
            }
            
            Console.WriteLine("Valor Total: " + valorTotal.ToString("F2"));
        }
    }
}
