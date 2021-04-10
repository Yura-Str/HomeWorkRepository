using System;

namespace TaskString4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text№1:\n");
            string text1 = Console.ReadLine();
            Console.WriteLine("Enter text№2:\n");
            string text2 = Console.ReadLine();
            Console.WriteLine("search for replays:");
            if (text1.Length == text2.Length)
            {
                for (int i = (text1.Length) - 1; i >= 0; i--)
                {
                    if (text1[i] == text2[i])
                    {

                    }

                    else
                    {
                        Console.WriteLine("no compare:");
                        break;
                    }
                }
                Console.WriteLine("success:");
            }
            else
            {
                Console.WriteLine("no compare:");

            }
        }
    }
}
