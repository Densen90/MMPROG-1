using System;
using System.Diagnostics;
using System.Windows.Forms;
//using SoundPlayer;

namespace ControlClassLibrary
{
	public partial class SoundPlayerBar : UserControl
	{
		public delegate void PositionHandler(float position);
		public delegate void PlayingStateHandler(bool playing);
		public event MediaFacade.EndMediaHandler OnEndMedia;
		public event PlayingStateHandler OnPlayingStateChanged;
		public event PositionHandler OnPositionChanged;


		public SoundPlayerBar()
		{
			InitializeComponent();
		}

		public bool LoadSound(string file, bool loop = false)
		{
			if (null != sound) sound.Dispose();
			try
			{
				sound = new MediaFacade(file);
				sound.OnEndMedia += () => { if (null != OnEndMedia) OnEndMedia(); };
				markerBarPosition.Max = sound.Length;
				sound.Loop = loop;
				Playing = true;
				return true;
			}
			catch (Exception)
			{
				sound = null;
				time = 0.0f;
				return false;
			}
		}

		public bool Playing
		{
			get { return playing.Checked; }
			set
			{
				if(value != playing.Checked) playing.Checked = value;
				if (value)
				{
					playing.Image = global::ControlClassLibrary.Properties.Resources.PauseHS;
				}
				else
				{
					playing.Image = global::ControlClassLibrary.Properties.Resources.PlayHS;
				}
				if (null != sound) sound.Playing = value;
				timerUpdateMarkerBar.Enabled = value;
				if (null != OnPlayingStateChanged) OnPlayingStateChanged(value);
			}
		}

		public float Position
		{
			get { return markerBarPosition.Value; }
			set
			{
				markerBarPosition.Value = value;
			}
		}

		private MediaFacade sound;
		private float time = 0.0f;
		private bool timerChange = false;

		private void playing_CheckedChanged(object sender, EventArgs e)
		{
			Playing = playing.Checked;
		}

		private void timerUpdateMarkerBar_Tick(object sender, EventArgs e)
		{
			timerChange = true;
			if (null == sound)
			{
				if (Playing) time += timerUpdateMarkerBar.Interval * 0.001f;
				Position = time;
			}
			else
			{
				Position = sound.Position;
			}
			timerChange = false;
		}

		private void markerBar1_ValueChanged(object sender, EventArgs e)
		{
			if (null != OnPositionChanged) OnPositionChanged(Position);
			if (timerChange) return;
			if (null == sound)
			{
				time = Position;
			}
			else
			{
				sound.Position = Position;
			}
		}
	}
}
