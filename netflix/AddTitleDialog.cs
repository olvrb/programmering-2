using System;
using System.Windows.Forms;

namespace netflix {
    public partial class AddTitleDialog : Form {
        public AddTitleDialog() {
            InitializeComponent();
        }

        private void AddTitleDialog_Load(object sender, EventArgs e) {
            ActiveControl = input;
        }

        private void Submit_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}