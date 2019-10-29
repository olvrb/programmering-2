namespace netflix
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
            this.titles_listBox = new System.Windows.Forms.ListBox();
            this.info_box = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // titles_listBox
            // 
            this.titles_listBox.FormattingEnabled = true;
            this.titles_listBox.Location = new System.Drawing.Point(12, 12);
            this.titles_listBox.Name = "titles_listBox";
            this.titles_listBox.Size = new System.Drawing.Size(188, 420);
            this.titles_listBox.TabIndex = 0;
            this.titles_listBox.SelectedIndexChanged += new System.EventHandler(this.Titles_listBox_SelectedIndexChanged);
            // 
            // info_box
            // 
            this.info_box.Location = new System.Drawing.Point(206, 12);
            this.info_box.Name = "info_box";
            this.info_box.Size = new System.Drawing.Size(582, 425);
            this.info_box.TabIndex = 1;
            this.info_box.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.info_box);
            this.Controls.Add(this.titles_listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox titles_listBox;
        private System.Windows.Forms.RichTextBox info_box;
    }
}

