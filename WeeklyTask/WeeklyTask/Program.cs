using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace WeeklyTaskk
{
    class Programm
    {
        private static WeeklyTaskService servis = new WeeklyTaskService();

        public static void Main()
        {
            RunInLoop();

        }

        private static void RunInLoop()
        {
            string input = null;
            while (input != "exit")
            {
                PrintMenu();
                input = Console.ReadLine();
                if (int.TryParse(input, out var parsedInput))
                {
                    HandelComand(parsedInput);
                }
                else
                {
                    Console.WriteLine("Invalid comand, tru again");
                }
            }
        }

        static void HandelComand(int parsedInput)
        {
            switch (parsedInput)
            {
                case 1:
                    WeeklyTaskService.HandleAddNewTask();
                    break;
                case 2:
                    WeeklyTaskService.HandleList();
                    break;
                case 3:
                    WeeklyTaskService.HandleEdit();
                    break;
                case 4:
                    WeeklyTaskService.FilterTaskByPriority();
                    break;
                case 5:
                    WeeklyTaskService.FilterTaskByDate();
                    break;
            }
        }

        public static void PrintMenu()
        {
            Console.WriteLine(
            @"Choose a command:
1. Add new task
2. Print all tasks
3. Update task
4. Filter task by date
5. Filter task by priority");
        }
    }
}

