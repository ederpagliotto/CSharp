﻿using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial:");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados: " + conta);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: $");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);

            Console.Write("Dados atualizados: " + conta);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);

            Console.Write("Dados atualizados: " + conta);
        }
    }
}
