using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Carlos");
            list.Add("Patricia");
            list.Add("Jessica");
            list.Add("Miguel");
            list.Add("Kyara");
            list.Add("Leonardo");
            list.Add("Kleber");
            list.Add("Maria");
            

            foreach (string nome in list)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine();
            Console.WriteLine("tamanho da lista: " + list.Count);

            string s1 = list.Find(x => x[0] == 'K');
            Console.WriteLine("Primeiro a comecar com letra K: " + s1);

            string s2 = list.FindLast(x => x[0] == 'K');
            Console.WriteLine("Ultimo a comecar com a letra K: " + s2);

            int p1 = list.FindIndex(x => x[0] == 'K');
            Console.WriteLine("Posicao no index do primeiro nome iniciado com a letra K: " + p1);

            int p2 = list.FindLastIndex(x => x[0] == 'K');
            Console.WriteLine("Posicao no index do ultimo nome a ser iniciado com K: " + p2);

            List<string> resultado = list.FindAll(x => x.Length == 5);
            Console.WriteLine("Todos que tenham 5 letras no nome: ");
            foreach(string obj in resultado)
            {
                Console.WriteLine(obj);
            }
        }

       
    }
}
