namespace pedalboard
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Pedalboard_text = new System.Windows.Forms.RichTextBox();
            this.Pedal_text = new System.Windows.Forms.RichTextBox();
            this.Pedalboard_list = new System.Windows.Forms.ListBox();
            this.Pedal_list = new System.Windows.Forms.ListBox();
            this.pedalinfo_text = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Pedalboard_text
            // 
            this.Pedalboard_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pedalboard_text.Location = new System.Drawing.Point(13, 13);
            this.Pedalboard_text.Name = "Pedalboard_text";
            this.Pedalboard_text.Size = new System.Drawing.Size(187, 41);
            this.Pedalboard_text.TabIndex = 1;
            this.Pedalboard_text.Text = "Pedal";
            // 
            // Pedal_text
            // 
            this.Pedal_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pedal_text.Location = new System.Drawing.Point(206, 13);
            this.Pedal_text.Name = "Pedal_text";
            this.Pedal_text.Size = new System.Drawing.Size(187, 41);
            this.Pedal_text.TabIndex = 3;
            this.Pedal_text.Text = "Knobs";
            // 
            // Pedalboard_list
            // 
            this.Pedalboard_list.FormattingEnabled = true;
            this.Pedalboard_list.Location = new System.Drawing.Point(13, 60);
            this.Pedalboard_list.Name = "Pedalboard_list";
            this.Pedalboard_list.Size = new System.Drawing.Size(187, 381);
            this.Pedalboard_list.TabIndex = 5;
            this.Pedalboard_list.SelectedIndexChanged += new System.EventHandler(this.Pedalboard_list_SelectedIndexChanged);
            // 
            // Pedal_list
            // 
            this.Pedal_list.FormattingEnabled = true;
            this.Pedal_list.Location = new System.Drawing.Point(207, 60);
            this.Pedal_list.Name = "Pedal_list";
            this.Pedal_list.Size = new System.Drawing.Size(187, 381);
            this.Pedal_list.TabIndex = 6;
            this.Pedal_list.SelectedIndexChanged += new System.EventHandler(this.Pedal_list_SelectedIndexChanged);
            // 
            // pedalinfo_text
            // 
            this.pedalinfo_text.Location = new System.Drawing.Point(399, 13);
            this.pedalinfo_text.Name = "pedalinfo_text";
            this.pedalinfo_text.Size = new System.Drawing.Size(389, 425);
            this.pedalinfo_text.TabIndex = 4;
            this.pedalinfo_text.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pedal_list);
            this.Controls.Add(this.Pedalboard_list);
            this.Controls.Add(this.pedalinfo_text);
            this.Controls.Add(this.Pedal_text);
            this.Controls.Add(this.Pedalboard_text);
            this.Name = "Form1";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox Pedalboard_text;
        private System.Windows.Forms.RichTextBox Pedal_text;
        private System.Windows.Forms.ListBox Pedalboard_list;
        private System.Windows.Forms.ListBox Pedal_list;
        private System.Windows.Forms.RichTextBox pedalinfo_text;
    }
}

