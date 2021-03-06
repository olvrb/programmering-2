﻿using System;
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
        // Just some test data
        PedalboardLibrary pedalboardLibrary = new PedalboardLibrary();
        Pedalboard pedalboard;
        Pedalboard pedalboard2;

        // Get the currently selected pedal from Pedalboard_list
        Pedalboard selectedPedalboard => Pedalboard_list.SelectedIndex > -1
            ? pedalboardLibrary.Pedalboards
                .First(x => x.Name == Pedalboard_list.GetItemText(Pedalboard_list.SelectedItem))
            : null;



        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Add some data to the PedalboardLibrary
            Populate();

            // Add some data to the form
            LoadPedalboards();
        }

        private void LoadPedalboards()
        {
            // Add every pedalboard to the form
            foreach (var Pedalboard in pedalboardLibrary.Pedalboards)
            {
                Pedalboard_list.Items.Add(Pedalboard.Name);
            }
        }

        private void UpdatePedalInfo()
        {
            pedalinfo_text.Clear();
            pedalinfo_text.Text = selectedPedalboard.Format();
        }

        private void Pedalboard_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePedalInfo();
        }
    }
}