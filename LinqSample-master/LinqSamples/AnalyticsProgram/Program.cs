using JobSchedulers;
using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;


namespace AnalyticsProgram
{
    public class Program
    {
        static JobScheduler job = new JobScheduler(5000);

        public static void Main(string[] args)
        {

              void ShowMenu()
            {
                bool alive = true;
                while (alive)
                {
                    Console.WriteLine();
                    Console.WriteLine("1. Add download website to file");
                   
                    try
                    {
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                 DownloadWebsite();
                                break;
                           
                            case 9:
                                alive = false;
                                continue;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                    }
                }
            }
        }
        private static void DownloadWebsite()
        {
            Console.WriteLine("Input address: ");
            var address = Console.ReadLine();
            job.AddHandler(new JoBDownloadWebsite(address));
        }
    }
}