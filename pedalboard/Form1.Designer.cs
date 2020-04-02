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
            this.Pedalboard_list = new System.Windows.Forms.ListBox();
            this.pedalinfo_text = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pedalboard_list
            // 
            this.Pedalboard_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Pedalboard_list.FormattingEnabled = true;
            this.Pedalboard_list.Location = new System.Drawing.Point(13, 60);
            this.Pedalboard_list.Name = "Pedalboard_list";
            this.Pedalboard_list.Size = new System.Drawing.Size(162, 381);
            this.Pedalboard_list.TabIndex = 5;
            this.Pedalboard_list.SelectedIndexChanged += new System.EventHandler(this.Pedalboard_list_SelectedIndexChanged);
            // 
            // pedalinfo_text
            // 
            this.pedalinfo_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pedalinfo_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedalinfo_text.Location = new System.Drawing.Point(181, 13);
            this.pedalinfo_text.Name = "pedalinfo_text";
            this.pedalinfo_text.ReadOnly = true;
            this.pedalinfo_text.Size = new System.Drawing.Size(997, 425);
            this.pedalinfo_text.TabIndex = 4;
            this.pedalinfo_text.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pedalboard";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pedalboard_list);
            this.Controls.Add(this.pedalinfo_text);
            this.Name = "Form1";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox Pedalboard_list;
        private System.Windows.Forms.RichTextBox pedalinfo_text;
        private System.Windows.Forms.Label label1;
    }
}

