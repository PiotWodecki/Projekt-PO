namespace Projekt
{
    partial class Dostepnosc
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
            this.dDostepnosc = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerPoczatek = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerKoniec = new System.Windows.Forms.DateTimePicker();
            this.Dodaj = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dDostepnosc)).BeginInit();
            this.SuspendLayout();
            // 
            // dDostepnosc
            // 
            this.dDostepnosc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dDostepnosc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dDostepnosc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dDostepnosc.Location = new System.Drawing.Point(12, 2);
            this.dDostepnosc.MultiSelect = false;
            this.dDostepnosc.Name = "dDostepnosc";
            this.dDostepnosc.RowTemplate.Height = 24;
            this.dDostepnosc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dDostepnosc.Size = new System.Drawing.Size(494, 280);
            this.dDostepnosc.TabIndex = 0;
            this.dDostepnosc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dDostepnosc_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 87);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zamknij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerPoczatek
            // 
            this.dateTimePickerPoczatek.Location = new System.Drawing.Point(12, 337);
            this.dateTimePickerPoczatek.Name = "dateTimePickerPoczatek";
            this.dateTimePickerPoczatek.Size = new System.Drawing.Size(203, 22);
            this.dateTimePickerPoczatek.TabIndex = 2;
            this.dateTimePickerPoczatek.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Poczatek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Koniec";
            // 
            // dateTimePickerKoniec
            // 
            this.dateTimePickerKoniec.Location = new System.Drawing.Point(12, 436);
            this.dateTimePickerKoniec.Name = "dateTimePickerKoniec";
            this.dateTimePickerKoniec.Size = new System.Drawing.Size(192, 22);
            this.dateTimePickerKoniec.TabIndex = 5;
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(310, 317);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(196, 42);
            this.Dodaj.TabIndex = 6;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Usuń";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dostepnosc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 498);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.dateTimePickerKoniec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerPoczatek);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dDostepnosc);
            this.Name = "Dostepnosc";
            this.Text = "Dostepnosc";
            this.Load += new System.EventHandler(this.Dostepnosc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dDostepnosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dDostepnosc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePickerPoczatek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerKoniec;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button button2;
    }
}