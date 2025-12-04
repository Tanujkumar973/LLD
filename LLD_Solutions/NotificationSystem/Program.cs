using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationManager manager = new NotificationManager();
            manager.SendNotification(new Notification("Order placed", "Your order placed successfully"), NotificationChannel.Push);
            manager.SendNotification(new Notification("Order shipped", "Your order shipped successfully"), NotificationChannel.SMS);
            manager.SendNotification(new Notification("Order cancelled", "Your order cancelled successfully"), NotificationChannel.Email);
        }
    }
}
