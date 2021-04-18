using System;

namespace TaskString2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст : ");
            string word = Console.ReadLine();
            string[] arr;
            arr = word.Split(" ");
            Console.WriteLine(arr.Length);
        }
    }
}
