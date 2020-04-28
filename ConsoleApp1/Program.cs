using System;
using ConsoleApp1.Animals;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RunHospital();
        }

        static void RunHospital() {
            Hospital hos = new Hospital();
            Hospital.PopulateHospital(hos);
            foreach (Animal animal in hos.Patients) {
                animal.GiveBirth();
            }
        }
    }
}
