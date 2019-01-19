namespace Projekt
{
    partial class DadajSamochod
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
            this.label1 = new System.Windows.Forms.Label();
            this.tMarka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lTyp = new System.Windows.Forms.ListBox();
            this.lKolor = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tNR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tMarka
            // 
            this.tMarka.Location = new System.Drawing.Point(212, 44);
            this.tMarka.Name = "tMarka";
            this.tMarka.Size = new System.Drawing.Size(220, 22);
            this.tMarka.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // tModel
            // 
            this.tModel.Location = new System.Drawing.Point(212, 89);
            this.tModel.Name = "tModel";
            this.tModel.Size = new System.Drawing.Size(220, 22);
            this.tModel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Typ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kolor";
            // 
            // lTyp
            // 
            this.lTyp.FormattingEnabled = true;
            this.lTyp.ItemHeight = 16;
            this.lTyp.Items.AddRange(new object[] {
            "sedan",
            "hatchback",
            "kombi",
            "van",
            "cabriolet"});
            this.lTyp.Location = new System.Drawing.Point(212, 156);
            this.lTyp.Name = "lTyp";
            this.lTyp.Size = new System.Drawing.Size(220, 36);
            this.lTyp.TabIndex = 6;
            // 
            // lKolor
            // 
            this.lKolor.FormattingEnabled = true;
            this.lKolor.ItemHeight = 16;
            this.lKolor.Items.AddRange(new object[] {
            "bialy",
            "niebieski",
            "czerwony",
            "czarny"});
            this.lKolor.Location = new System.Drawing.Point(212, 237);
            this.lKolor.Name = "lKolor";
            this.lKolor.Size = new System.Drawing.Size(220, 36);
            this.lKolor.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numer Rejestracyjny";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 77);
            this.button1.TabIndex = 10;
            this.button1.Text = "Zatwierdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tNR
            // 
            this.tNR.Location = new System.Drawing.Point(212, 311);
            this.tNR.Name = "tNR";
            this.tNR.Size = new System.Drawing.Size(220, 22);
            this.tNR.TabIndex = 11;
            // 
            // DadajSamochod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 447);
            this.Controls.Add(this.tNR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lKolor);
            this.Controls.Add(this.lTyp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tMarka);
            this.Controls.Add(this.label1);
            this.Name = "DadajSamochod";
            this.Text = "DadajSamochod";
            this.Load += new System.EventHandler(this.DadajSamochod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lTyp;
        private System.Windows.Forms.ListBox lKolor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tNR;
    }
}