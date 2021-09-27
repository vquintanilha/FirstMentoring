using System;
using System.Collections.Generic;
using System.Text;

namespace Notification.Notifications
{
    public class SendSlackNotification : ISendNotification
    {
        public bool Send(string Mensagem)
        {
            Console.WriteLine($"Enviando mensagem para o Slack: {Mensagem}");
            return true;
        }
    }
}
