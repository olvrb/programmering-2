namespace AudioProcessor
{
    partial class Form1
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
            this.openFile_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFile_button
            // 
            this.openFile_button.Location = new System.Drawing.Point(13, 13);
            this.openFile_button.Name = "openFile_button";
            this.openFile_button.Size = new System.Drawing.Size(75, 23);
            this.openFile_button.TabIndex = 0;
            this.openFile_button.Text = "Open File";
            this.openFile_button.UseVisualStyleBackColor = true;
            this.openFile_button.Click += new System.EventHandler(this.OpenFile_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openFile_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openFile_button;
    }
}

