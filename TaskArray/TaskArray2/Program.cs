using System;

namespace TaskArray2
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
            int temp;
            for (int a = 0; a < arr.Length - 1; a++)
            {
                for (int j = a + 1; j < arr.Length; j++)

                    if (arr[a] > arr[j])
                    {
                       temp = arr[a];
                        arr[a] = arr[j];
                        arr[j] = arr[a];
                        arr[j] = temp;
                    }
            }
            Console.WriteLine("--------------");
            for (int a = 0; a < arr.Length ; a++)
            {
                Console.WriteLine(arr[a]);
            }
        }
    }
}
