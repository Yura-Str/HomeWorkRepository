using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTaskk
{
    public class WeeklyTaskService
    {

        public static WeekleTask[] tasks = new WeekleTask[10];
        public static int s_counter = 0;
        internal static readonly int parsedInput;

        public static void HandleAddNewTask()
        {
            if (s_counter > 9)
            {
                Console.WriteLine("out of memory");
            }
            Console.WriteLine("Add task in format : {},{},{},{}");
            var inputData = Console.ReadLine();
            AddTask(ParseNewTask(inputData));
        }

        public static WeekleTask ParseNewTask(string inputData)
        {
            var part = inputData?.Split(",");
            if (part == null || part.Length < 1 || part.Length > 4)
            {
                Console.WriteLine("Invalid format");
                return null;
            }
          return CreateNewTask (part);
         
        }

        private static WeekleTask CreateNewTask (string[] part)
        {
            switch (part.Length)
            {
                case 1:
                    return AddTaskWithName(part);
                case 2:
                    return AddTaskWithNameDate(part);
                case 3:
                    return AddTaskWithNameDateTime(part);
                case 4:
                    return AddTaskWithNameDateTimeandPriority(part);
                default:
                    return null;
            }

        }

        public static WeekleTask AddTaskWithName(string[] part)
        {
            return new WeekleTask(part[0]);
            //AddTask(task);
        }

        public static WeekleTask AddTaskWithNameDate(string[] part) => new RegularTask (part[0], DateTime.Parse(part[1]));

        public static WeekleTask AddTaskWithNameDateTime(string[] part)
        {
            var (data, time) = ParseDataTime(part);
            return new RegularTask(part[0], data, time);
            //AddTask(task);
        }

        public static WeekleTask AddTaskWithNameDateTimeandPriority(string[] part)
        {
            var (date, time) = ParseDataTime(part);
            var priority = Enum.Parse<Priority>(part[3]);
            if (Enum.TryParse<Priority>(part[3], out var Priority))
            {
                Console.WriteLine("Invalid Proirity");
            }
            return new PriorityTask (part[0], DateTime.Parse(part[1]), DateTime.Parse(part[2]), Priority);
            // AddTask(task);
        }

        public  static (DateTime date, DateTime time) ParseDataTime(string[] part)
        {
            var date = DateTime.Parse(part[1]);
            var time = DateTime.Parse(part[2]);
            return (date, time);
        }

        public static void AddTask(WeekleTask task)
        {
            tasks[s_counter] = task;
            s_counter++;
        }

        public static void HandleList()
        {
            for (int i = 0; 1 < s_counter; i++)
            {
                var task = tasks[i];

                if (task == null)
                {
                    return;
                }
                Console.WriteLine(task.ConvertToString(i));
            }
        }

        public static void HandleEdit()
        {
            Console.WriteLine("input number to Edit");
            var inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("input input CorrectTask  ");
            string CorrectTask =(Console.ReadLine());
            WeekleTask task = ParseNewTask(CorrectTask);
            tasks[inputNumber] = task;
        }

        public static void FilterTaskByPriority()
        {
            Console.WriteLine("Input priority:");
            var priority = Console.ReadLine();

            for (int i = 0; i < s_counter; i++)
            {
                if (tasks[i] is PriorityTask priorityTask && priorityTask.GetPriority().ToString() == priority)
                {
                    PrintTaskText (i);
                }
            }
        }

        public static void FilterTaskByDate()
        {
            Console.WriteLine("Input data:");
            var inputDate = Console.ReadLine();
            var date = DateTime.Parse(inputDate);

            for (int i = 0; i < s_counter; i++)
            {
                if (tasks[i] is RegularTask regularTask && regularTask.GetDate() >= date)
                {
                    PrintTaskText(i);
                }
            }
        }

        private static void PrintTaskText(int i)
        {
            Console.WriteLine(tasks[i].ConvertToString(i));
        }
    }
}
