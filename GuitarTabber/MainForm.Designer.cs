﻿namespace GuitarTabber
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
			this.components = new System.ComponentModel.Container();
			this.btnStartRecording = new System.Windows.Forms.Button();
			this.btnStopRecording = new System.Windows.Forms.Button();
			this.tmrMetronome = new System.Windows.Forms.Timer(this.components);
			this.udBpm = new System.Windows.Forms.NumericUpDown();
			this.chkMetronomeOn = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtString1Tuning = new System.Windows.Forms.TextBox();
			this.txtString2Tuning = new System.Windows.Forms.TextBox();
			this.txtString3Tuning = new System.Windows.Forms.TextBox();
			this.txtString4Tuning = new System.Windows.Forms.TextBox();
			this.txtString5Tuning = new System.Windows.Forms.TextBox();
			this.txtString6Tuning = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBeatsPerMeasure = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblVolume = new System.Windows.Forms.Label();
			this.lblFrequency = new System.Windows.Forms.Label();
			this.picFFT1 = new System.Windows.Forms.PictureBox();
			this.picAudioData = new System.Windows.Forms.PictureBox();
			this.tmrReadAudio = new System.Windows.Forms.Timer(this.components);
			this.tbFFTScale = new System.Windows.Forms.TrackBar();
			this.label6 = new System.Windows.Forms.Label();
			this.btnBeginAnalyzing = new System.Windows.Forms.Button();
			this.picFFT2 = new System.Windows.Forms.PictureBox();
			this.picFFT3 = new System.Windows.Forms.PictureBox();
			this.picFFT4 = new System.Windows.Forms.PictureBox();
			this.picFFT5 = new System.Windows.Forms.PictureBox();
			this.picFFT6 = new System.Windows.Forms.PictureBox();
			this.picFFT7 = new System.Windows.Forms.PictureBox();
			this.picFFT8 = new System.Windows.Forms.PictureBox();
			this.picFFT9 = new System.Windows.Forms.PictureBox();
			this.lblFreqs = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.udBpm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFFT1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picAudioData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbFFTScale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFFT2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFFT3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFFT4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFFT5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFFT6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFFT7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFFT8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFFT9)).BeginInit();
			this.SuspendLayout();
			// 
			// btnStartRecording
			// 
			this.btnStartRecording.Location = new System.Drawing.Point(1057, 567);
			this.btnStartRecording.Name = "btnStartRecording";
			this.btnStartRecording.Size = new System.Drawing.Size(122, 34);
			this.btnStartRecording.TabIndex = 0;
			this.btnStartRecording.Text = "Start Recording";
			this.btnStartRecording.UseVisualStyleBackColor = true;
			this.btnStartRecording.Click += new System.EventHandler(this.btnStartRecording_Click);
			// 
			// btnStopRecording
			// 
			this.btnStopRecording.Location = new System.Drawing.Point(1057, 607);
			this.btnStopRecording.Name = "btnStopRecording";
			this.btnStopRecording.Size = new System.Drawing.Size(122, 34);
			this.btnStopRecording.TabIndex = 1;
			this.btnStopRecording.Text = "Stop Recording";
			this.btnStopRecording.UseVisualStyleBackColor = true;
			this.btnStopRecording.Click += new System.EventHandler(this.btnStopRecording_Click);
			// 
			// tmrMetronome
			// 
			this.tmrMetronome.Enabled = true;
			this.tmrMetronome.Interval = 400;
			this.tmrMetronome.Tick += new System.EventHandler(this.tmrMetronome_Tick);
			// 
			// udBpm
			// 
			this.udBpm.Location = new System.Drawing.Point(49, 11);
			this.udBpm.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.udBpm.Name = "udBpm";
			this.udBpm.Size = new System.Drawing.Size(62, 20);
			this.udBpm.TabIndex = 3;
			this.udBpm.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.udBpm.ValueChanged += new System.EventHandler(this.udBpm_ValueChanged);
			// 
			// chkMetronomeOn
			// 
			this.chkMetronomeOn.AutoSize = true;
			this.chkMetronomeOn.Location = new System.Drawing.Point(117, 14);
			this.chkMetronomeOn.Name = "chkMetronomeOn";
			this.chkMetronomeOn.Size = new System.Drawing.Size(96, 17);
			this.chkMetronomeOn.TabIndex = 4;
			this.chkMetronomeOn.Text = "Metronome On";
			this.chkMetronomeOn.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "BPM:";
			// 
			// txtString1Tuning
			// 
			this.txtString1Tuning.Location = new System.Drawing.Point(383, 32);
			this.txtString1Tuning.Name = "txtString1Tuning";
			this.txtString1Tuning.Size = new System.Drawing.Size(17, 20);
			this.txtString1Tuning.TabIndex = 6;
			this.txtString1Tuning.Text = "E";
			// 
			// txtString2Tuning
			// 
			this.txtString2Tuning.Location = new System.Drawing.Point(406, 32);
			this.txtString2Tuning.Name = "txtString2Tuning";
			this.txtString2Tuning.Size = new System.Drawing.Size(17, 20);
			this.txtString2Tuning.TabIndex = 7;
			this.txtString2Tuning.Text = "A";
			// 
			// txtString3Tuning
			// 
			this.txtString3Tuning.Location = new System.Drawing.Point(429, 32);
			this.txtString3Tuning.Name = "txtString3Tuning";
			this.txtString3Tuning.Size = new System.Drawing.Size(17, 20);
			this.txtString3Tuning.TabIndex = 8;
			this.txtString3Tuning.Text = "D";
			// 
			// txtString4Tuning
			// 
			this.txtString4Tuning.Location = new System.Drawing.Point(452, 32);
			this.txtString4Tuning.Name = "txtString4Tuning";
			this.txtString4Tuning.Size = new System.Drawing.Size(17, 20);
			this.txtString4Tuning.TabIndex = 9;
			this.txtString4Tuning.Text = "G";
			// 
			// txtString5Tuning
			// 
			this.txtString5Tuning.Location = new System.Drawing.Point(475, 32);
			this.txtString5Tuning.Name = "txtString5Tuning";
			this.txtString5Tuning.Size = new System.Drawing.Size(17, 20);
			this.txtString5Tuning.TabIndex = 10;
			this.txtString5Tuning.Text = "B";
			// 
			// txtString6Tuning
			// 
			this.txtString6Tuning.Location = new System.Drawing.Point(498, 32);
			this.txtString6Tuning.Name = "txtString6Tuning";
			this.txtString6Tuning.Size = new System.Drawing.Size(17, 20);
			this.txtString6Tuning.TabIndex = 11;
			this.txtString6Tuning.Text = "e";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(380, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "String Tuning (s: sharp, f:flat):";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Beats per measure:";
			// 
			// txtBeatsPerMeasure
			// 
			this.txtBeatsPerMeasure.Location = new System.Drawing.Point(113, 37);
			this.txtBeatsPerMeasure.Name = "txtBeatsPerMeasure";
			this.txtBeatsPerMeasure.Size = new System.Drawing.Size(26, 20);
			this.txtBeatsPerMeasure.TabIndex = 14;
			this.txtBeatsPerMeasure.Text = "4";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(819, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "volume (dB):";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(32, 79);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "frequency (Hz):";
			// 
			// lblVolume
			// 
			this.lblVolume.AutoSize = true;
			this.lblVolume.Location = new System.Drawing.Point(892, 13);
			this.lblVolume.Name = "lblVolume";
			this.lblVolume.Size = new System.Drawing.Size(0, 13);
			this.lblVolume.TabIndex = 17;
			// 
			// lblFrequency
			// 
			this.lblFrequency.AutoSize = true;
			this.lblFrequency.Location = new System.Drawing.Point(118, 79);
			this.lblFrequency.Name = "lblFrequency";
			this.lblFrequency.Size = new System.Drawing.Size(56, 13);
			this.lblFrequency.TabIndex = 18;
			this.lblFrequency.Text = "294.85 Hz";
			// 
			// picFFT1
			// 
			this.picFFT1.BackColor = System.Drawing.Color.White;
			this.picFFT1.Location = new System.Drawing.Point(32, 95);
			this.picFFT1.Name = "picFFT1";
			this.picFFT1.Size = new System.Drawing.Size(524, 80);
			this.picFFT1.TabIndex = 20;
			this.picFFT1.TabStop = false;
			// 
			// picAudioData
			// 
			this.picAudioData.BackColor = System.Drawing.Color.White;
			this.picAudioData.Location = new System.Drawing.Point(1049, 11);
			this.picAudioData.Name = "picAudioData";
			this.picAudioData.Size = new System.Drawing.Size(160, 218);
			this.picAudioData.TabIndex = 21;
			this.picAudioData.TabStop = false;
			// 
			// tmrReadAudio
			// 
			this.tmrReadAudio.Enabled = true;
			this.tmrReadAudio.Interval = 250;
			this.tmrReadAudio.Tick += new System.EventHandler(this.TmrReadAudio_Tick);
			// 
			// tbFFTScale
			// 
			this.tbFFTScale.Location = new System.Drawing.Point(1049, 668);
			this.tbFFTScale.Name = "tbFFTScale";
			this.tbFFTScale.Size = new System.Drawing.Size(181, 45);
			this.tbFFTScale.TabIndex = 22;
			this.tbFFTScale.Value = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(143, 344);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(0, 13);
			this.label6.TabIndex = 23;
			// 
			// btnBeginAnalyzing
			// 
			this.btnBeginAnalyzing.BackColor = System.Drawing.SystemColors.Control;
			this.btnBeginAnalyzing.Location = new System.Drawing.Point(560, 11);
			this.btnBeginAnalyzing.Name = "btnBeginAnalyzing";
			this.btnBeginAnalyzing.Size = new System.Drawing.Size(154, 41);
			this.btnBeginAnalyzing.TabIndex = 24;
			this.btnBeginAnalyzing.Text = "Begin Analyzing";
			this.btnBeginAnalyzing.UseVisualStyleBackColor = false;
			// 
			// picFFT2
			// 
			this.picFFT2.BackColor = System.Drawing.Color.White;
			this.picFFT2.Location = new System.Drawing.Point(32, 181);
			this.picFFT2.Name = "picFFT2";
			this.picFFT2.Size = new System.Drawing.Size(524, 80);
			this.picFFT2.TabIndex = 25;
			this.picFFT2.TabStop = false;
			// 
			// picFFT3
			// 
			this.picFFT3.BackColor = System.Drawing.Color.White;
			this.picFFT3.Location = new System.Drawing.Point(32, 267);
			this.picFFT3.Name = "picFFT3";
			this.picFFT3.Size = new System.Drawing.Size(524, 80);
			this.picFFT3.TabIndex = 26;
			this.picFFT3.TabStop = false;
			// 
			// picFFT4
			// 
			this.picFFT4.BackColor = System.Drawing.Color.White;
			this.picFFT4.Location = new System.Drawing.Point(32, 381);
			this.picFFT4.Name = "picFFT4";
			this.picFFT4.Size = new System.Drawing.Size(980, 80);
			this.picFFT4.TabIndex = 27;
			this.picFFT4.TabStop = false;
			// 
			// picFFT5
			// 
			this.picFFT5.BackColor = System.Drawing.Color.White;
			this.picFFT5.Location = new System.Drawing.Point(32, 439);
			this.picFFT5.Name = "picFFT5";
			this.picFFT5.Size = new System.Drawing.Size(980, 80);
			this.picFFT5.TabIndex = 28;
			this.picFFT5.TabStop = false;
			// 
			// picFFT6
			// 
			this.picFFT6.BackColor = System.Drawing.Color.White;
			this.picFFT6.Location = new System.Drawing.Point(32, 525);
			this.picFFT6.Name = "picFFT6";
			this.picFFT6.Size = new System.Drawing.Size(980, 80);
			this.picFFT6.TabIndex = 29;
			this.picFFT6.TabStop = false;
			// 
			// picFFT7
			// 
			this.picFFT7.BackColor = System.Drawing.Color.White;
			this.picFFT7.Location = new System.Drawing.Point(32, 611);
			this.picFFT7.Name = "picFFT7";
			this.picFFT7.Size = new System.Drawing.Size(980, 80);
			this.picFFT7.TabIndex = 30;
			this.picFFT7.TabStop = false;
			// 
			// picFFT8
			// 
			this.picFFT8.BackColor = System.Drawing.Color.White;
			this.picFFT8.Location = new System.Drawing.Point(32, 697);
			this.picFFT8.Name = "picFFT8";
			this.picFFT8.Size = new System.Drawing.Size(980, 80);
			this.picFFT8.TabIndex = 31;
			this.picFFT8.TabStop = false;
			// 
			// picFFT9
			// 
			this.picFFT9.BackColor = System.Drawing.Color.White;
			this.picFFT9.Location = new System.Drawing.Point(32, 783);
			this.picFFT9.Name = "picFFT9";
			this.picFFT9.Size = new System.Drawing.Size(980, 80);
			this.picFFT9.TabIndex = 32;
			this.picFFT9.TabStop = false;
			// 
			// lblFreqs
			// 
			this.lblFreqs.AutoSize = true;
			this.lblFreqs.Location = new System.Drawing.Point(1037, 276);
			this.lblFreqs.Name = "lblFreqs";
			this.lblFreqs.Size = new System.Drawing.Size(0, 13);
			this.lblFreqs.TabIndex = 33;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1242, 888);
			this.Controls.Add(this.lblFreqs);
			this.Controls.Add(this.picFFT9);
			this.Controls.Add(this.picFFT8);
			this.Controls.Add(this.picFFT7);
			this.Controls.Add(this.picFFT6);
			this.Controls.Add(this.picFFT5);
			this.Controls.Add(this.picFFT4);
			this.Controls.Add(this.picFFT3);
			this.Controls.Add(this.picFFT2);
			this.Controls.Add(this.btnBeginAnalyzing);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbFFTScale);
			this.Controls.Add(this.picAudioData);
			this.Controls.Add(this.picFFT1);
			this.Controls.Add(this.lblFrequency);
			this.Controls.Add(this.lblVolume);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtBeatsPerMeasure);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtString6Tuning);
			this.Controls.Add(this.txtString5Tuning);
			this.Controls.Add(this.txtString4Tuning);
			this.Controls.Add(this.txtString3Tuning);
			this.Controls.Add(this.txtString2Tuning);
			this.Controls.Add(this.txtString1Tuning);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chkMetronomeOn);
			this.Controls.Add(this.udBpm);
			this.Controls.Add(this.btnStopRecording);
			this.Controls.Add(this.btnStartRecording);
			this.Name = "MainForm";
			this.Text = "Guitar Tabber";
			((System.ComponentModel.ISupportInitialize)(this.udBpm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFFT1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picAudioData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbFFTScale)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFFT2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFFT3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFFT4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFFT5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFFT6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFFT7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFFT8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFFT9)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStartRecording;
		private System.Windows.Forms.Button btnStopRecording;
		private System.Windows.Forms.Timer tmrMetronome;
		private System.Windows.Forms.NumericUpDown udBpm;
		private System.Windows.Forms.CheckBox chkMetronomeOn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtString1Tuning;
		private System.Windows.Forms.TextBox txtString2Tuning;
		private System.Windows.Forms.TextBox txtString3Tuning;
		private System.Windows.Forms.TextBox txtString4Tuning;
		private System.Windows.Forms.TextBox txtString5Tuning;
		private System.Windows.Forms.TextBox txtString6Tuning;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBeatsPerMeasure;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblVolume;
		private System.Windows.Forms.Label lblFrequency;
		private System.Windows.Forms.PictureBox picFFT1;
		private System.Windows.Forms.PictureBox picAudioData;
		private System.Windows.Forms.Timer tmrReadAudio;
		private System.Windows.Forms.TrackBar tbFFTScale;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnBeginAnalyzing;
		private System.Windows.Forms.PictureBox picFFT2;
		private System.Windows.Forms.PictureBox picFFT3;
		private System.Windows.Forms.PictureBox picFFT4;
		private System.Windows.Forms.PictureBox picFFT5;
		private System.Windows.Forms.PictureBox picFFT6;
		private System.Windows.Forms.PictureBox picFFT7;
		private System.Windows.Forms.PictureBox picFFT8;
		private System.Windows.Forms.PictureBox picFFT9;
		private System.Windows.Forms.Label lblFreqs;
	}
}

