using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTask
{
    class CreateTask
    {
        public string TaskName { get; set; }
        public DateTime TaskDate { get; set; } = DateTime.Today.AddDays(1);
        public Priority TaskPriority { get; set; } = Priority.Low;

        public CreateTask(string name)
        {
            TaskName = name;
        }
        public CreateTask(string name, DateTime date)
        {
            TaskName = name;
            TaskDate = date;
        }
        public CreateTask(string name, DateTime date, Priority priority)
        {
            TaskName = name;
            TaskDate = date;
            TaskPriority = priority;
        }
    }
}