namespace Interface
{
    internal interface INotificationChannel
    {
        bool Send(string message);
    }
}