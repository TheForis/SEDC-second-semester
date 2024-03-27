namespace Services
{
    public interface INotificationService
    {
        /*string Name { get; set; }*/ // kje napravi da mora klasata da ima property Name
        string SendSmsNotification(string phoneNumber, string message);
    }
}
