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
            this.BYcontrastRadio = new System.Windows.Forms.RadioButton();
            this.GMcontrastRadio = new System.Windows.Forms.RadioButton();
            this.contrastRevRadio = new System.Windows.Forms.RadioButton();
            this.BYtintRadio = new System.Windows.Forms.RadioButton();
            this.RCcontrastRadio = new System.Windows.Forms.RadioButton();
            this.GMtintRadio = new System.Windows.Forms.RadioButton();
            this.RCtintRadio = new System.Windows.Forms.RadioButton();
            this.colorFinderRadio = new System.Windows.Forms.RadioButton();
            this.brightnessRadio = new System.Windows.Forms.RadioButton();
            this.pixelRadio = new System.Windows.Forms.RadioButton();
            this.colorEvenerRadio = new System.Windows.Forms.RadioButton();
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
            this.pictureBox.Location = new System.Drawing.Point(245, 15);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1070, 636);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // loadPicture
            // 
            this.loadPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadPicture.Location = new System.Drawing.Point(15, 585);
            this.loadPicture.Margin = new System.Windows.Forms.Padding(4);
            this.loadPicture.Name = "loadPicture";
            this.loadPicture.Size = new System.Drawing.Size(220, 42);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(220, 553);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modification Type";
            // 
            // BYcontrastRadio
            // 
            this.BYcontrastRadio.AutoSize = true;
            this.BYcontrastRadio.Location = new System.Drawing.Point(7, 511);
            this.BYcontrastRadio.Margin = new System.Windows.Forms.Padding(4);
            this.BYcontrastRadio.Name = "BYcontrastRadio";
            this.BYcontrastRadio.Size = new System.Drawing.Size(157, 20);
            this.BYcontrastRadio.TabIndex = 19;
            this.BYcontrastRadio.TabStop = true;
            this.BYcontrastRadio.Text = "Blue - Yellow Contrast";
            this.BYcontrastRadio.UseVisualStyleBackColor = true;
            this.BYcontrastRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // GMcontrastRadio
            // 
            this.GMcontrastRadio.AutoSize = true;
            this.GMcontrastRadio.Location = new System.Drawing.Point(7, 482);
            this.GMcontrastRadio.Margin = new System.Windows.Forms.Padding(4);
            this.GMcontrastRadio.Name = "GMcontrastRadio";
            this.GMcontrastRadio.Size = new System.Drawing.Size(180, 20);
            this.GMcontrastRadio.TabIndex = 18;
            this.GMcontrastRadio.TabStop = true;
            this.GMcontrastRadio.Text = "Green - Magenta Contrast";
            this.GMcontrastRadio.UseVisualStyleBackColor = true;
            this.GMcontrastRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // contrastRevRadio
            // 
            this.contrastRevRadio.AutoSize = true;
            this.contrastRevRadio.Location = new System.Drawing.Point(7, 426);
            this.contrastRevRadio.Margin = new System.Windows.Forms.Padding(4);
            this.contrastRevRadio.Name = "contrastRevRadio";
            this.contrastRevRadio.Size = new System.Drawing.Size(136, 20);
            this.contrastRevRadio.TabIndex = 17;
            this.contrastRevRadio.TabStop = true;
            this.contrastRevRadio.Text = "Contrast Reverser";
            this.contrastRevRadio.UseVisualStyleBackColor = true;
            this.contrastRevRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // BYtintRadio
            // 
            this.BYtintRadio.AutoSize = true;
            this.BYtintRadio.Location = new System.Drawing.Point(7, 369);
            this.BYtintRadio.Margin = new System.Windows.Forms.Padding(4);
            this.BYtintRadio.Name = "BYtintRadio";
            this.BYtintRadio.Size = new System.Drawing.Size(130, 20);
            this.BYtintRadio.TabIndex = 16;
            this.BYtintRadio.TabStop = true;
            this.BYtintRadio.Text = "Blue - Yellow Tint";
            this.BYtintRadio.UseVisualStyleBackColor = true;
            this.BYtintRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // RCcontrastRadio
            // 
            this.RCcontrastRadio.AutoSize = true;
            this.RCcontrastRadio.Location = new System.Drawing.Point(7, 454);
            this.RCcontrastRadio.Margin = new System.Windows.Forms.Padding(4);
            this.RCcontrastRadio.Name = "RCcontrastRadio";
            this.RCcontrastRadio.Size = new System.Drawing.Size(147, 20);
            this.RCcontrastRadio.TabIndex = 15;
            this.RCcontrastRadio.TabStop = true;
            this.RCcontrastRadio.Text = "Red - Cyan Contrast";
            this.RCcontrastRadio.UseVisualStyleBackColor = true;
            this.RCcontrastRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // GMtintRadio
            // 
            this.GMtintRadio.AutoSize = true;
            this.GMtintRadio.Location = new System.Drawing.Point(7, 341);
            this.GMtintRadio.Margin = new System.Windows.Forms.Padding(4);
            this.GMtintRadio.Name = "GMtintRadio";
            this.GMtintRadio.Size = new System.Drawing.Size(153, 20);
            this.GMtintRadio.TabIndex = 14;
            this.GMtintRadio.TabStop = true;
            this.GMtintRadio.Text = "Green - Magenta Tint";
            this.GMtintRadio.UseVisualStyleBackColor = true;
            this.GMtintRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // RCtintRadio
            // 
            this.RCtintRadio.AutoSize = true;
            this.RCtintRadio.Location = new System.Drawing.Point(7, 313);
            this.RCtintRadio.Margin = new System.Windows.Forms.Padding(4);
            this.RCtintRadio.Name = "RCtintRadio";
            this.RCtintRadio.Size = new System.Drawing.Size(120, 20);
            this.RCtintRadio.TabIndex = 13;
            this.RCtintRadio.TabStop = true;
            this.RCtintRadio.Text = "Red - Cyan Tint";
            this.RCtintRadio.UseVisualStyleBackColor = true;
            this.RCtintRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // colorFinderRadio
            // 
            this.colorFinderRadio.AutoSize = true;
            this.colorFinderRadio.Location = new System.Drawing.Point(7, 256);
            this.colorFinderRadio.Margin = new System.Windows.Forms.Padding(4);
            this.colorFinderRadio.Name = "colorFinderRadio";
            this.colorFinderRadio.Size = new System.Drawing.Size(108, 20);
            this.colorFinderRadio.TabIndex = 12;
            this.colorFinderRadio.TabStop = true;
            this.colorFinderRadio.Text = "Colour Finder";
            this.colorFinderRadio.UseVisualStyleBackColor = true;
            this.colorFinderRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // brightnessRadio
            // 
            this.brightnessRadio.AutoSize = true;
            this.brightnessRadio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.brightnessRadio.Location = new System.Drawing.Point(7, 228);
            this.brightnessRadio.Margin = new System.Windows.Forms.Padding(4);
            this.brightnessRadio.Name = "brightnessRadio";
            this.brightnessRadio.Size = new System.Drawing.Size(91, 20);
            this.brightnessRadio.TabIndex = 11;
            this.brightnessRadio.TabStop = true;
            this.brightnessRadio.Text = "Brightness";
            this.brightnessRadio.UseVisualStyleBackColor = true;
            this.brightnessRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // pixelRadio
            // 
            this.pixelRadio.AutoSize = true;
            this.pixelRadio.Location = new System.Drawing.Point(8, 174);
            this.pixelRadio.Margin = new System.Windows.Forms.Padding(4);
            this.pixelRadio.Name = "pixelRadio";
            this.pixelRadio.Size = new System.Drawing.Size(78, 20);
            this.pixelRadio.TabIndex = 10;
            this.pixelRadio.TabStop = true;
            this.pixelRadio.Text = "Pixelizer";
            this.pixelRadio.UseVisualStyleBackColor = true;
            this.pixelRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // colorEvenerRadio
            // 
            this.colorEvenerRadio.AutoSize = true;
            this.colorEvenerRadio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colorEvenerRadio.Location = new System.Drawing.Point(9, 145);
            this.colorEvenerRadio.Margin = new System.Windows.Forms.Padding(4);
            this.colorEvenerRadio.Name = "colorEvenerRadio";
            this.colorEvenerRadio.Size = new System.Drawing.Size(113, 20);
            this.colorEvenerRadio.TabIndex = 9;
            this.colorEvenerRadio.TabStop = true;
            this.colorEvenerRadio.Text = "Colour Evener";
            this.colorEvenerRadio.UseVisualStyleBackColor = true;
            this.colorEvenerRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // addColorRadio
            // 
            this.addColorRadio.AutoSize = true;
            this.addColorRadio.ForeColor = System.Drawing.Color.Black;
            this.addColorRadio.Location = new System.Drawing.Point(8, 64);
            this.addColorRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addColorRadio.Name = "addColorRadio";
            this.addColorRadio.Size = new System.Drawing.Size(95, 20);
            this.addColorRadio.TabIndex = 8;
            this.addColorRadio.TabStop = true;
            this.addColorRadio.Text = "Add Colour";
            this.addColorRadio.UseVisualStyleBackColor = true;
            this.addColorRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // scrambleRadio
            // 
            this.scrambleRadio.AutoSize = true;
            this.scrambleRadio.Location = new System.Drawing.Point(7, 201);
            this.scrambleRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scrambleRadio.Name = "scrambleRadio";
            this.scrambleRadio.Size = new System.Drawing.Size(86, 20);
            this.scrambleRadio.TabIndex = 7;
            this.scrambleRadio.TabStop = true;
            this.scrambleRadio.Text = "Scramble";
            this.scrambleRadio.UseVisualStyleBackColor = true;
            this.scrambleRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // negativeRadio
            // 
            this.negativeRadio.AutoSize = true;
            this.negativeRadio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.negativeRadio.Location = new System.Drawing.Point(8, 90);
            this.negativeRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.negativeRadio.Name = "negativeRadio";
            this.negativeRadio.Size = new System.Drawing.Size(83, 20);
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
            this.noiseRadio.Location = new System.Drawing.Point(8, 117);
            this.noiseRadio.Margin = new System.Windows.Forms.Padding(4);
            this.noiseRadio.Name = "noiseRadio";
            this.noiseRadio.Size = new System.Drawing.Size(64, 20);
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
            this.tintRadio.Location = new System.Drawing.Point(7, 284);
            this.tintRadio.Margin = new System.Windows.Forms.Padding(4);
            this.tintRadio.Name = "tintRadio";
            this.tintRadio.Size = new System.Drawing.Size(99, 20);
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
            this.bwRadio.Location = new System.Drawing.Point(8, 37);
            this.bwRadio.Margin = new System.Windows.Forms.Padding(4);
            this.bwRadio.Name = "bwRadio";
            this.bwRadio.Size = new System.Drawing.Size(102, 20);
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
            this.contrastRadio.Location = new System.Drawing.Point(8, 398);
            this.contrastRadio.Margin = new System.Windows.Forms.Padding(4);
            this.contrastRadio.Name = "contrastRadio";
            this.contrastRadio.Size = new System.Drawing.Size(126, 20);
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
            this.modificationSlider.Location = new System.Drawing.Point(245, 694);
            this.modificationSlider.Margin = new System.Windows.Forms.Padding(4);
            this.modificationSlider.Maximum = 100;
            this.modificationSlider.Name = "modificationSlider";
            this.modificationSlider.Size = new System.Drawing.Size(1070, 56);
            this.modificationSlider.TabIndex = 6;
            this.modificationSlider.TickFrequency = 5;
            this.modificationSlider.ValueChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // transformBtn
            // 
            this.transformBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.transformBtn.Enabled = false;
            this.transformBtn.Location = new System.Drawing.Point(16, 707);
            this.transformBtn.Margin = new System.Windows.Forms.Padding(4);
            this.transformBtn.Name = "transformBtn";
            this.transformBtn.Size = new System.Drawing.Size(220, 42);
            this.transformBtn.TabIndex = 7;
            this.transformBtn.Text = "Transform";
            this.transformBtn.UseVisualStyleBackColor = true;
            this.transformBtn.Click += new System.EventHandler(this.transformBtn_Click);
            // 
            // smallSlideLabel
            // 
            this.smallSlideLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.smallSlideLabel.AutoSize = true;
            this.smallSlideLabel.Location = new System.Drawing.Point(286, 734);
            this.smallSlideLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.smallSlideLabel.Name = "smallSlideLabel";
            this.smallSlideLabel.Size = new System.Drawing.Size(36, 16);
            this.smallSlideLabel.TabIndex = 4;
            this.smallSlideLabel.Text = "Less";
            // 
            // bigSlideLabel
            // 
            this.bigSlideLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bigSlideLabel.AutoSize = true;
            this.bigSlideLabel.Location = new System.Drawing.Point(1233, 733);
            this.bigSlideLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bigSlideLabel.Name = "bigSlideLabel";
            this.bigSlideLabel.Size = new System.Drawing.Size(38, 16);
            this.bigSlideLabel.TabIndex = 5;
            this.bigSlideLabel.Text = "More";
            this.bigSlideLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.trackValue.Location = new System.Drawing.Point(773, 733);
            this.trackValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trackValue.Name = "trackValue";
            this.trackValue.Size = new System.Drawing.Size(14, 16);
            this.trackValue.TabIndex = 6;
            this.trackValue.Text = "0";
            this.trackValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(245, 670);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1070, 16);
            this.progressBar.TabIndex = 8;
            // 
            // savePictureBtn
            // 
            this.savePictureBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.savePictureBtn.Location = new System.Drawing.Point(15, 651);
            this.savePictureBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.savePictureBtn.Name = "savePictureBtn";
            this.savePictureBtn.Size = new System.Drawing.Size(220, 42);
            this.savePictureBtn.TabIndex = 9;
            this.savePictureBtn.Text = "Save Picture";
            this.savePictureBtn.UseVisualStyleBackColor = true;
            this.savePictureBtn.Click += new System.EventHandler(this.savePictureBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 781);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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

