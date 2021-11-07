using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int variant;
            string x;
            string y;
            float sum;
            sum = 0f;
            Console.WriteLine("Hi. Welcome to the shooting range. Write your number on the list.");
            variant = int.Parse(Console.ReadLine()) % 2;
            Console.WriteLine("Write your shot point x. If you have finished shooting, then enter \"I have done\"");
            x = Console.ReadLine();
            Console.WriteLine("Write your shot point y. If you have finished shooting, then enter \"I have done\"");
            y = Console.ReadLine();
            while (x != "I have done" || y != "I have done")
            {
                float[] history = new float[2];
                history[0] = float.Parse(x);
                history[1] = float.Parse(y);
                if ((history[0] <= 1.00f && history[0] >= -1.00f) && (history[1] >= -1.00f && history[1] <= 1.00f))
                {
                    sum += 10f;
                }  
                else if ((history[0] <= 2.00f && history[0] >= -2.00f) && (history[1] >= -2.00f && history[1] <= 2.00f))
                {
                    sum += 5f;
                }
                else
                {
                    if (variant == 0)
                    {
                        if ((history[0] <= 3.00f && history[0] >= -3.00f) && (history[1] >= -3.00f && history[1] <= 3.00f))
                        {
                            sum += 1f;
                        }
                    }
                }
                Console.WriteLine("******************************************");
                Console.WriteLine("Your actual point is " + sum);
                Console.WriteLine("******************************************");
                Console.WriteLine("Write your shot point x. If you have finished shooting, then enter \"I have done\"");
                x = Console.ReadLine();
                Console.WriteLine("Write your shot point y. If you have finished shooting, then repeat entering \"I have done\"");
                y = Console.ReadLine();
            }
            Console.WriteLine("Your points are {0}!", sum);
        }
    }
}
