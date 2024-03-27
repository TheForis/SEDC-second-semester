namespace Services
{
    public class A1NotificationService : NotificationService, INotificationService
    {
        public A1NotificationService()
        {
            Name = "A1";
        }
        public string SendSmsNotification(string phoneNumber, string message)
        {
            return $"Thank you for using our service, the message \"{message}\" is sent to {phoneNumber}. Yours A1!";
        }
    }
}
