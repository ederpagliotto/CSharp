using System;

namespace ConstrutoresExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Produto prod = new Produto("TV", 500.00, 10);

            prod.Nome = "TV 4K";

            Console.WriteLine("Dados do produto: " + prod);

            

        }
    }
}
