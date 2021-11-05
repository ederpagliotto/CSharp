using System;

namespace ProdutoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Quantidade de produto a ser adicionado ao estoque: ");
            int adicionar = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(adicionar);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados do produto: " + p);

            Console.WriteLine();
            Console.Write("Quantidade de produto a ser removido do estoque: ");
            int remover = int.Parse(Console.ReadLine());
            p.RemoverProdutos(remover);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados do produto: " + p);
        }
    }
}
