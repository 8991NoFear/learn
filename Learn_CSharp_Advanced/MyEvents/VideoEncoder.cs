using System;
using System.Threading;

namespace MyEvents
{
    class VideoEncoder
    {
        // 1) Create a contract between publisher and subscriber => delegate
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // 2) Create an event based on that delegate
        public event VideoEncodedEventHandler VideoEncoded;
        // GENERICS EQUIVALENT
        //public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video: {0} ...", video.Title);
            Thread.Sleep(3000);
            OnVideoEncoded(video); // 3) Raise that event
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs { Video = video });
            }
        }
    }
}
