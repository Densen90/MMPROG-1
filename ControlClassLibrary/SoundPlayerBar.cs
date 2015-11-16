using System;
using System.Windows.Forms;
//using SoundPlayer;

namespace ControlClassLibrary
{
	public partial class SoundPlayerBar : UserControl
	{
		public SoundPlayerBar()
		{
			InitializeComponent();
		}

		//private Sound sound;

		private void playing_CheckedChanged(object sender, EventArgs e)
		{
			if (playing.Checked)
			{
				//if(null != sound) sound.Playing = true;
				playing.Image = global::ControlClassLibrary.Properties.Resources.PauseHS;
			}
			else
			{
				//if (null != sound) sound.Playing = false;
				playing.Image = global::ControlClassLibrary.Properties.Resources.PlayHS;
			}
		}
	}
}
