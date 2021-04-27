using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTaskk
{
    internal class PriorityTask : RegularTask
    {
        private readonly Priority priority;

        public Priority GetPriority()
        {
            return priority;
        }

        public PriorityTask(string name, DateTime date, TimeSpan time, Priority priority) : base(name, date, time)
        {
            this.priority = priority;
        }

        public PriorityTask(string name, DateTime date, DateTime time, Priority priority) : base(name, date, time)
        {

        }

    }
}
