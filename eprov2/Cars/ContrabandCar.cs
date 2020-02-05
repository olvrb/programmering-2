using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eprov2.Cars
{
    class ContrabandCar : Car
    {
        public ContrabandCar() {
            // Generate random amount of passengers between 1 and 4
            Passengers = Generator.Next(1, 4);
            // Generate random amount of contraband items between 1 and 4
            ContrabandAmount = Generator.Next(1, 4);
        }
    }
}
