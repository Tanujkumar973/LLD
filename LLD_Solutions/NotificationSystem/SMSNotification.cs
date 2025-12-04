using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NotificationSystem
{
    internal class SMSNotification : INotification
    {
        public bool SendNotification(Notification notification)
        {
            Console.WriteLine($"notification sent through SMS Message body{notification.MessageBody} at {DateTime.Now.ToString()}");
            return true;
        }
    }
}
