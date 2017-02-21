namespace ImageFilter
{
    partial class MainForm
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
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.picSource = new System.Windows.Forms.Panel();
            this.grbOutput = new System.Windows.Forms.GroupBox();
            this.picOutput = new System.Windows.Forms.Panel();
            this.btnLoadSource = new System.Windows.Forms.Button();
            this.rdGrayscaleBits = new System.Windows.Forms.RadioButton();
            this.rdTransparencyBits = new System.Windows.Forms.RadioButton();
            this.rdSepiaBits = new System.Windows.Forms.RadioButton();
            this.rdNegativeBits = new System.Windows.Forms.RadioButton();
            this.rdGrayscaleDraw = new System.Windows.Forms.RadioButton();
            this.rdSepiaDraw = new System.Windows.Forms.RadioButton();
            this.rdTransparencyDraw = new System.Windows.Forms.RadioButton();
            this.rdNegativeDraw = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.grbInput.SuspendLayout();
            this.grbOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.picSource);
            this.grbInput.Location = new System.Drawing.Point(154, 1);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(272, 280);
            this.grbInput.TabIndex = 0;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Input Source";
            // 
            // picSource
            // 
            this.picSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSource.Location = new System.Drawing.Point(11, 19);
            this.picSource.Name = "picSource";
            this.picSource.Size = new System.Drawing.Size(250, 250);
            this.picSource.TabIndex = 0;
            // 
            // grbOutput
            // 
            this.grbOutput.Controls.Add(this.picOutput);
            this.grbOutput.Location = new System.Drawing.Point(432, 1);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Size = new System.Drawing.Size(272, 280);
            this.grbOutput.TabIndex = 1;
            this.grbOutput.TabStop = false;
            this.grbOutput.Text = "Filtered Output";
            // 
            // picOutput
            // 
            this.picOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOutput.Location = new System.Drawing.Point(11, 18);
            this.picOutput.Name = "picOutput";
            this.picOutput.Size = new System.Drawing.Size(250, 250);
            this.picOutput.TabIndex = 0;
            // 
            // btnLoadSource
            // 
            this.btnLoadSource.Location = new System.Drawing.Point(12, 12);
            this.btnLoadSource.Name = "btnLoadSource";
            this.btnLoadSource.Size = new System.Drawing.Size(110, 23);
            this.btnLoadSource.TabIndex = 2;
            this.btnLoadSource.Text = "Load Source";
            this.btnLoadSource.UseVisualStyleBackColor = true;
            this.btnLoadSource.Click += new System.EventHandler(this.btnLoadSource_Click);
            // 
            // rdGrayscaleBits
            // 
            this.rdGrayscaleBits.AutoSize = true;
            this.rdGrayscaleBits.Checked = true;
            this.rdGrayscaleBits.Location = new System.Drawing.Point(24, 70);
            this.rdGrayscaleBits.Name = "rdGrayscaleBits";
            this.rdGrayscaleBits.Size = new System.Drawing.Size(98, 17);
            this.rdGrayscaleBits.TabIndex = 3;
            this.rdGrayscaleBits.TabStop = true;
            this.rdGrayscaleBits.Text = "Grayscale - Bits";
            this.rdGrayscaleBits.UseVisualStyleBackColor = true;
            this.rdGrayscaleBits.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // rdTransparencyBits
            // 
            this.rdTransparencyBits.AutoSize = true;
            this.rdTransparencyBits.Location = new System.Drawing.Point(24, 185);
            this.rdTransparencyBits.Name = "rdTransparencyBits";
            this.rdTransparencyBits.Size = new System.Drawing.Size(116, 17);
            this.rdTransparencyBits.TabIndex = 4;
            this.rdTransparencyBits.Text = "Transparency - Bits";
            this.rdTransparencyBits.UseVisualStyleBackColor = true;
            this.rdTransparencyBits.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // rdSepiaBits
            // 
            this.rdSepiaBits.AutoSize = true;
            this.rdSepiaBits.Location = new System.Drawing.Point(24, 208);
            this.rdSepiaBits.Name = "rdSepiaBits";
            this.rdSepiaBits.Size = new System.Drawing.Size(106, 17);
            this.rdSepiaBits.TabIndex = 6;
            this.rdSepiaBits.Text = "Sepia Tone - Bits";
            this.rdSepiaBits.UseVisualStyleBackColor = true;
            this.rdSepiaBits.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // rdNegativeBits
            // 
            this.rdNegativeBits.AutoSize = true;
            this.rdNegativeBits.Location = new System.Drawing.Point(24, 139);
            this.rdNegativeBits.Name = "rdNegativeBits";
            this.rdNegativeBits.Size = new System.Drawing.Size(94, 17);
            this.rdNegativeBits.TabIndex = 5;
            this.rdNegativeBits.Text = "Negative - Bits";
            this.rdNegativeBits.UseVisualStyleBackColor = true;
            this.rdNegativeBits.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // rdGrayscaleDraw
            // 
            this.rdGrayscaleDraw.AutoSize = true;
            this.rdGrayscaleDraw.Location = new System.Drawing.Point(24, 93);
            this.rdGrayscaleDraw.Name = "rdGrayscaleDraw";
            this.rdGrayscaleDraw.Size = new System.Drawing.Size(106, 17);
            this.rdGrayscaleDraw.TabIndex = 7;
            this.rdGrayscaleDraw.Text = "Grayscale - Draw";
            this.rdGrayscaleDraw.UseVisualStyleBackColor = true;
            this.rdGrayscaleDraw.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // rdSepiaDraw
            // 
            this.rdSepiaDraw.AutoSize = true;
            this.rdSepiaDraw.Location = new System.Drawing.Point(24, 231);
            this.rdSepiaDraw.Name = "rdSepiaDraw";
            this.rdSepiaDraw.Size = new System.Drawing.Size(114, 17);
            this.rdSepiaDraw.TabIndex = 8;
            this.rdSepiaDraw.Text = "Sepia Tone - Draw";
            this.rdSepiaDraw.UseVisualStyleBackColor = true;
            this.rdSepiaDraw.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // rdTransparencyDraw
            // 
            this.rdTransparencyDraw.AutoSize = true;
            this.rdTransparencyDraw.Location = new System.Drawing.Point(24, 116);
            this.rdTransparencyDraw.Name = "rdTransparencyDraw";
            this.rdTransparencyDraw.Size = new System.Drawing.Size(124, 17);
            this.rdTransparencyDraw.TabIndex = 9;
            this.rdTransparencyDraw.Text = "Transparency - Draw";
            this.rdTransparencyDraw.UseVisualStyleBackColor = true;
            this.rdTransparencyDraw.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // rdNegativeDraw
            // 
            this.rdNegativeDraw.AutoSize = true;
            this.rdNegativeDraw.Location = new System.Drawing.Point(24, 162);
            this.rdNegativeDraw.Name = "rdNegativeDraw";
            this.rdNegativeDraw.Size = new System.Drawing.Size(102, 17);
            this.rdNegativeDraw.TabIndex = 10;
            this.rdNegativeDraw.Text = "Negative - Draw";
            this.rdNegativeDraw.UseVisualStyleBackColor = true;
            this.rdNegativeDraw.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save Output";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 27);
            this.button2.TabIndex = 12;
            this.button2.Text = "Blur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 27);
            this.button3.TabIndex = 13;
            this.button3.Text = "Sharpen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(377, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 27);
            this.button4.TabIndex = 14;
            this.button4.Text = "Brightness";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(478, 287);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 27);
            this.button5.TabIndex = 15;
            this.button5.Text = "Jitter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(579, 287);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 27);
            this.button6.TabIndex = 13;
            this.button6.Text = "CornerMarker";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 287);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 27);
            this.button7.TabIndex = 16;
            this.button7.Text = "Use Output";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(13, 257);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "Video";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 321);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdNegativeDraw);
            this.Controls.Add(this.rdTransparencyDraw);
            this.Controls.Add(this.rdSepiaDraw);
            this.Controls.Add(this.rdGrayscaleDraw);
            this.Controls.Add(this.rdSepiaBits);
            this.Controls.Add(this.rdNegativeBits);
            this.Controls.Add(this.rdTransparencyBits);
            this.Controls.Add(this.rdGrayscaleBits);
            this.Controls.Add(this.btnLoadSource);
            this.Controls.Add(this.grbOutput);
            this.Controls.Add(this.grbInput);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitmap Filters";
            this.grbInput.ResumeLayout(false);
            this.grbOutput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.Panel picSource;
        private System.Windows.Forms.GroupBox grbOutput;
        private System.Windows.Forms.Panel picOutput;
        private System.Windows.Forms.Button btnLoadSource;
        private System.Windows.Forms.RadioButton rdGrayscaleBits;
        private System.Windows.Forms.RadioButton rdTransparencyBits;
        private System.Windows.Forms.RadioButton rdSepiaBits;
        private System.Windows.Forms.RadioButton rdNegativeBits;
        private System.Windows.Forms.RadioButton rdGrayscaleDraw;
        private System.Windows.Forms.RadioButton rdSepiaDraw;
        private System.Windows.Forms.RadioButton rdTransparencyDraw;
        private System.Windows.Forms.RadioButton rdNegativeDraw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

