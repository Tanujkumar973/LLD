using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    internal class Task
    {
        public Task(int Id, string description,TaskPriority priority,DateTime duedate,List<Task> subtasks)
        {
            this.Id = Id;
            Description = description;
            Priority = priority;    
            DueDate = duedate;
            SubTasks = subtasks;
        }
        public int Id { get; }
        public string Description { get;  }
        public TaskPriority Priority { get; }
        public DateTime DueDate { get; }
        public List<Task> SubTasks { get; }

    }
}
