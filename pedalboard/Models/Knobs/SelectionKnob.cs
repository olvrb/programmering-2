using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedalboard.Models.Knobs {
    class SelectionKnob : Knob {
        public List<string> Selections = new List<string>();
        public string Selected => Selections[SelectedIndex];

        private int SelectedIndex = 0;

        public void SetSelected(string selection) {
            SelectedIndex = Selections.FindIndex(x => x.Contains(selection));
        }


        // Implement FormatValue method
        public override string FormatValue() => $"{Name}: {Selected}";
    }
}