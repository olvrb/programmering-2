namespace sidosi1
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input_box = new System.Windows.Forms.RichTextBox();
            this.output_box = new System.Windows.Forms.RichTextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_box
            // 
            this.input_box.Location = new System.Drawing.Point(13, 13);
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(759, 62);
            this.input_box.TabIndex = 0;
            this.input_box.Text = "";
            // 
            // output_box
            // 
            this.output_box.Cursor = System.Windows.Forms.Cursors.No;
            this.output_box.Location = new System.Drawing.Point(12, 110);
            this.output_box.Name = "output_box";
            this.output_box.ReadOnly = true;
            this.output_box.Size = new System.Drawing.Size(760, 328);
            this.output_box.TabIndex = 1;
            this.output_box.Text = "";
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(349, 81);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(100, 23);
            this.submit_button.TabIndex = 2;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.Submit_button_Click);
            // 
            // MainView
            // 
            this.AcceptButton = this.submit_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.output_box);
            this.Controls.Add(this.input_box);
            this.Name = "MainView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox input_box;
        private System.Windows.Forms.RichTextBox output_box;
        private System.Windows.Forms.Button submit_button;
    }
}

