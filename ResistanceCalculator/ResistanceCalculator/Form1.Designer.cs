namespace ResistanceCalculator
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
            this.band1 = new System.Windows.Forms.ComboBox();
            this.band2 = new System.Windows.Forms.ComboBox();
            this.band3 = new System.Windows.Forms.ComboBox();
            this.multiplier = new System.Windows.Forms.ComboBox();
            this.tolerance = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.band1Pbx = new System.Windows.Forms.PictureBox();
            this.band2Pbx = new System.Windows.Forms.PictureBox();
            this.band3Pbx = new System.Windows.Forms.PictureBox();
            this.multiplierPbx = new System.Windows.Forms.PictureBox();
            this.tolerancePbx = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.valueLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.range1Lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.range2Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.band1Pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.band2Pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.band3Pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplierPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tolerancePbx)).BeginInit();
            this.SuspendLayout();
            // 
            // band1
            // 
            this.band1.FormattingEnabled = true;
            this.band1.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
            "Gray",
            "White"});
            this.band1.Location = new System.Drawing.Point(78, 268);
            this.band1.Name = "band1";
            this.band1.Size = new System.Drawing.Size(121, 24);
            this.band1.TabIndex = 0;
            // 
            // band2
            // 
            this.band2.FormattingEnabled = true;
            this.band2.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
            "Gray",
            "White"});
            this.band2.Location = new System.Drawing.Point(205, 268);
            this.band2.Name = "band2";
            this.band2.Size = new System.Drawing.Size(121, 24);
            this.band2.TabIndex = 1;
            // 
            // band3
            // 
            this.band3.FormattingEnabled = true;
            this.band3.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
            "Gray",
            "White",
            "None"});
            this.band3.Location = new System.Drawing.Point(332, 268);
            this.band3.Name = "band3";
            this.band3.Size = new System.Drawing.Size(121, 24);
            this.band3.TabIndex = 2;
            // 
            // multiplier
            // 
            this.multiplier.FormattingEnabled = true;
            this.multiplier.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
            "Gold",
            "Silver"});
            this.multiplier.Location = new System.Drawing.Point(459, 268);
            this.multiplier.Name = "multiplier";
            this.multiplier.Size = new System.Drawing.Size(121, 24);
            this.multiplier.TabIndex = 3;
            // 
            // tolerance
            // 
            this.tolerance.FormattingEnabled = true;
            this.tolerance.Items.AddRange(new object[] {
            "Brown",
            "Red",
            "Green",
            "Blue",
            "Purple",
            "Gray",
            "Gold",
            "Silver"});
            this.tolerance.Location = new System.Drawing.Point(586, 268);
            this.tolerance.Name = "tolerance";
            this.tolerance.Size = new System.Drawing.Size(121, 24);
            this.tolerance.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Band 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Band 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Band 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Multiplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tolerance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ResistanceCalculator.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(241, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // band1Pbx
            // 
            this.band1Pbx.Location = new System.Drawing.Point(287, 91);
            this.band1Pbx.Name = "band1Pbx";
            this.band1Pbx.Size = new System.Drawing.Size(39, 74);
            this.band1Pbx.TabIndex = 11;
            this.band1Pbx.TabStop = false;
            this.band1Pbx.Visible = false;
            // 
            // band2Pbx
            // 
            this.band2Pbx.Location = new System.Drawing.Point(332, 91);
            this.band2Pbx.Name = "band2Pbx";
            this.band2Pbx.Size = new System.Drawing.Size(39, 74);
            this.band2Pbx.TabIndex = 12;
            this.band2Pbx.TabStop = false;
            this.band2Pbx.Visible = false;
            // 
            // band3Pbx
            // 
            this.band3Pbx.Location = new System.Drawing.Point(377, 91);
            this.band3Pbx.Name = "band3Pbx";
            this.band3Pbx.Size = new System.Drawing.Size(39, 74);
            this.band3Pbx.TabIndex = 13;
            this.band3Pbx.TabStop = false;
            this.band3Pbx.Visible = false;
            // 
            // multiplierPbx
            // 
            this.multiplierPbx.Location = new System.Drawing.Point(422, 91);
            this.multiplierPbx.Name = "multiplierPbx";
            this.multiplierPbx.Size = new System.Drawing.Size(39, 74);
            this.multiplierPbx.TabIndex = 14;
            this.multiplierPbx.TabStop = false;
            this.multiplierPbx.Visible = false;
            // 
            // tolerancePbx
            // 
            this.tolerancePbx.Location = new System.Drawing.Point(467, 91);
            this.tolerancePbx.Name = "tolerancePbx";
            this.tolerancePbx.Size = new System.Drawing.Size(39, 74);
            this.tolerancePbx.TabIndex = 15;
            this.tolerancePbx.TabStop = false;
            this.tolerancePbx.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Value:";
            // 
            // valueLbl
            // 
            this.valueLbl.AutoSize = true;
            this.valueLbl.Location = new System.Drawing.Point(341, 371);
            this.valueLbl.Name = "valueLbl";
            this.valueLbl.Size = new System.Drawing.Size(0, 17);
            this.valueLbl.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Value Range:";
            // 
            // range1Lbl
            // 
            this.range1Lbl.AutoSize = true;
            this.range1Lbl.Location = new System.Drawing.Point(341, 406);
            this.range1Lbl.Name = "range1Lbl";
            this.range1Lbl.Size = new System.Drawing.Size(0, 17);
            this.range1Lbl.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(477, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "-";
            // 
            // range2Lbl
            // 
            this.range2Lbl.AutoSize = true;
            this.range2Lbl.Location = new System.Drawing.Point(506, 406);
            this.range2Lbl.Name = "range2Lbl";
            this.range2Lbl.Size = new System.Drawing.Size(0, 17);
            this.range2Lbl.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.range2Lbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.range1Lbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.valueLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tolerancePbx);
            this.Controls.Add(this.multiplierPbx);
            this.Controls.Add(this.band3Pbx);
            this.Controls.Add(this.band2Pbx);
            this.Controls.Add(this.band1Pbx);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tolerance);
            this.Controls.Add(this.multiplier);
            this.Controls.Add(this.band3);
            this.Controls.Add(this.band2);
            this.Controls.Add(this.band1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resistance Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.band1Pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.band2Pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.band3Pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplierPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tolerancePbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox band1;
        private System.Windows.Forms.ComboBox band2;
        private System.Windows.Forms.ComboBox band3;
        private System.Windows.Forms.ComboBox multiplier;
        private System.Windows.Forms.ComboBox tolerance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox band1Pbx;
        private System.Windows.Forms.PictureBox band2Pbx;
        private System.Windows.Forms.PictureBox band3Pbx;
        private System.Windows.Forms.PictureBox multiplierPbx;
        private System.Windows.Forms.PictureBox tolerancePbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label valueLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label range1Lbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label range2Lbl;
    }
}

