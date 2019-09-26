using System;

namespace du_ska_va_president
{
    class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country(new President("löfven"), 24.5m, 50.2m);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
