using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    internal class NotificationManager
    {
        public NotificationManager() { }

        public bool SendNotification(Notification notificationInfo,NotificationChannel channel)
        {
            INotification notification = NotificationFactory.GetNotification(channel);
          return  notification.SendNotification(notificationInfo);
        }
    }
}
