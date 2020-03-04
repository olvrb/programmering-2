using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using pedalboard.Models;
using pedalboard.Models.Knobs;

namespace pedalboard {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Pedalboard pedalboard = new Pedalboard();

            Pedal pedal = new Pedal();
            pedal.AddKnob(new SimpleKnob {
                MaxValue = 100,
                Value = 50,
                Pedal = pedal
            });
            pedal.AddKnob(new SelectionKnob {
                Selections = new List<string> {
                    "Tape",
                    "Loop"
                },
                Pedal = pedal
            });

            pedal.Name = "Flashback";
            pedal.On = true;
            pedalboard.Pedals.Add(pedal);

            richTextBox1.Text = JsonConvert.SerializeObject(pedalboard, Formatting.Indented, new JsonSerializerSettings {ReferenceLoopHandling = ReferenceLoopHandling.Ignore});
        }
    }
}