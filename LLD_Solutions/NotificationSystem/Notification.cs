using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    internal class Notification
    {
        public Notification(string subject,string messageBody) {
            Subject = subject;
            MessageBody = messageBody;
        }
        public string Subject { get; set; }
        public string MessageBody { get; set; }
    }
}
