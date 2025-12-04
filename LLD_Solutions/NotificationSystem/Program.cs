using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            NotificationManager manager = new NotificationManager();

                Task task1 = Task.Run(() => { manager.SendNotification(new Notification("Order placed", "Your order placed successfully"), NotificationChannel.Push); });
                Task task2 = Task.Run(() => { manager.SendNotification(new Notification("Order shipped", "Your order shipped successfully"), NotificationChannel.SMS); });
                Task task3 = Task.Run(() => { manager.SendNotification(new Notification("Order cancelled", "Your order cancelled successfully"), NotificationChannel.Email); });
                await Task.WhenAll(task1, task2, task3);
        
        }
    }
}
