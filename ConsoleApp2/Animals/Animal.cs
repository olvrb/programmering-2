using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Animals
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public abstract void GiveBirth();

        public static string GetFact() {
            return null;
        }
    }
}
