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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.seasons_listBox = new System.Windows.Forms.ListBox();
            this.episodes_listBox = new System.Windows.Forms.ListBox();
            this.seasons_title = new System.Windows.Forms.RichTextBox();
            this.episodes_title = new System.Windows.Forms.RichTextBox();
            this.titles_title = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titles_listBox
            // 
            this.titles_listBox.FormattingEnabled = true;
            this.titles_listBox.Location = new System.Drawing.Point(12, 38);
            this.titles_listBox.Name = "titles_listBox";
            this.titles_listBox.Size = new System.Drawing.Size(149, 394);
            this.titles_listBox.TabIndex = 0;
            this.titles_listBox.SelectedIndexChanged += new System.EventHandler(this.Titles_listBox_SelectedIndexChanged);
            // 
            // info_box
            // 
            this.info_box.Location = new System.Drawing.Point(442, 12);
            this.info_box.Name = "info_box";
            this.info_box.Size = new System.Drawing.Size(346, 426);
            this.info_box.TabIndex = 1;
            this.info_box.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(628, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // seasons_listBox
            // 
            this.seasons_listBox.FormattingEnabled = true;
            this.seasons_listBox.Location = new System.Drawing.Point(167, 38);
            this.seasons_listBox.Name = "seasons_listBox";
            this.seasons_listBox.Size = new System.Drawing.Size(143, 394);
            this.seasons_listBox.TabIndex = 3;
            this.seasons_listBox.SelectedIndexChanged += new System.EventHandler(this.Seasons_listBox_SelectedIndexChanged);
            // 
            // episodes_listBox
            // 
            this.episodes_listBox.FormattingEnabled = true;
            this.episodes_listBox.Location = new System.Drawing.Point(316, 39);
            this.episodes_listBox.Name = "episodes_listBox";
            this.episodes_listBox.Size = new System.Drawing.Size(120, 394);
            this.episodes_listBox.TabIndex = 4;
            // 
            // seasons_title
            // 
            this.seasons_title.Location = new System.Drawing.Point(167, 3);
            this.seasons_title.Name = "seasons_title";
            this.seasons_title.ReadOnly = true;
            this.seasons_title.Size = new System.Drawing.Size(143, 29);
            this.seasons_title.TabIndex = 5;
            this.seasons_title.Text = "Seasons";
            // 
            // episodes_title
            // 
            this.episodes_title.Location = new System.Drawing.Point(316, 4);
            this.episodes_title.Name = "episodes_title";
            this.episodes_title.ReadOnly = true;
            this.episodes_title.Size = new System.Drawing.Size(120, 29);
            this.episodes_title.TabIndex = 6;
            this.episodes_title.Text = "Episodes";
            // 
            // titles_title
            // 
            this.titles_title.Location = new System.Drawing.Point(12, 3);
            this.titles_title.Name = "titles_title";
            this.titles_title.ReadOnly = true;
            this.titles_title.Size = new System.Drawing.Size(149, 29);
            this.titles_title.TabIndex = 7;
            this.titles_title.Tag = "";
            this.titles_title.Text = "Library";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titles_title);
            this.Controls.Add(this.episodes_title);
            this.Controls.Add(this.seasons_title);
            this.Controls.Add(this.episodes_listBox);
            this.Controls.Add(this.seasons_listBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.info_box);
            this.Controls.Add(this.titles_listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox titles_listBox;
        private System.Windows.Forms.RichTextBox info_box;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox seasons_listBox;
        private System.Windows.Forms.ListBox episodes_listBox;
        private System.Windows.Forms.RichTextBox seasons_title;
        private System.Windows.Forms.RichTextBox episodes_title;
        private System.Windows.Forms.RichTextBox titles_title;
    }
}

