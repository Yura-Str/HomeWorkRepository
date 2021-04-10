using System;

namespace TaskArray5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of values in an array");
            var n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int a = 0; a < arr.Length; a++)
            {
                arr[a] = Convert.ToInt32(Console.ReadLine());
            }
            int consilience = 0;
            for (int a = 0; a < arr.Length; a++)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (a == i)
                    {

                    }
                    else if (arr[a] == arr[i])
                    {
                        consilience++;
                    }
                }
                Console.WriteLine($"{arr[a]}:{consilience}");
                consilience = 0;
            }
        }
    }
}
