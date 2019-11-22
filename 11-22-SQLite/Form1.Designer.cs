namespace _11_22_SQLite
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
            this.rendezokListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rendezokListBox
            // 
            this.rendezokListBox.FormattingEnabled = true;
            this.rendezokListBox.Location = new System.Drawing.Point(12, 12);
            this.rendezokListBox.Name = "rendezokListBox";
            this.rendezokListBox.Size = new System.Drawing.Size(133, 160);
            this.rendezokListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(388, 267);
            this.Controls.Add(this.rendezokListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox rendezokListBox;
    }
}

