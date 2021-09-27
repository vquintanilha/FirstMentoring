using System;
using System.Collections.Generic;
using System.Text;

namespace Notification.Notifications
{
    public class SendDatabaseNotification : ISendNotification
    {
        public bool Send(string Mensagem)
        {
            Console.WriteLine($"Enviando a mensagem para o banco de dados: {Mensagem}");
            return true;
        }
    }
}
