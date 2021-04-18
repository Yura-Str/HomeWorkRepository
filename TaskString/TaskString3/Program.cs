using System;

namespace TaskString3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:\n");
            string text = Console.ReadLine();
            Console.WriteLine("Revers text:");
            for (int i = (text.Length) - 1; i >= 0; i--)
            {
                Console.Write($"\t{text[i]}");
            }
        }
    }
}
