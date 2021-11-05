using System;

namespace MatPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de linhas e colunas da matriz: ");
            string[] linha = Console.ReadLine().Split(' ');
            int m = int.Parse(linha[0]);
            int n = int.Parse(linha[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine();
            Console.Write("Digite um numero da matriz: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (numero == mat[i,j])
                    {
                        Console.WriteLine("Position " + i + "," + j + ": ");
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Acima: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Abaixo: " + mat [i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
