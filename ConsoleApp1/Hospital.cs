using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Animals;

namespace ConsoleApp1 {
    class Hospital {
        public Queue<Animal> Patients => animalQueue;

        private readonly Queue<Animal> animalQueue = new Queue<Animal>();

        public void AdmitAnimal(Animal animal) {
            animalQueue.Enqueue(animal);
        }


        public static void PopulateHospital(Hospital hos) {
            hos.AdmitAnimal(new Cockatiel {Name = "mango"});
            hos.AdmitAnimal(new Lion {Name = "woof"});
            hos.AdmitAnimal(new Dog {Name = "meow"});
            hos.AdmitAnimal(new Parakeet {Name = "kiwi"});
        }
    }
}