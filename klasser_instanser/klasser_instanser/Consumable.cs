using System;
using System.Collections.Generic;
using System.Text;

namespace klasser_instanser
{
    public abstract class Consumable
    {
        public abstract int HealthEffect { get; }
        public abstract int EnergyUse { get; }

    }
}
