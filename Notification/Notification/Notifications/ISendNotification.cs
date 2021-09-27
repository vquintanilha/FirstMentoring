using System;
using System.Collections.Generic;
using System.Text;

namespace Notification
{
    public interface ISendNotification
    {
        public bool Send(string Mensagem);
    }
}
