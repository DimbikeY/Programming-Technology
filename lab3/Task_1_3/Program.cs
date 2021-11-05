using System;

namespace Task_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your favourite year = ");
            int year = Int32.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 && year % 400 == 0) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
