using System;

namespace Notification
{
    class Program
    {
        static void Main(string[] args)
        {
            var errorMessage = new Notification("error!", NotificationType.Error);
            var criticalMessage = new Notification("critical!", NotificationType.Critical);
            var informationMessage = new Notification("information!", NotificationType.Information);
            HandleNotification sendNotifications = new HandleNotification();
            sendNotifications.SendMessage(errorMessage);
            sendNotifications.SendMessage(criticalMessage);
            sendNotifications.SendMessage(informationMessage);
        }
    }
}
