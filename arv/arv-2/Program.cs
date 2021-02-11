using System;

namespace arv_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon w = new Rifle();

            Weapon z = new Pistol();

            global::System.Console.WriteLine(w.GetDamage());
            global::System.Console.WriteLine(z.GetDamage());
            Console.WriteLine("Hello World!");
        }
    }
}
