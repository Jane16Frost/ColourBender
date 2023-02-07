﻿namespace Lab2_Jai_leaFranson
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
            this.pictureBox.Location = new System.Drawing.Point(11, 5);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1048, 372);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // loadPicture
            // 
            this.loadPicture.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadPicture.Location = new System.Drawing.Point(12, 420);
            this.loadPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadPicture.Name = "loadPicture";
            this.loadPicture.Size = new System.Drawing.Size(160, 42);
            this.loadPicture.TabIndex = 1;
            this.loadPicture.Text = "Load Pictures";
            this.loadPicture.UseVisualStyleBackColor = true;
            this.loadPicture.Click += new System.EventHandler(this.LoadPicture);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.noiseRadio);
            this.groupBox1.Controls.Add(this.tintRadio);
            this.groupBox1.Controls.Add(this.bwRadio);
            this.groupBox1.Controls.Add(this.contrastRadio);
            this.groupBox1.Location = new System.Drawing.Point(199, 421);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(311, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modification Type";
            // 
            // noiseRadio
            // 
            this.noiseRadio.AutoSize = true;
            this.noiseRadio.Location = new System.Drawing.Point(165, 63);
            this.noiseRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.tintRadio.Location = new System.Drawing.Point(165, 34);
            this.tintRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tintRadio.Name = "tintRadio";
            this.tintRadio.Size = new System.Drawing.Size(50, 20);
            this.tintRadio.TabIndex = 3;
            this.tintRadio.TabStop = true;
            this.tintRadio.Text = "Tint";
            this.tintRadio.UseVisualStyleBackColor = true;
            this.tintRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // bwRadio
            // 
            this.bwRadio.AutoSize = true;
            this.bwRadio.Location = new System.Drawing.Point(25, 63);
            this.bwRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.contrastRadio.Location = new System.Drawing.Point(25, 34);
            this.contrastRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contrastRadio.Name = "contrastRadio";
            this.contrastRadio.Size = new System.Drawing.Size(77, 20);
            this.contrastRadio.TabIndex = 2;
            this.contrastRadio.TabStop = true;
            this.contrastRadio.Text = "Contrast";
            this.contrastRadio.UseVisualStyleBackColor = true;
            this.contrastRadio.CheckedChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // modificationSlider
            // 
            this.modificationSlider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.modificationSlider.Location = new System.Drawing.Point(535, 447);
            this.modificationSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modificationSlider.Maximum = 100;
            this.modificationSlider.Name = "modificationSlider";
            this.modificationSlider.Size = new System.Drawing.Size(359, 56);
            this.modificationSlider.TabIndex = 6;
            this.modificationSlider.TickFrequency = 10;
            this.modificationSlider.ValueChanged += new System.EventHandler(this.UpdateTrackBar);
            // 
            // transformBtn
            // 
            this.transformBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.transformBtn.Enabled = false;
            this.transformBtn.Location = new System.Drawing.Point(919, 420);
            this.transformBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transformBtn.Name = "transformBtn";
            this.transformBtn.Size = new System.Drawing.Size(132, 42);
            this.transformBtn.TabIndex = 7;
            this.transformBtn.Text = "Transform";
            this.transformBtn.UseVisualStyleBackColor = true;
            this.transformBtn.Click += new System.EventHandler(this.transformBtn_Click);
            // 
            // smallSlideLabel
            // 
            this.smallSlideLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.smallSlideLabel.AutoSize = true;
            this.smallSlideLabel.Location = new System.Drawing.Point(531, 506);
            this.smallSlideLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.smallSlideLabel.Name = "smallSlideLabel";
            this.smallSlideLabel.Size = new System.Drawing.Size(36, 16);
            this.smallSlideLabel.TabIndex = 4;
            this.smallSlideLabel.Text = "Less";
            // 
            // bigSlideLabel
            // 
            this.bigSlideLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bigSlideLabel.AutoSize = true;
            this.bigSlideLabel.Location = new System.Drawing.Point(852, 506);
            this.bigSlideLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bigSlideLabel.Name = "bigSlideLabel";
            this.bigSlideLabel.Size = new System.Drawing.Size(38, 16);
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
            this.trackValue.Location = new System.Drawing.Point(689, 506);
            this.trackValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trackValue.Name = "trackValue";
            this.trackValue.Size = new System.Drawing.Size(14, 16);
            this.trackValue.TabIndex = 6;
            this.trackValue.Text = "0";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(8, 384);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1051, 16);
            this.progressBar.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.trackValue);
            this.Controls.Add(this.bigSlideLabel);
            this.Controls.Add(this.smallSlideLabel);
            this.Controls.Add(this.transformBtn);
            this.Controls.Add(this.modificationSlider);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loadPicture);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

