using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Animals
{
    public class Mammal : Animal
    {
        public override void GiveBirth() {
            Console.WriteLine($"{this.Name} gave birth!");
        }
    }
}
