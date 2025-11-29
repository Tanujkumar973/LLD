using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class TaskUpdatedEventArgs : EventArgs
    {
        public int TaskId { get; }
        public string UpdatedBy { get; }

        public TaskUpdatedEventArgs(int taskId, string updatedBy)
        {
            TaskId = taskId;
            UpdatedBy = updatedBy;
        }
    }
}
