using System;

namespace DateTimeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;
            DateTime d2 = d.AddDays(7);
           
            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(d2.ToLongDateString());
            
        }
    }
}
