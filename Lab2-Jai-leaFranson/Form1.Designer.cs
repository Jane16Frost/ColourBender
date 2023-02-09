namespace Lab2_Jai_leaFranson
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.loadPicture = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addColorRadio = new System.Windows.Forms.RadioButton();
            this.scrambleRadio = new System.Windows.Forms.RadioButton();
            this.negativeRadio = new System.Windows.Forms.RadioButton();
            this.noiseRadio = new System.Windows.Forms.RadioButton();
            this.tintRadio = new System.Windows.Forms.RadioButton();
            this.bwRadio = new System.Windows.Forms.RadioButton();
            this.contrastRadio = new System.Windows.Forms.RadioButton();
            this.modificationSlider = new System.Windows.Forms.TrackBar();
            this.transformBtn = new System.Windows.Forms.Button();
            this.smallSlideLabel = new System.Windows.Forms.Label();
            this.bigSlideLabel = new System.Windows.Forms.Label();
            this.pictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.trackValue = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.savePictureBtn = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorEvenerRadio = new System.Windows.Forms.RadioButton();
            this.pixelRadio = new System.Windows.Forms.RadioButton();
            this.brightnessRadio = new System.Windows.Forms.RadioButton();
            this.colorFinderRadio = new System.Windows.Forms.RadioButton();
            this.RCtintRadio = new System.Windows.Forms.RadioButton();
            this.GMtintRadio = new System.Windows.Forms.RadioButton();
            this.RCcontrastRadio = new System.Windows.Forms.RadioButton();
            this.BYtintRadio = new System.Windows.Forms.RadioButton();
            this.contrastRevRadio = new System.Windows.Forms.RadioButton();
            this.GMcontrastRadio = new System.Windows.Forms.RadioButton();
            this.BYcontrastRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modificationSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(184, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(994, 593);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // loadPicture
            // 
            this.loadPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadPicture.Location = new System.Drawing.Point(11, 552);
            this.loadPicture.Name = "loadPicture";
            this.loadPicture.Size = new System.Drawing.Size(165, 34);
            this.loadPicture.TabIndex = 1;
            this.loadPicture.Text = "Load Pictures";
            this.loadPicture.UseVisualStyleBackColor = true;
            this.loadPicture.Click += new System.EventHandler(this.LoadPicture);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.BYcontrastRadio);
            this.groupBox1.Controls.Add(this.GMcontrastRadio);
            this.groupBox1.Controls.Add(this.contrastRevRadio);
            this.groupBox1.Controls.Add(this.BYtintRadio);
            this.groupBox1.Controls.Add(this.RCcontrastRadio);
            this.groupBox1.Controls.Add(this.GMtintRadio);
            this.groupBox1.Controls.Add(this.RCtintRadio);
            this.groupBox1.Controls.Add(this.colorFinderRadio);
            this.groupBox1.Controls.Add(this.brightnessRadio);
            this.groupBox1.Controls.Add(this.pixelRadio);
            this.groupBox1.Controls.Add(this.colorEvenerRadio);
            this.groupBox1.Controls.Add(this.addColorRadio);
            this.groupBox1.Controls.Add(this.scrambleRadio);
            this.groupBox1.Controls.Add(this.negativeRadio);
            this.groupBox1.Controls.Add(this.noiseRadio);
            this.groupBox1.Controls.Add(this.tintRadio);
            this.groupBox1.Controls.Add(this.bwRadio);
            this.groupBox1.Controls.Add(this.contrastRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 534);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modification Type";
            // 
            // addColorRadio
            // 
            this.addColorRadio.AutoSize = true;
            this.addColorRadio.Location = new System.Drawing.Point(6, 52);
            this.addColorRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addColorRadio.Name = "addColorRadio";
            this.addColorRadio.Size = new System.Drawing.Size(77, 17);
            this.addColorRadio.TabIndex = 8;
            this.addColorRadio.TabStop = true;
            this.addColorRadio.Text = "Add Colour";
            this.addColorRadio.UseVisualStyleBackColor = true;
            // 
            // scrambleRadio
            // 
            this.scrambleRadio.AutoSize = true;
            this.scrambleRadio.Location = new System.Drawing.Point(5, 163);
            this.scrambleRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scrambleRadio.Name = "scrambleRadio";
            this.scrambleRadio.Size = new System.Drawing.Size(69, 17);
            this.scrambleRadio.TabIndex = 7;
            this.scrambleRadio.TabStop = true;
            this.scrambleRadio.Text = "Scramble";
            this.scrambleRadio.UseVisualStyleBackColor = true;
            this.scrambleRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // negativeRadio
            // 
            this.negativeRadio.AutoSize = true;
            this.negativeRadio.Location = new System.Drawing.Point(6, 73);
            this.negativeRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.negativeRadio.Name = "negativeRadio";
            this.negativeRadio.Size = new System.Drawing.Size(68, 17);
            this.negativeRadio.TabIndex = 6;
            this.negativeRadio.TabStop = true;
            this.negativeRadio.Text = "Negative";
            this.negativeRadio.UseVisualStyleBackColor = true;
            this.negativeRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // noiseRadio
            // 
            this.noiseRadio.AutoSize = true;
            this.noiseRadio.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.noiseRadio.Location = new System.Drawing.Point(6, 95);
            this.noiseRadio.Name = "noiseRadio";
            this.noiseRadio.Size = new System.Drawing.Size(52, 17);
            this.noiseRadio.TabIndex = 5;
            this.noiseRadio.TabStop = true;
            this.noiseRadio.Text = "Noise";
            this.noiseRadio.UseVisualStyleBackColor = true;
            this.noiseRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // tintRadio
            // 
            this.tintRadio.AutoSize = true;
            this.tintRadio.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tintRadio.Location = new System.Drawing.Point(5, 231);
            this.tintRadio.Name = "tintRadio";
            this.tintRadio.Size = new System.Drawing.Size(81, 17);
            this.tintRadio.TabIndex = 3;
            this.tintRadio.TabStop = true;
            this.tintRadio.Text = "Original Tint";
            this.tintRadio.UseVisualStyleBackColor = true;
            this.tintRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // bwRadio
            // 
            this.bwRadio.AutoSize = true;
            this.bwRadio.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bwRadio.Location = new System.Drawing.Point(6, 30);
            this.bwRadio.Name = "bwRadio";
            this.bwRadio.Size = new System.Drawing.Size(86, 17);
            this.bwRadio.TabIndex = 4;
            this.bwRadio.TabStop = true;
            this.bwRadio.Text = "Black & White";
            this.bwRadio.UseVisualStyleBackColor = true;
            this.bwRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // contrastRadio
            // 
            this.contrastRadio.AutoSize = true;
            this.contrastRadio.Checked = true;
            this.contrastRadio.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.contrastRadio.Location = new System.Drawing.Point(6, 323);
            this.contrastRadio.Name = "contrastRadio";
            this.contrastRadio.Size = new System.Drawing.Size(102, 17);
            this.contrastRadio.TabIndex = 2;
            this.contrastRadio.TabStop = true;
            this.contrastRadio.Text = "Original Contrast";
            this.contrastRadio.UseVisualStyleBackColor = true;
            this.contrastRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // modificationSlider
            // 
            this.modificationSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modificationSlider.Location = new System.Drawing.Point(184, 640);
            this.modificationSlider.Maximum = 100;
            this.modificationSlider.Name = "modificationSlider";
            this.modificationSlider.Size = new System.Drawing.Size(994, 45);
            this.modificationSlider.TabIndex = 6;
            this.modificationSlider.TickFrequency = 5;
            this.modificationSlider.ValueChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // transformBtn
            // 
            this.transformBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.transformBtn.Enabled = false;
            this.transformBtn.Location = new System.Drawing.Point(12, 651);
            this.transformBtn.Name = "transformBtn";
            this.transformBtn.Size = new System.Drawing.Size(165, 34);
            this.transformBtn.TabIndex = 7;
            this.transformBtn.Text = "Transform";
            this.transformBtn.UseVisualStyleBackColor = true;
            this.transformBtn.Click += new System.EventHandler(this.transformBtn_Click);
            // 
            // smallSlideLabel
            // 
            this.smallSlideLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.smallSlideLabel.AutoSize = true;
            this.smallSlideLabel.Location = new System.Drawing.Point(183, 672);
            this.smallSlideLabel.Name = "smallSlideLabel";
            this.smallSlideLabel.Size = new System.Drawing.Size(29, 13);
            this.smallSlideLabel.TabIndex = 4;
            this.smallSlideLabel.Text = "Less";
            // 
            // bigSlideLabel
            // 
            this.bigSlideLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bigSlideLabel.AutoSize = true;
            this.bigSlideLabel.Location = new System.Drawing.Point(1147, 672);
            this.bigSlideLabel.Name = "bigSlideLabel";
            this.bigSlideLabel.Size = new System.Drawing.Size(31, 13);
            this.bigSlideLabel.TabIndex = 5;
            this.bigSlideLabel.Text = "More";
            // 
            // pictureDialog
            // 
            this.pictureDialog.FileName = "openFileDialog1";
            this.pictureDialog.FilterIndex = 3;
            this.pictureDialog.RestoreDirectory = true;
            // 
            // trackValue
            // 
            this.trackValue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackValue.AutoSize = true;
            this.trackValue.Location = new System.Drawing.Point(675, 672);
            this.trackValue.Name = "trackValue";
            this.trackValue.Size = new System.Drawing.Size(13, 13);
            this.trackValue.TabIndex = 6;
            this.trackValue.Text = "0";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(184, 621);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(994, 13);
            this.progressBar.TabIndex = 8;
            // 
            // savePictureBtn
            // 
            this.savePictureBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.savePictureBtn.Location = new System.Drawing.Point(11, 605);
            this.savePictureBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.savePictureBtn.Name = "savePictureBtn";
            this.savePictureBtn.Size = new System.Drawing.Size(165, 34);
            this.savePictureBtn.TabIndex = 9;
            this.savePictureBtn.Text = "Save Picture";
            this.savePictureBtn.UseVisualStyleBackColor = true;
            this.savePictureBtn.Click += new System.EventHandler(this.savePictureBtn_Click);
            // 
            // colorEvenerRadio
            // 
            this.colorEvenerRadio.AutoSize = true;
            this.colorEvenerRadio.Location = new System.Drawing.Point(7, 118);
            this.colorEvenerRadio.Name = "colorEvenerRadio";
            this.colorEvenerRadio.Size = new System.Drawing.Size(92, 17);
            this.colorEvenerRadio.TabIndex = 9;
            this.colorEvenerRadio.TabStop = true;
            this.colorEvenerRadio.Text = "Colour Evener";
            this.colorEvenerRadio.UseVisualStyleBackColor = true;
            // 
            // pixelRadio
            // 
            this.pixelRadio.AutoSize = true;
            this.pixelRadio.Location = new System.Drawing.Point(6, 141);
            this.pixelRadio.Name = "pixelRadio";
            this.pixelRadio.Size = new System.Drawing.Size(63, 17);
            this.pixelRadio.TabIndex = 10;
            this.pixelRadio.TabStop = true;
            this.pixelRadio.Text = "Pixelizer";
            this.pixelRadio.UseVisualStyleBackColor = true;
            // 
            // brightnessRadio
            // 
            this.brightnessRadio.AutoSize = true;
            this.brightnessRadio.Location = new System.Drawing.Point(5, 185);
            this.brightnessRadio.Name = "brightnessRadio";
            this.brightnessRadio.Size = new System.Drawing.Size(74, 17);
            this.brightnessRadio.TabIndex = 11;
            this.brightnessRadio.TabStop = true;
            this.brightnessRadio.Text = "Brightness";
            this.brightnessRadio.UseVisualStyleBackColor = true;
            // 
            // colorFinderRadio
            // 
            this.colorFinderRadio.AutoSize = true;
            this.colorFinderRadio.Location = new System.Drawing.Point(5, 208);
            this.colorFinderRadio.Name = "colorFinderRadio";
            this.colorFinderRadio.Size = new System.Drawing.Size(87, 17);
            this.colorFinderRadio.TabIndex = 12;
            this.colorFinderRadio.TabStop = true;
            this.colorFinderRadio.Text = "Colour Finder";
            this.colorFinderRadio.UseVisualStyleBackColor = true;
            // 
            // RCtintRadio
            // 
            this.RCtintRadio.AutoSize = true;
            this.RCtintRadio.Location = new System.Drawing.Point(5, 254);
            this.RCtintRadio.Name = "RCtintRadio";
            this.RCtintRadio.Size = new System.Drawing.Size(99, 17);
            this.RCtintRadio.TabIndex = 13;
            this.RCtintRadio.TabStop = true;
            this.RCtintRadio.Text = "Red - Cyan Tint";
            this.RCtintRadio.UseVisualStyleBackColor = true;
            // 
            // GMtintRadio
            // 
            this.GMtintRadio.AutoSize = true;
            this.GMtintRadio.Location = new System.Drawing.Point(5, 277);
            this.GMtintRadio.Name = "GMtintRadio";
            this.GMtintRadio.Size = new System.Drawing.Size(126, 17);
            this.GMtintRadio.TabIndex = 14;
            this.GMtintRadio.TabStop = true;
            this.GMtintRadio.Text = "Green - Magenta Tint";
            this.GMtintRadio.UseVisualStyleBackColor = true;
            // 
            // RCcontrastRadio
            // 
            this.RCcontrastRadio.AutoSize = true;
            this.RCcontrastRadio.Location = new System.Drawing.Point(5, 369);
            this.RCcontrastRadio.Name = "RCcontrastRadio";
            this.RCcontrastRadio.Size = new System.Drawing.Size(120, 17);
            this.RCcontrastRadio.TabIndex = 15;
            this.RCcontrastRadio.TabStop = true;
            this.RCcontrastRadio.Text = "Red - Cyan Contrast";
            this.RCcontrastRadio.UseVisualStyleBackColor = true;
            // 
            // BYtintRadio
            // 
            this.BYtintRadio.AutoSize = true;
            this.BYtintRadio.Location = new System.Drawing.Point(5, 300);
            this.BYtintRadio.Name = "BYtintRadio";
            this.BYtintRadio.Size = new System.Drawing.Size(107, 17);
            this.BYtintRadio.TabIndex = 16;
            this.BYtintRadio.TabStop = true;
            this.BYtintRadio.Text = "Blue - Yellow Tint";
            this.BYtintRadio.UseVisualStyleBackColor = true;
            // 
            // contrastRevRadio
            // 
            this.contrastRevRadio.AutoSize = true;
            this.contrastRevRadio.Location = new System.Drawing.Point(5, 346);
            this.contrastRevRadio.Name = "contrastRevRadio";
            this.contrastRevRadio.Size = new System.Drawing.Size(110, 17);
            this.contrastRevRadio.TabIndex = 17;
            this.contrastRevRadio.TabStop = true;
            this.contrastRevRadio.Text = "Contrast Reverser";
            this.contrastRevRadio.UseVisualStyleBackColor = true;
            // 
            // GMcontrastRadio
            // 
            this.GMcontrastRadio.AutoSize = true;
            this.GMcontrastRadio.Location = new System.Drawing.Point(5, 392);
            this.GMcontrastRadio.Name = "GMcontrastRadio";
            this.GMcontrastRadio.Size = new System.Drawing.Size(147, 17);
            this.GMcontrastRadio.TabIndex = 18;
            this.GMcontrastRadio.TabStop = true;
            this.GMcontrastRadio.Text = "Green - Magenta Contrast";
            this.GMcontrastRadio.UseVisualStyleBackColor = true;
            // 
            // BYcontrastRadio
            // 
            this.BYcontrastRadio.AutoSize = true;
            this.BYcontrastRadio.Location = new System.Drawing.Point(5, 415);
            this.BYcontrastRadio.Name = "BYcontrastRadio";
            this.BYcontrastRadio.Size = new System.Drawing.Size(128, 17);
            this.BYcontrastRadio.TabIndex = 19;
            this.BYcontrastRadio.TabStop = true;
            this.BYcontrastRadio.Text = "Blue - Yellow Contrast";
            this.BYcontrastRadio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.savePictureBtn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.trackValue);
            this.Controls.Add(this.bigSlideLabel);
            this.Controls.Add(this.smallSlideLabel);
            this.Controls.Add(this.transformBtn);
            this.Controls.Add(this.loadPicture);
            this.Controls.Add(this.modificationSlider);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Lab 2 - Pic Bender";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modificationSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button loadPicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton noiseRadio;
        private System.Windows.Forms.RadioButton tintRadio;
        private System.Windows.Forms.RadioButton bwRadio;
        private System.Windows.Forms.RadioButton contrastRadio;
        private System.Windows.Forms.TrackBar modificationSlider;
        private System.Windows.Forms.Button transformBtn;
        private System.Windows.Forms.Label smallSlideLabel;
        private System.Windows.Forms.Label bigSlideLabel;
        private System.Windows.Forms.OpenFileDialog pictureDialog;
        private System.Windows.Forms.Label trackValue;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton scrambleRadio;
        private System.Windows.Forms.RadioButton negativeRadio;
        private System.Windows.Forms.Button savePictureBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RadioButton addColorRadio;
        private System.Windows.Forms.RadioButton colorEvenerRadio;
        private System.Windows.Forms.RadioButton pixelRadio;
        private System.Windows.Forms.RadioButton brightnessRadio;
        private System.Windows.Forms.RadioButton RCtintRadio;
        private System.Windows.Forms.RadioButton colorFinderRadio;
        private System.Windows.Forms.RadioButton GMcontrastRadio;
        private System.Windows.Forms.RadioButton contrastRevRadio;
        private System.Windows.Forms.RadioButton BYtintRadio;
        private System.Windows.Forms.RadioButton RCcontrastRadio;
        private System.Windows.Forms.RadioButton GMtintRadio;
        private System.Windows.Forms.RadioButton BYcontrastRadio;
    }
}

