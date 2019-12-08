using System;
using System.Threading;

namespace Events
{
    // 1 Define a delegate
    // 2 Define an event based on that delegate
    // 3 https://youtu.be/DjffIi2Pl7M?t=136 the event
    public class VideoEncoder
    {
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // EventHandler 
        // EventHandler<TEventArgs>

        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding..");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded!=null)
                VideoEncoded(this,new VideoEventArgs(){Video = video});
        }
    }
}