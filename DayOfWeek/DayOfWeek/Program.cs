using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter day __");
                String day = (Console.ReadLine());
                var myDay = GetDay(day.ToLower(), 0);
                day = myDay.Item1;
                int i = myDay.Item2;
                Console.ForegroundColor = (ConsoleColor)i;
                Console.Clear();
                Console.WriteLine($"Your enter {day}");

                if (day == "ERROR")
                {
                    Console.WriteLine($" ERROR - days to the weekend");
                }
                else if (i == 6 || i == 7)
                {
                    Console.WriteLine($"Today is weekend !!! ");
                    DayOF(day, i);
                }
                else
                {
                    Console.WriteLine($"{5 - i} - days to the weekend");
                    DayOF(day, i);
                }
            }
        }
        static System.Tuple<string, int> GetDay(string day, int i)
        {
            if (day == "monday" || day == "mon")
            { day = "monday"; i = 1; }

            else if (day == "tuesday" || day == "tue")
            { day = "tuesday"; i = 2; }

            else if (day == "wednesday" || day == "wed")
            { day = "wednesday"; i = 3; }

            else if (day == "thursday" || day == "thu")
            { day = "thursday"; i = 4; }

            else if (day == "friday" || day == "fri")
            { day = "friday"; i = 5; }

            else if (day == "saturday" || day == "satur")
            { day = "saturday"; i = 6; }

            else if (day == "sunday" || day == "sun")
            { day = "sunday"; i = 7; }

            else { day = "ERROR"; i = 12; }

            return Tuple.Create<string, int>(day, i);
        }
        static void DayOF(string day, int i)
        {
            var todayDay = (int)DateTime.Now.DayOfWeek;
            int daysTillNext = todayDay >= i ? i + 7 - todayDay : i - todayDay;

            Console.WriteLine($"The next {day} will be on ");
            Console.WriteLine(DateTime.Now.AddDays(daysTillNext).ToShortDateString());
            Console.ReadKey();
            Console.Clear();
        }
    }
}
