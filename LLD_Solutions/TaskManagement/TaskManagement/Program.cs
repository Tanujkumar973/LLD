using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var notifier = new NotificationService();
            TaskManager manager = TaskManager.GetInstancce();

            manager.TaskUpdated += notifier.OnTaskUpdated;
            manager.CreateTask(new Task(1,"Complete Ofc work",TaskPriority.Medium,DateTime.Now.AddHours(5),new List<Task>()));
            manager.CreateSubTask(new Task(2, "Complete Ofc work", TaskPriority.Medium, DateTime.Now.AddHours(5), new List<Task>()), 1);
            manager.CreateTask(new Task(3, "Go to gym", TaskPriority.Medium, DateTime.Now.AddHours(8), new List<Task>()));
            manager.DsiplayTasks();
            manager.Update(new Task(1, "Complete Ofc work-updated", TaskPriority.Medium, DateTime.Now.AddHours(5), new List<Task>()),"suresh");
            manager.DsiplayTasks();
        }
    }
}
