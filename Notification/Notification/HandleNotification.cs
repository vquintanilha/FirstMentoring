using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Notification.Notifications;

namespace Notification
{
    public class HandleNotification
    {
        public readonly IDictionary<NotificationType, Func<IList<ISendNotification>>> notificationDictionary
            = new Dictionary<NotificationType, Func<IList<ISendNotification>>>()
            {
                {NotificationType.Error, () => GetErrorNotification()},
                {NotificationType.Critical, () => GetCriticalNotification()},
                {NotificationType.Information, () => GetInformationNotification()}
            };

        private static IList<ISendNotification> GetErrorNotification()
        {
            return new List<ISendNotification>()
            {
                new SendDatabaseNotification(),
                new SendSMSNotification()
            };
        }

        private static IList<ISendNotification> GetCriticalNotification()
        {
            return new List<ISendNotification>()
            {
                new SendDatabaseNotification(),
                new SendSMSNotification(),
                new SendSlackNotification()
            };
        }

        private static IList<ISendNotification> GetInformationNotification()
        {
            return new List<ISendNotification>()
            {
                new SendSMSNotification()
            };
        }

        public void SendMessage(Notification notification)
        {
            //List<ISendNotification> sendNotifications = new List<ISendNotification>();
            //ISendNotification sms = new SendSMSNotification();
            //ISendNotification database = new SendDatabaseNotification();
            //ISendNotification slack = new SendSlackNotification();
            //switch (notification.Type)
            //{
            //    case NotificationType.Error:
            //        sendNotifications.Add(sms);
            //        sendNotifications.Add(database);
            //        break;
            //    case NotificationType.Critical:
            //        sendNotifications.Add(sms);
            //        sendNotifications.Add(database);
            //        sendNotifications.Add(slack);
            //        break;
            //    case NotificationType.Information:
            //        sendNotifications.Add(sms);
            //        break;
            //    default:
            //        break;
            //}
            var notifications = notificationDictionary[notification.Type]().ToList();
            notifications.ForEach(sender => sender.Send(notification.Message));
        }
    }
}
