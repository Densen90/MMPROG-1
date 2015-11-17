using System;
using WMPLib;

namespace ControlClassLibrary
{
	public class MediaFacade : IDisposable
	{
		public delegate void EndMediaHandler();
		public event EndMediaHandler OnEndMedia;

		public MediaFacade(string fileName)
		{
			wmp = new WindowsMediaPlayer();
			wmp.settings.autoStart = true;
			wmp.settings.setMode("autoRewind", true);
			wmp.PlayStateChange += Wmp_PlayStateChange;
			var media = wmp.newMedia(fileName);
			if (0.0 == media.duration) throw new Exception("Could not load file '" + fileName + "'");
			Length = (float)media.duration;
			wmp.URL = fileName;
		}

		private void Wmp_PlayStateChange(int NewState)
		{
			if(8 == NewState && null != OnEndMedia) OnEndMedia();
		}

		public void Dispose()
		{
			wmp.close();
		}

		public float Length { get; private set; }
		public bool Loop
		{
			get { return wmp.settings.getMode("loop"); }
			set { wmp.settings.setMode("loop", value); }
		}

		public bool Playing
		{
			get { return playing; }
			set { playing = value; if (playing) wmp.controls.play(); else wmp.controls.pause(); }
		}

		public float Position
		{
			get { return (float)wmp.controls.currentPosition; }
			set { wmp.controls.currentPosition = value; }
		}

		private bool playing = true;
		private WindowsMediaPlayer wmp;
	}
}
