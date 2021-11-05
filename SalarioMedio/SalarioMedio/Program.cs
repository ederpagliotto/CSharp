using System;

namespace SalarioMedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Console.WriteLine("First employee data:");
            Console.Write("Name: ");
            e1.Name = Console.ReadLine();
            Console.Write("Salary: ");
            e1.Salary = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Second employee data:");
            Console.Write("Name: ");
            e2.Name = Console.ReadLine();
            Console.Write("Salary: ");
            e2.Salary = double.Parse(Console.ReadLine());

            double average = (e1.Salary + e2.Salary) / 2.0;

            Console.Write("Average: " + average.ToString("F2") );
        }
    }
}
