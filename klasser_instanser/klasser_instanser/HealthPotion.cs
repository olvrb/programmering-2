using System;
using System.Collections.Generic;
using System.Text;

namespace klasser_instanser
{
    class HealthPotion : Consumable
    {
        private readonly int healthEffect = 10;
        private readonly int energyUse = 75;
        public override int HealthEffect => healthEffect;
        public override int EnergyUse => energyUse;
    }
}
