using System;

namespace Interface
{
    class MailService : INotificationChannel
    {
        public MailService()
        {

        }

        public bool Send(string message)
        {
            Console.WriteLine("Sending via mail: {0}", message);
            return true;
        }
    }
}
