using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace tuner
{
    public partial class Form1 : Form
    {
        private int selectedItem;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in new Sound().GetInputDevices())
            {
                comboBox1.Items.Add(item);
            }

        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            Sound sound = new Sound();
            
            freq.Text = await Task.Run(() =>
            {
                return sound.GetPitch(selectedItem).ToString();
            });
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedItem = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;
        }
    }
}
