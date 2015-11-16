namespace ControlClassLibrary
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
			this.playing = new System.Windows.Forms.CheckBox();
			this.markerBar1 = new ControlClassLibrary.MarkerBar();
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
			// markerBar1
			// 
			this.markerBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.markerBar1.BackColor = System.Drawing.Color.Gray;
			this.markerBar1.BarColor = System.Drawing.Color.Green;
			this.markerBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.markerBar1.Cursor = System.Windows.Forms.Cursors.VSplit;
			this.markerBar1.Decimals = ((byte)(4));
			this.markerBar1.ForeColor = System.Drawing.Color.White;
			this.markerBar1.Location = new System.Drawing.Point(28, 0);
			this.markerBar1.Max = 1F;
			this.markerBar1.Min = 0F;
			this.markerBar1.Name = "markerBar1";
			this.markerBar1.ShowText = false;
			this.markerBar1.Size = new System.Drawing.Size(749, 34);
			this.markerBar1.TabIndex = 0;
			this.markerBar1.Text = "markerBar1";
			this.markerBar1.Value = 0F;
			// 
			// SoundPlayerBar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.playing);
			this.Controls.Add(this.markerBar1);
			this.Name = "SoundPlayerBar";
			this.Size = new System.Drawing.Size(777, 34);
			this.ResumeLayout(false);

		}

		#endregion

		private MarkerBar markerBar1;
		private System.Windows.Forms.CheckBox playing;
	}
}
