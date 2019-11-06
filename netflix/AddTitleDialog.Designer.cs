namespace netflix
{
    partial class AddTitleDialog
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
            this.input = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(13, 13);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(335, 20);
            this.input.TabIndex = 0;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(354, 13);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 20);
            this.submit.TabIndex = 1;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AddTitleDialog
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 47);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.input);
            this.Name = "AddTitleDialog";
            this.Text = "Add Title";
            this.Load += new System.EventHandler(this.AddTitleDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button submit;
    }
}