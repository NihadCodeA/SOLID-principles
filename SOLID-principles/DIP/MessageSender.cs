﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class MessageSender
    {
        List<INotification> _notifications = new List<INotification>();

        public MessageSender(List<INotification> notifications)
        {
            _notifications=notifications;
        }
        public void Send()
        {
            foreach(var item in _notifications)
            {
                item.Send();
            }
        }
    }
}
