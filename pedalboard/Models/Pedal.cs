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


        // Just a useless wrapper
        public Pedal AddKnob(Knob knob)
        {
            Knobs.Add(knob);
            return this;
        }

        public string FormatKnobs()
        {
            string result = "";

            // Cache knob, since we're gonna be accessing it a lot
            Knob lastKnob = Knobs.Last();
            foreach (Knob knob in Knobs)
            {
                // If it's the last in the array, we don't want a comma
                if (knob == lastKnob)
                {
                    result += $"{knob.FormatValue()}";
                }
                else
                {
                    result += $"{knob.FormatValue()}, "; 
                }
            }

            return result;
        }
    }
}
