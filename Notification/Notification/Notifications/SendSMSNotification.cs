using System;
using System.Collections.Generic;
using System.Text;

namespace Notification.Notifications
{
    public class SendSMSNotification : ISendNotification
    {
        public bool Send(string Mensagem)
        {
            Console.WriteLine($"Enviando SMS com a mensagem: {Mensagem}");
            return true;
        }
    }
}
