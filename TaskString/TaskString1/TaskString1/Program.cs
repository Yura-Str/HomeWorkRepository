using System;

namespace TaskString1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            for (int i=0; i<= a.Length-1; i++)
            {
                Console.WriteLine($"-{a[i]}-");
            }
            Console.ReadKey();

        }
    }
}
