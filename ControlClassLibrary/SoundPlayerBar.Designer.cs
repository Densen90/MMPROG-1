﻿namespace ControlClassLibrary
{
	partial class SoundPlayerBar
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Komponenten-Designer generierter Code

		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.playing = new System.Windows.Forms.CheckBox();
			this.timerUpdateMarkerBar = new System.Windows.Forms.Timer(this.components);
			this.markerBarPosition = new ControlClassLibrary.MarkerBar();
			this.SuspendLayout();
			// 
			// playing
			// 
			this.playing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.playing.Appearance = System.Windows.Forms.Appearance.Button;
			this.playing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.playing.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.playing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.playing.Image = global::ControlClassLibrary.Properties.Resources.PlayHS;
			this.playing.Location = new System.Drawing.Point(0, 0);
			this.playing.Name = "playing";
			this.playing.Size = new System.Drawing.Size(29, 34);
			this.playing.TabIndex = 1;
			this.playing.UseVisualStyleBackColor = true;
			this.playing.CheckedChanged += new System.EventHandler(this.playing_CheckedChanged);
			// 
			// timerUpdateMarkerBar
			// 
			this.timerUpdateMarkerBar.Interval = 10;
			this.timerUpdateMarkerBar.Tick += new System.EventHandler(this.timerUpdateMarkerBar_Tick);
			// 
			// markerBarPosition
			// 
			this.markerBarPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.markerBarPosition.BackColor = System.Drawing.Color.Gray;
			this.markerBarPosition.BarColor = System.Drawing.Color.Green;
			this.markerBarPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.markerBarPosition.Cursor = System.Windows.Forms.Cursors.VSplit;
			this.markerBarPosition.Decimals = ((byte)(2));
			this.markerBarPosition.ForeColor = System.Drawing.Color.White;
			this.markerBarPosition.Location = new System.Drawing.Point(28, 0);
			this.markerBarPosition.Max = 100F;
			this.markerBarPosition.Min = 0F;
			this.markerBarPosition.Name = "markerBarPosition";
			this.markerBarPosition.ShowText = false;
			this.markerBarPosition.Size = new System.Drawing.Size(749, 34);
			this.markerBarPosition.TabIndex = 0;
			this.markerBarPosition.Text = "markerBar1";
			this.markerBarPosition.Value = 0F;
			this.markerBarPosition.ValueChanged += new System.EventHandler(this.markerBar1_ValueChanged);
			// 
			// SoundPlayerBar
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.playing);
			this.Controls.Add(this.markerBarPosition);
			this.Name = "SoundPlayerBar";
			this.Size = new System.Drawing.Size(777, 34);
			this.ResumeLayout(false);

		}

		#endregion

		private MarkerBar markerBarPosition;
		private System.Windows.Forms.CheckBox playing;
		private System.Windows.Forms.Timer timerUpdateMarkerBar;
	}
}
