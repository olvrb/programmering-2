using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using pedalboard.Models;
using pedalboard.Models.Knobs;

namespace pedalboard
{
    public partial class Form1 : Form
    {

        Pedalboard pedalboard = new Pedalboard();
        Pedal selectedPedal => Pedalboard_list.SelectedIndex > -1 ? pedalboard.Pedals[Pedalboard_list.SelectedIndex] : null;


        private void Populate()
        {
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
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Populate();
            UpdatePedals();
            UpdateKnobsInfo();
        }

        private void Pedalboard_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateKnobs();
        }

        private void UpdateKnobs()
        {
            if (selectedPedal is null) return;
            foreach (Knob knob in selectedPedal.Knobs)
            {
                Pedal_list.Items.Add(knob.Name);
            }
        }

        private void UpdatePedals()
        {
            foreach (Pedal pedal in pedalboard.Pedals)
            {
                // Pedalboard_list.Items.Add(pedal.Name);
            }
        }

        private void Pedal_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateKnobsInfo();
        }

        private void UpdateKnobsInfo()
        {
            pedalinfo_text.Clear();
            pedalinfo_text.Text = pedalboard.Format();
        }

        private void UpdateKnobsInfoDeprecated()
        {
            if (selectedPedal is null) return;
            pedalinfo_text.Clear();

            int index = Pedal_list.SelectedIndex;
            Knob selectedKnob = selectedPedal.Knobs[index];

            pedalinfo_text.Text += $"Value: {selectedKnob.FormatValue()}\n";
        }
    }
}