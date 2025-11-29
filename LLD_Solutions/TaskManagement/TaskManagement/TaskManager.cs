using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    internal class TaskManager
    {
        private List<Task> tasks;
        private static TaskManager _Instance;

        public event EventHandler<TaskUpdatedEventArgs> TaskUpdated;
        private TaskManager()
        {
            tasks = new List<Task>();
        }

        public static TaskManager GetInstancce()
        {
            if (_Instance == null)
            {
                return new TaskManager();
            }
            return _Instance;
        }

        public List<Task> GetTasks()
        {
            return tasks.OrderByDescending(s => s.DueDate).ToList();
        }

        public void Update(Task task,string updatedBy)
        {
            int index = tasks.FindIndex(x => x.Id == task.Id);
            if (index >= 0)
            {
                tasks[index] = task;
            }
            UpdateTask(task.Id,updatedBy );
            Console.WriteLine($"Task Updated TaskDesc - {task.Description} Priority - {task.Priority}");
        }

        public List<Task> GetTasks(string searchText)
        {
            return tasks.Where(x => x.Description.Contains(searchText)).OrderByDescending(s => s.DueDate).ToList();
        }

        public bool CreateTask(Task task)
        {
            tasks.Add(task);
            Console.WriteLine($"Task Created TaskDesc - {task.Description} Priority - {task.Priority}");
            return true;
        }
        public bool CreateSubTask(Task task, int taskId)
        { 

           var parentTask = tasks.First(x => x.Id == taskId);
            parentTask.SubTasks.Add(task);
            Console.WriteLine($"Sub Task Created TaskDesc - {task.Description} Priority - {task.Priority}");
            return true;
        }

        public void DsiplayTasks()
        {
           foreach (Task task in tasks)
            {
                DisplayTask(task);
                foreach(var item in task.SubTasks)
                {
                    DisplayTask(item);
                }
            }

        }

        public void DisplayTask(Task task)
        {
            Console.WriteLine($"TaskId {task.Id} Desciption {task.Description} priority {task.Priority} duedate {task.DueDate}");
        }

        public void UpdateTask(int taskId, string updatedBy)
        {
            TaskUpdated?.Invoke(this, new TaskUpdatedEventArgs(taskId, updatedBy));
        }

    }
}
