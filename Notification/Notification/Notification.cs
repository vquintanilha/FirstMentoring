using System;
using System.Collections.Generic;
using System.Text;

namespace Notification
{
    public class Notification
    {
        public Notification(string message, NotificationType type)
        {
            Message = message;
            Type = type;
        }

        public string Message { get; set; }

        public NotificationType Type { get; set; }

    }
}
