using System;

namespace MyEvents
{
    class SMSService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Sending a sms of video: {0}", args.Video.Title);
        }
    }
}
