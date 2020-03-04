using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pedalboard.Models.Knobs;

namespace pedalboard.Models
{
    class Pedal : BaseEntity
    {
        public List<Knob> Knobs { get; set; } = new List<Knob>();

        public bool On { get; set; }

        public Pedal AddKnob(Knob knob) {
            Knobs.Add(knob);
            return this;
        }
    }
}
