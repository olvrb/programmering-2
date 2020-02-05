using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eprov2.Cars;

namespace eprov2
{
    class Program
    {
        static void Main(string[] args) {
            int amountOfCarsToInitialize = ReadPositiveNumber("How many cars should be created? ");

            // Add an amount of cars to list.
           List<Car> cars = GenerateCars(amountOfCarsToInitialize);

            while (true) {
                int carIndex = ReadPositiveNumber("Which car would you want to look at (starting from 0)? ");

                // Give a default value to stop compiler from yelling at me.
                Car indexedCar = default;

                // Prevent out of bounds index, let user know.
                try {
                    indexedCar = cars[carIndex];
                }
                catch (Exception) {
                    Console.WriteLine("Invalid car.");
                }
                // Check if car is initialized to prevent null ref exception.
                if (indexedCar != null) {
                    // Let the user know if car is clean or not, also make sure the car hasn't been checked before.
                    Console.WriteLine(indexedCar.AlreadyChecked
                        ? "You already checked that car!"
                        : $"That car is {(indexedCar.Examine() ? "clean" : "not clean")}");
                }
            }
        }

        private static List<Car> GenerateCars(int amountOfCarsToInitialize) {
            List<Car> cars = new List<Car>();
            for (int i = 0; i < amountOfCarsToInitialize; i++) {
                // 50% chance of it being a CleanCar or a ContrabandCar
                if (Car.Generator.Next(100) > 50) cars.Add(new CleanCar());
                else cars.Add(new ContrabandCar());
            }

            return cars;
        }

        private static int ReadPositiveNumber(string askString) {
            bool canContinue = false;
            int result = 0;

            // Keep asking for input until the input is a valid positive int.
            while (!canContinue) {
                Console.Write(askString);
                canContinue = int.TryParse(Console.ReadLine(), out result);
                if (result < 0) canContinue = false;
            }

            return result;
        }
    }
}
