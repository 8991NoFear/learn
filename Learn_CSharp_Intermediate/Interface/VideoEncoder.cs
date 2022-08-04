using System.Collections.Generic;

namespace Interface
{
    class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            // Logic for encode video

            foreach (var channel in _notificationChannels)
            {
                channel.Send(video.VideoName);
            }
        }

        public void RegistrationNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}
