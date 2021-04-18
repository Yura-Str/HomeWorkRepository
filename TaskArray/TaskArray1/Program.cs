using System;

namespace TaskArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter array size");
            var a = Convert.ToInt16(Console.ReadLine());
            int[] b = new int[a];

            for (int v = 0; v < a; v++)
            {
                Console.WriteLine($"input number array {v+1}");
                b[v] = Convert.ToInt32(Console.ReadLine());
            }
            for (int v = 0; v < a; v++)
            {
                Console.WriteLine($"to print {b[v]}");

            }
        }
    }
}
