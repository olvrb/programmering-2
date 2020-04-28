using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Animals
{
    public class Oviparous : Animal
    {
        public override void GiveBirth() {
            Console.WriteLine($"{this.Name} plopped out an egg!");
        }
    }
}
