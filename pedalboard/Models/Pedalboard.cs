using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedalboard.Models
{
    class Pedalboard : BaseEntity
    {
        public List<Pedal> Pedals { get; set; } = new List<Pedal>();

        public Pedalboard AddPedal(Pedal pedal) {
            Pedals.Add(pedal);
            return this;
        }
    }
}
