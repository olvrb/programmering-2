using pedalboard.Models;
using pedalboard.Models.Knobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedalboard
{
    // Split into another file just for organization
    partial class Form1
    {
        private void Populate()
        {
            pedalboard = new Pedalboard();
            pedalboard.Name = "my board";

            pedalboard2 = new Pedalboard();
            pedalboard2.Name = "my second board";

            Pedal pedal = new Pedal();
            pedal.AddKnob(new SimpleKnob
            {
                Name = "Volume",
                MaxValue = 100,
                Value = 50,
                Pedal = pedal
            });
            pedal.AddKnob(new SelectionKnob
            {
                Name = "Type",
                Selections = new List<string> {
                    "Tape",
                    "Loop"
                },
                Pedal = pedal
            });

            pedal.Name = "Flashback";
            pedal.On = true;
            pedalboard.Pedals.Add(pedal);


            Pedal pedal2 = new Pedal();

            pedal2.AddKnob(new SimpleKnob { Pedal = pedal2, MaxValue = 100, Value = 50, Name = "Volume" });
            pedal2.AddKnob(new SimpleKnob { Pedal = pedal2, MaxValue = 100, Value = 50, Name = "Tone" });
            pedal2.AddKnob(new SimpleKnob { Pedal = pedal2, MaxValue = 100, Value = 50, Name = "Sustain" });

            pedal2.Name = "Big Muff";
            pedal2.On = true;
            pedalboard.Pedals.Add(pedal2);
            pedalboard2.Pedals.Add(pedal2);

            pedalboardLibrary.Add(pedalboard);
            pedalboardLibrary.Add(pedalboard2);

        }

    }
}
