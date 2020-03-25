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
        PedalboardLibrary pedalboardLibrary = new PedalboardLibrary();
        Pedalboard pedalboard;
        Pedalboard selectedPedalboard => Pedalboard_list.SelectedIndex > -1 ? pedalboardLibrary.Pedalboards.First(x => x.Name == Pedalboard_list.GetItemText(Pedalboard_list.SelectedItem)) : null;


        private void Populate()
        {
            pedalboard = new Pedalboard();
            pedalboard.Name = "my board";


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

            pedalboardLibrary.Add(pedalboard);
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Populate();
            LoadPedalboards();
        }

        private void LoadPedalboards()
        {
            foreach (var Pedalboard in pedalboardLibrary.Pedalboards)
            {
                Pedalboard_list.Items.Add(Pedalboard.Name);
            }
        }

        private void UpdateKnobsInfo()
        {
            pedalinfo_text.Clear();
            pedalinfo_text.Text = selectedPedalboard.Format();
        }

        private void Pedalboard_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateKnobsInfo();
        }
    }
}