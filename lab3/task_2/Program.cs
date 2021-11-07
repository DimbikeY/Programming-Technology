using System;

namespace task_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int k, m, i, s;
            s = 0;
            Console.WriteLine("Write the first number"); // Let it be 40
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the last number"); // Let it be 60
            m = int.Parse(Console.ReadLine());
            for (i = 1; i <= 100; i++)
            {
                if (i > k && i < m)  // например, 50. Меньше 60 + больше 40
                {
                    continue;
                }
                s += i;
            }
            Console.WriteLine("Sum from 1 to {0} and from {1} to 100 is equal {2}.", k, m, s);
        }
    }
}
