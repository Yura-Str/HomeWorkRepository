using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTaskk
{
    public class WeekleTask
    {
        private readonly string _name;

        public WeekleTask(string name)
        {
            _name = name;
        }
        public virtual string ConvertToString(int index)
        {
            return $"Task #{index + 1}: {_name} ";
        }
    }
}
