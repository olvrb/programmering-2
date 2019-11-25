﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sidosi1 {
    public partial class MainView : Form {
        public MainView() {
            InitializeComponent();
        }

        private SidosiClient client = new SidosiClient();

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void Submit_button_Click(object sender, EventArgs e) {
            string inp = input_box.Text;
            Task.Run(() => {
                string resp = client.Translate(inp);
                Console.WriteLine(SidosiClient.FormatAsArray(resp).Aggregate((x, y) => $"{x}, {y}"));
                Invoke(new MethodInvoker(() => output_box.Text = resp));
            });
        }
    }
}