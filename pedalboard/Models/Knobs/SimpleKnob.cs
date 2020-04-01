using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedalboard.Models.Knobs
{
    class SimpleKnob : Knob {
        public int MaxValue;
        public int Value;

        // Implement FormatValue method
        public override string FormatValue() => $"{Name}: {Value}";
    }
}
