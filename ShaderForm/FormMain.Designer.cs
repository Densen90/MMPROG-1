namespace ShaderForm
{
    partial class FormMain
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			this.glControl = new OpenTK.GLControl();
			this.fileSystemWatcher = new System.IO.FileSystemWatcher();
			this.errorLog = new System.Windows.Forms.TextBox();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.reload = new System.Windows.Forms.ToolStripMenuItem();
			this.fps = new System.Windows.Forms.ToolStripMenuItem();
			this.granularity = new System.Windows.Forms.ToolStripComboBox();
			this.texture1 = new System.Windows.Forms.ToolStripMenuItem();
			this.soundPlayerBar1 = new ControlClassLibrary.SoundPlayerBar();
			this.texture2 = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// glControl
			// 
			this.glControl.AllowDrop = true;
			this.glControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.glControl.BackColor = System.Drawing.Color.Black;
			this.glControl.Location = new System.Drawing.Point(0, 27);
			this.glControl.Margin = new System.Windows.Forms.Padding(4);
			this.glControl.Name = "glControl";
			this.glControl.Size = new System.Drawing.Size(385, 286);
			this.glControl.TabIndex = 0;
			this.glControl.VSync = true;
			this.glControl.Load += new System.EventHandler(this.GlControl_Load);
			this.glControl.DragDrop += new System.Windows.Forms.DragEventHandler(this.GlControl_DragDrop);
			this.glControl.DragEnter += new System.Windows.Forms.DragEventHandler(this.GlControl_DragEnter);
			this.glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.GlControl_Paint);
			this.glControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GlControl_MouseDown);
			this.glControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GlControl_MouseMove);
			this.glControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GlControl_MouseUp);
			// 
			// fileSystemWatcher
			// 
			this.fileSystemWatcher.EnableRaisingEvents = true;
			this.fileSystemWatcher.SynchronizingObject = this;
			this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.FileSystemWatcher_Changed);
			// 
			// errorLog
			// 
			this.errorLog.AllowDrop = true;
			this.errorLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.errorLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorLog.Location = new System.Drawing.Point(0, 27);
			this.errorLog.Margin = new System.Windows.Forms.Padding(2);
			this.errorLog.Multiline = true;
			this.errorLog.Name = "errorLog";
			this.errorLog.ReadOnly = true;
			this.errorLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.errorLog.Size = new System.Drawing.Size(385, 286);
			this.errorLog.TabIndex = 1;
			this.errorLog.Visible = false;
			this.errorLog.DragDrop += new System.Windows.Forms.DragEventHandler(this.GlControl_DragDrop);
			this.errorLog.DragEnter += new System.Windows.Forms.DragEventHandler(this.GlControl_DragEnter);
			this.errorLog.Resize += new System.EventHandler(this.errorLog_Resize);
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reload,
            this.fps,
            this.granularity,
            this.texture1,
            this.texture2});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(385, 27);
			this.menuStrip.TabIndex = 2;
			this.menuStrip.Text = "menuStrip1";
			// 
			// reload
			// 
			this.reload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.reload.Image = global::ShaderForm.Properties.Resources.Edit_Redo;
			this.reload.ImageTransparentColor = System.Drawing.Color.Fuchsia;
			this.reload.Name = "reload";
			this.reload.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.reload.Size = new System.Drawing.Size(28, 23);
			this.reload.ToolTipText = "reload shader";
			this.reload.Click += new System.EventHandler(this.Reload_Click);
			// 
			// fps
			// 
			this.fps.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.fps.Name = "fps";
			this.fps.Size = new System.Drawing.Size(38, 23);
			this.fps.Text = "FPS";
			// 
			// granularity
			// 
			this.granularity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.granularity.Items.AddRange(new object[] {
            "0.5",
            "1",
            "2",
            "4"});
			this.granularity.Name = "granularity";
			this.granularity.Size = new System.Drawing.Size(75, 23);
			this.granularity.SelectedIndexChanged += new System.EventHandler(this.Granularity_SelectedIndexChanged);
			// 
			// texture1
			// 
			this.texture1.Name = "texture1";
			this.texture1.Size = new System.Drawing.Size(61, 23);
			this.texture1.Text = "texture1";
			// 
			// soundPlayerBar1
			// 
			this.soundPlayerBar1.AllowDrop = true;
			this.soundPlayerBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.soundPlayerBar1.Location = new System.Drawing.Point(0, 310);
			this.soundPlayerBar1.Name = "soundPlayerBar1";
			this.soundPlayerBar1.Playing = false;
			this.soundPlayerBar1.Position = 0F;
			this.soundPlayerBar1.Size = new System.Drawing.Size(385, 29);
			this.soundPlayerBar1.TabIndex = 3;
			this.soundPlayerBar1.OnPositionChanged += new ControlClassLibrary.SoundPlayerBar.PositionHandler(this.soundPlayerBar1_OnPositionChanged);
			// 
			// texture2
			// 
			this.texture2.Name = "texture2";
			this.texture2.Size = new System.Drawing.Size(61, 23);
			this.texture2.Text = "texture2";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(385, 339);
			this.Controls.Add(this.soundPlayerBar1);
			this.Controls.Add(this.errorLog);
			this.Controls.Add(this.glControl);
			this.Controls.Add(this.menuStrip);
			this.DoubleBuffered = true;
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormMain";
			this.Text = "ShaderForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl;
        private System.IO.FileSystemWatcher fileSystemWatcher;
		private System.Windows.Forms.TextBox errorLog;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem reload;
		private System.Windows.Forms.ToolStripMenuItem fps;
		private System.Windows.Forms.ToolStripComboBox granularity;
		private System.Windows.Forms.ToolStripMenuItem texture1;
		private ControlClassLibrary.SoundPlayerBar soundPlayerBar1;
		private System.Windows.Forms.ToolStripMenuItem texture2;
	}
}

