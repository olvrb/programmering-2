using System;
using System.Collections.Generic;
using System.Linq;

namespace du_ska_va_president
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> countries = new List<Country>();
            while (true)
            {
                Console.Clear();
                if (countries.Count != 0) Console.WriteLine($"Countries presidents: { countries.Select(x => x.President.Name).Aggregate((x, y) => $"{x}, {y}") }");
                Console.Write("Name your president: ");
                countries.Add(new Country(new President(Console.ReadLine()), 24.5m, 50.2m));
            }
        }
    }
}
