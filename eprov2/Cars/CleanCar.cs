using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eprov2.Cars
{
    class CleanCar : Car
    {
        public CleanCar() {
            // Generate random amount of passengers between 1 and 3
            Passengers = Generator.Next(1, 3);
            ContrabandAmount = 0;
        }
    }
}
