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
            this.listBoxFilmek = new System.Windows.Forms.ListBox();
            this.buttonFilmTorles = new System.Windows.Forms.Button();
            this.textBoxFilmCim = new System.Windows.Forms.TextBox();
            this.numericUpDownFilmHossz = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerFilmKiadas = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonFilmFelvetel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilmHossz)).BeginInit();
            this.SuspendLayout();
            // 
            // rendezokListBox
            // 
            this.rendezokListBox.FormattingEnabled = true;
            this.rendezokListBox.Location = new System.Drawing.Point(12, 12);
            this.rendezokListBox.Name = "rendezokListBox";
            this.rendezokListBox.Size = new System.Drawing.Size(140, 95);
            this.rendezokListBox.TabIndex = 0;
            this.rendezokListBox.SelectedIndexChanged += new System.EventHandler(this.rendezokListBox_SelectedIndexChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(247, 90);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Felvétel";
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
            this.buttonTorles.Location = new System.Drawing.Point(87, 113);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(65, 23);
            this.buttonTorles.TabIndex = 8;
            this.buttonTorles.Text = "Törlés";
            this.buttonTorles.UseVisualStyleBackColor = true;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click);
            // 
            // listBoxFilmek
            // 
            this.listBoxFilmek.FormattingEnabled = true;
            this.listBoxFilmek.Location = new System.Drawing.Point(12, 142);
            this.listBoxFilmek.Name = "listBoxFilmek";
            this.listBoxFilmek.Size = new System.Drawing.Size(140, 69);
            this.listBoxFilmek.TabIndex = 9;
            this.listBoxFilmek.Visible = false;
            // 
            // buttonFilmTorles
            // 
            this.buttonFilmTorles.Location = new System.Drawing.Point(12, 113);
            this.buttonFilmTorles.Name = "buttonFilmTorles";
            this.buttonFilmTorles.Size = new System.Drawing.Size(69, 23);
            this.buttonFilmTorles.TabIndex = 10;
            this.buttonFilmTorles.Text = "Film Törlés";
            this.buttonFilmTorles.UseVisualStyleBackColor = true;
            this.buttonFilmTorles.Click += new System.EventHandler(this.buttonFilmTorles_Click);
            // 
            // textBoxFilmCim
            // 
            this.textBoxFilmCim.Location = new System.Drawing.Point(215, 142);
            this.textBoxFilmCim.Name = "textBoxFilmCim";
            this.textBoxFilmCim.Size = new System.Drawing.Size(139, 20);
            this.textBoxFilmCim.TabIndex = 11;
            // 
            // numericUpDownFilmHossz
            // 
            this.numericUpDownFilmHossz.Location = new System.Drawing.Point(215, 194);
            this.numericUpDownFilmHossz.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownFilmHossz.Name = "numericUpDownFilmHossz";
            this.numericUpDownFilmHossz.Size = new System.Drawing.Size(139, 20);
            this.numericUpDownFilmHossz.TabIndex = 12;
            this.numericUpDownFilmHossz.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // dateTimePickerFilmKiadas
            // 
            this.dateTimePickerFilmKiadas.Location = new System.Drawing.Point(215, 168);
            this.dateTimePickerFilmKiadas.Name = "dateTimePickerFilmKiadas";
            this.dateTimePickerFilmKiadas.Size = new System.Drawing.Size(139, 20);
            this.dateTimePickerFilmKiadas.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cím:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kiadás:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hossz:";
            // 
            // buttonFilmFelvetel
            // 
            this.buttonFilmFelvetel.Location = new System.Drawing.Point(247, 220);
            this.buttonFilmFelvetel.Name = "buttonFilmFelvetel";
            this.buttonFilmFelvetel.Size = new System.Drawing.Size(75, 23);
            this.buttonFilmFelvetel.TabIndex = 17;
            this.buttonFilmFelvetel.Text = "Felvétel";
            this.buttonFilmFelvetel.UseVisualStyleBackColor = true;
            this.buttonFilmFelvetel.Click += new System.EventHandler(this.buttonFilmFelvetel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Összes Film Listázása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(388, 250);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonFilmFelvetel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerFilmKiadas);
            this.Controls.Add(this.numericUpDownFilmHossz);
            this.Controls.Add(this.textBoxFilmCim);
            this.Controls.Add(this.buttonFilmTorles);
            this.Controls.Add(this.listBoxFilmek);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilmHossz)).EndInit();
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
        private System.Windows.Forms.ListBox listBoxFilmek;
        private System.Windows.Forms.Button buttonFilmTorles;
        private System.Windows.Forms.TextBox textBoxFilmCim;
        private System.Windows.Forms.NumericUpDown numericUpDownFilmHossz;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilmKiadas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonFilmFelvetel;
        private System.Windows.Forms.Button button1;
    }
}

