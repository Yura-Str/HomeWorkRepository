using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace WeeklyTask
{
    class Programm
    {
        public static void Main()
        {
            StartMenu();
        }
        public static void StartMenu()
        {
            var taskList = new List<CreateTask>();
            string inputConsole = default;
            while (inputConsole != "3")
            {
                Console.WriteLine("\tSelect an action \n " +
                    "\t1 - add new task\n" +
                    "\t2 - view all tasks\n" +
                    "\t3 - exit\n");
                inputConsole = Console.ReadLine();
                var input = int.TryParse(inputConsole, out var inputParse);

                if (input)
                {
                    switch (inputParse)
                    {
                        case 1:
                            taskList.Add(CreateTasker());
                            break;
                    }

                }

                else
                {
                    Console.WriteLine($"Invalid value  --  {inputParse}  -- ");
                }

            }
        }
        public static CreateTask CreateTasker()
        {
            Console.WriteLine(" please input in format (name task),(11.11.1111) (00:00:00),(priority Low or Medium or High)");
            string task = (Console.ReadLine()).Trim();

            var array = task.Split(',');
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = array[i].Trim();
            }

            return array.Length switch
            {
                1 => new CreateTask(array[0]),
                2 => new CreateTask(array[0], DateTime.Parse(array[1])),
                _ => new CreateTask(array[0], DateTime.Parse(array[1]), StringToPriority(array[2])),
            };
        }
        public static Priority StringToPriority(string priorityString)
        {
            while (true)
            {
                switch (priorityString.ToLower(System.Globalization.CultureInfo.CurrentCulture))
                {
                    case "low":
                        return Priority.Low;
                    case "medium":
                        return Priority.Medium;
                    case "high":
                        return Priority.High;

                }
            }
        }
    }
}
