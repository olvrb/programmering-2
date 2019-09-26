using System;
using System.Collections.Generic;
using System.Text;

namespace du_ska_va_president
{
    class Country
    {
        public President President { get; }
        public decimal ValueAddedTax { get; }
        public decimal PetrolTax { get; }

        public Country(President president, decimal valueAddedTax, decimal petrolTax)
        {
            President = president;
            ValueAddedTax = valueAddedTax;
            PetrolTax = petrolTax;
        }
    }
}
