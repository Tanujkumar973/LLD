using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class NotificationService
    {
        public void OnTaskUpdated(object sender, TaskUpdatedEventArgs e)
        {
            Console.WriteLine($"Task {e.TaskId} updated by {e.UpdatedBy}. Notifying users...");
        }
    }
}
