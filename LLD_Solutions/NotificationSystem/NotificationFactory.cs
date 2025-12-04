using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    internal class NotificationFactory
    {

        public static  INotification GetNotification(NotificationChannel channel)
        {
            switch (channel)
            {
                case NotificationChannel.SMS: return new SMSNotification();
                case NotificationChannel.Email: return new EMailNotification();
                case NotificationChannel.Push: return new PushNotification();
                default:
                    throw new ArgumentException($"Unsupported channel - {channel}");
            }
           
        }
    }
}
