﻿namespace SocketShot
{
	class StreamMeta
	{
		public string JsonB64Bitmap { get; set; }
		public string BitmapEncodeQuality { get; set; }
		public int CaptureHeight { get; set; }
		public int CaptureWidth { get; set; }
		public int StreamHeight { get; set; }
		public int StreamWidth { get; set; }
		public float CaptureTimeMilliseconds { get; set; }
		public int StreamSizeKB { get; set; }
		public int FramesPerSecond { get; set; }
		public bool PreviousFrameFailedToSend { get; set; }
	}
}
