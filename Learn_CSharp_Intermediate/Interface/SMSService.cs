using System;

namespace Interface
{
    class SMSService : INotificationChannel
    {
        public SMSService()
        {

        }

        public bool Send(string message)
        {
            Console.WriteLine("Sending via SMS: {0}", message);
            return true;
        }
    }
}
