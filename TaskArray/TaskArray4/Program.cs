using System;

namespace TaskArray4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inpud the elements first array ");
            var n = Convert.ToInt32(Console.ReadLine());
            int[] arrA = new int[n];
            int[] arrB = new int[n];
            string arrAtext = "";
            string arrBtext = "";
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.WriteLine($@"Inpud the elements array {"arrA"}");
                arrA[i] = Convert.ToInt32(Console.ReadLine());
                arrAtext = arrAtext + (Convert.ToString(arrA[i]));
            }
            Console.WriteLine($"\n --------\n arrA = {arrAtext}");
            for (int i = 0; i < arrB.Length; i++)
            {
                arrB[i] = arrA[i];
                arrBtext = arrBtext + (Convert.ToString(arrB[i]));
            }
            Console.WriteLine($"\n --------\n arrB = {arrBtext}");
        }
    }
}
