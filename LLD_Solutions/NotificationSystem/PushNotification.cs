using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    internal class PushNotification : INotification
    {
        public bool SendNotification(Notification notification)
        {
            Console.WriteLine($"notification sent through push not Message body{notification.MessageBody}");
            return true;
        }
    }
}
