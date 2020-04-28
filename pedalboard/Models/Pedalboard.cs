using pedalboard.Models.Knobs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedalboard.Models
{
    class Pedalboard : BaseEntity
    {
        public HashSet<Pedal> Pedals { get; set; } = new HashSet<Pedal>();

        public Pedalboard AddPedal(Pedal pedal) {
            Pedals.Add(pedal);
            return this;
        }

        public string Format()
        {
            // Format pedals like  pedal3 <- pedal 2 <- pedal1
            string result = "amp <- ";
            result += Pedals
                .Select(x => $"{x.Name} ({x.FormatKnobs()})")
                .Aggregate((x, y) => $"{x} <- {y}");
            result += " <- line in";
            return result;
        }
    }
}
