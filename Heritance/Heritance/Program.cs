using Heritance.Entities;
using System;

namespace Heritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(2288, "Alex Green", 500.00);
            Account acc2 = new SavingsAccount(2211, "Maria Green", 500.00, 0.01);

            acc1.WithDraw(10.00);
            acc2.WithDraw(10.00);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
