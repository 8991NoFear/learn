﻿using System;

namespace MyEvents
{
    class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Sending an email of video: {0}", args.Video.Title);
        }
    }
}
