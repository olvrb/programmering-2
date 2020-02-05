using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eprov2.Cars {
    class Car {
        public int Passengers { get; protected set; }
        public int ContrabandAmount { get; protected set; }
        public bool AlreadyChecked { get; set; }

        public static Random Generator { get; } = new Random();

        private bool examinationResult;

        public bool Examine() {
            // if already checked, return last result to save time.
            if (AlreadyChecked) return examinationResult;

            bool result;
            switch (ContrabandAmount) {
                case 0: {
                    // If has no contraband goods, the car is clean.
                    result = false;
                    break;
                }
                case 1: {
                    // 75% chance to miss contraband good
                    result = Generator.Next(100) > 75;
                    break;
                }
                case 2: {
                    // 50% chance to miss contraband
                    result = Generator.Next(100) > 50;
                    break;
                }
                case 3: {
                    // 25% chance to miss contraband
                    result = Generator.Next(100) > 25;
                    break;
                }
                case 4: {
                    // ~12.5% chance to miss contraband
                    result = Generator.Next(100) > 12; // (should be 12.5 but too annoying to deal with floats)
                    break;
                }
                default: {
                    return false;
                }
            }

            // Cache result for later.
            examinationResult = result;
            return result;
        }
    }
}