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
        public List<Pedal> Pedals { get; set; } = new List<Pedal>();

        public Pedalboard AddPedal(Pedal pedal) {
            Pedals.Add(pedal);
            return this;
        }

        // TODO: remove trailing comma
        public string Format()
        {
            string result = "";

            foreach (Pedal pedal in Pedals)
            {
                Debug.WriteLine(pedal.Name);
                result += $"{pedal.Name} (";

                foreach (Knob knob in pedal.Knobs)
                {
                   
                    result += $"{knob.FormatValue()}, ";
                }
                result += ")";
            }


            return result;
        }
    }
}
