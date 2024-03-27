namespace Services
{
    public class TmobileNotificationService : NotificationService, INotificationService
    {
        public TmobileNotificationService() {
            Name = "T-Mobile";
        }
        public string SendSmsNotification(string phoneNumber, string message)
        {
            return $"The message \"{message}\" is sent to {phoneNumber}. Yours {Name}!";
        }
    }
}
