using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFile_button_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog()
            {
                FileName = "",
                Filter = "Audio Files (*)|*",
                Title = "Open text file"
            };
            openFileDialog1.ShowDialog();

            Soundt
        }
    }
}
