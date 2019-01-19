namespace Projekt
{
    partial class DodajWynajem
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
            this.dateTimePickerPoczatek = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerKoniec = new System.Windows.Forms.DateTimePicker();
            this.DostepneSamochody = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lKoszt = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerPoczatek
            // 
            this.dateTimePickerPoczatek.Location = new System.Drawing.Point(47, 38);
            this.dateTimePickerPoczatek.Name = "dateTimePickerPoczatek";
            this.dateTimePickerPoczatek.Size = new System.Drawing.Size(262, 22);
            this.dateTimePickerPoczatek.TabIndex = 0;
            // 
            // dateTimePickerKoniec
            // 
            this.dateTimePickerKoniec.Location = new System.Drawing.Point(47, 103);
            this.dateTimePickerKoniec.Name = "dateTimePickerKoniec";
            this.dateTimePickerKoniec.Size = new System.Drawing.Size(261, 22);
            this.dateTimePickerKoniec.TabIndex = 1;
            this.dateTimePickerKoniec.ValueChanged += new System.EventHandler(this.dateTimePickerKoniec_ValueChanged);
            // 
            // DostepneSamochody
            // 
            this.DostepneSamochody.FormattingEnabled = true;
            this.DostepneSamochody.ItemHeight = 16;
            this.DostepneSamochody.Location = new System.Drawing.Point(47, 154);
            this.DostepneSamochody.Name = "DostepneSamochody";
            this.DostepneSamochody.Size = new System.Drawing.Size(568, 228);
            this.DostepneSamochody.TabIndex = 2;
            this.DostepneSamochody.SelectedIndexChanged += new System.EventHandler(this.DostepneSamochody_OnSelectedIndexChange);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 87);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sprawdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Szacowany Koszt";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(621, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "WynajmijTenSamochod";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lKoszt
            // 
            this.lKoszt.AutoSize = true;
            this.lKoszt.Location = new System.Drawing.Point(168, 405);
            this.lKoszt.Name = "lKoszt";
            this.lKoszt.Size = new System.Drawing.Size(0, 17);
            this.lKoszt.TabIndex = 6;
            this.lKoszt.Click += new System.EventHandler(this.lKoszt_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(621, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 52);
            this.button3.TabIndex = 7;
            this.button3.Text = "Zamknij";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DodajWynajem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lKoszt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DostepneSamochody);
            this.Controls.Add(this.dateTimePickerKoniec);
            this.Controls.Add(this.dateTimePickerPoczatek);
            this.Name = "DodajWynajem";
            this.Text = "Wynajmij";
            this.Load += new System.EventHandler(this.DodajWynajem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerPoczatek;
        private System.Windows.Forms.DateTimePicker dateTimePickerKoniec;
        private System.Windows.Forms.ListBox DostepneSamochody;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lKoszt;
        private System.Windows.Forms.Button button3;
    }
}