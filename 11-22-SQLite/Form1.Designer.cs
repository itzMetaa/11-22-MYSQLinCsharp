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
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.textBoxSzarmazas = new System.Windows.Forms.TextBox();
            this.dateTimePickerSzulDatum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rendezokListBox
            // 
            this.rendezokListBox.FormattingEnabled = true;
            this.rendezokListBox.Location = new System.Drawing.Point(12, 12);
            this.rendezokListBox.Name = "rendezokListBox";
            this.rendezokListBox.Size = new System.Drawing.Size(140, 95);
            this.rendezokListBox.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(247, 90);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(215, 12);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(139, 20);
            this.textBoxNev.TabIndex = 2;
            // 
            // textBoxSzarmazas
            // 
            this.textBoxSzarmazas.Location = new System.Drawing.Point(215, 64);
            this.textBoxSzarmazas.Name = "textBoxSzarmazas";
            this.textBoxSzarmazas.Size = new System.Drawing.Size(139, 20);
            this.textBoxSzarmazas.TabIndex = 3;
            // 
            // dateTimePickerSzulDatum
            // 
            this.dateTimePickerSzulDatum.Location = new System.Drawing.Point(215, 38);
            this.dateTimePickerSzulDatum.Name = "dateTimePickerSzulDatum";
            this.dateTimePickerSzulDatum.Size = new System.Drawing.Size(139, 20);
            this.dateTimePickerSzulDatum.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Szül:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Származás:";
            // 
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(45, 113);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(75, 23);
            this.buttonTorles.TabIndex = 8;
            this.buttonTorles.Text = "Törlés";
            this.buttonTorles.UseVisualStyleBackColor = true;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(388, 165);
            this.Controls.Add(this.buttonTorles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerSzulDatum);
            this.Controls.Add(this.textBoxSzarmazas);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.rendezokListBox);
            this.Name = "Form1";
            this.Text = "Rendezők";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox rendezokListBox;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.TextBox textBoxSzarmazas;
        private System.Windows.Forms.DateTimePicker dateTimePickerSzulDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTorles;
    }
}

