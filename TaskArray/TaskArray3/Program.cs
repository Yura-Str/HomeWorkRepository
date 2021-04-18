using System;

namespace TaskArray3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inpud the three numbers in the array :");
            // var a = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[3];
            int summ = 0;
            for (int b = 0; b < arr.Length; b++)
            {
                Console.WriteLine($"Inpud the number {b + 1}:");
                arr[b] = Convert.ToInt32(Console.ReadLine());
                summ = summ + arr[b];
            }
            Console.WriteLine($"Sum = {summ}");
        }
    }
}
