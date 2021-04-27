using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTaskk
{
    
    internal class RegularTask : WeekleTask
    {
        private readonly DateTime data;
        private readonly TimeSpan time;

        public RegularTask(string name, DateTime dateTime) : base(name)
        {
        }

        public RegularTask(string name, DateTime date, DateTime time) : base(name)
        {
            this.data = date;
        }

        public RegularTask(string name, DateTime date, TimeSpan time) : base(name)
        {
            this.data = date;
            this.time = time;
        }

        public DateTime GetDate()
        {
            return data;
        }
        public  string ConvertToString(int index)
        {
            var output = base.ConvertToString(index);

            if (data != default)
            {
                output += $"{data.ToShortDateString()} ";
            }

            if (time != default)
            {
                output += $"{time} ";
            }

            return output;
        }
    }
}


