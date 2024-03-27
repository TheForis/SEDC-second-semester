using Services;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A1NotificationService a1Service = new A1NotificationService();*/
/*
            INotificationService notificationService = new A1NotificationService();
            INotificationService tMobileNotifService = new TmobileNotificationService();*/

            INotificationService notificationService;

            Console.WriteLine("Choose: \n1) A1\n2) T-Mobile");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1": notificationService = new A1NotificationService(); 
                    break;
                case "2": notificationService = new TmobileNotificationService(); 
                    break;
                default: notificationService = new A1NotificationService();
                    break;
            }
            string result = notificationService.SendSmsNotification("078-721-666", "You are late on your payments!");
            Console.WriteLine(result);


            NotificationService a1Notification = new A1NotificationService();
            NotificationService tMobNotification = new TmobileNotificationService();

            A1NotificationService a1NotificationReturned = (A1NotificationService)a1Notification;
            TmobileNotificationService tMobileNotificationReturned = (TmobileNotificationService)tMobNotification;
            string unboxedResult = tMobileNotificationReturned.SendSmsNotification("070-639-330", "UNBOXED MESSAGE");
            Console.WriteLine(unboxedResult);

            string boxedString = a1Notification.Name;
            Console.WriteLine(boxedString);


            /*A1NotificationService tMobileNotificationReturned = (A1NotificationService)tMobNotification;*/ // nemozhe da konvertira od eden vo drug. mora od istiot

            int t = 10;
            object o = t;
            object tMobile = tMobileNotificationReturned;
            int parsing = (int)o;
            TmobileNotificationService tMobileNew = (TmobileNotificationService)tMobile;
            string unboxingResult = tMobileNew.SendSmsNotification("070-223-305", "Te sakam draga javi se!");
            Console.WriteLine(unboxingResult);
            Console.WriteLine(parsing);

        }
    }
}