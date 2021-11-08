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
            Random rnd = new Random(); // Создание объекта для генерации чисел
            float x_value_center = rnd.Next(-10, 10) * 0.1f; // Получаем очередное (первое) случайное число в заданном диапазоне
            // которое будет показывать случайное отклонение (в пределах нормального) центра мишени.
            float y_value_center = rnd.Next(-10, 10) * 0.1f;
            // Теперь введем попутный ветер :)
            float wind_x_value = rnd.Next(-5, 5) * 0.2f;
            float wind_y_value = rnd.Next(-5, 5) * 0.2f;

            Console.WriteLine("Hi. Welcome to the shooting range. Write your number on the list.");
            variant = int.Parse(Console.ReadLine()) % 2;
            Console.WriteLine("Write your shot point x. If you have finished shooting, then enter \"I have done\"");
            x = Console.ReadLine();
            Console.WriteLine("Write your shot point y. If you have finished shooting, then enter \"I have done\"");
            y = Console.ReadLine();
            while (x != "I have done" || y != "I have done")
            {
                float[] history = new float[2]; // Сохранение в массив
                history[0] = float.Parse(x);
                history[1] = float.Parse(y);
                if ((history[0] + wind_x_value <= 1.00f + x_value_center && history[0] + wind_x_value >= -1.00f + x_value_center) && (history[1] + wind_y_value >= -1.00f + y_value_center && history[1] + wind_y_value <= 1.00f + y_value_center))
                {
                    sum += 10f;
                }  
                else if ((history[0] + wind_x_value <= 2.00f + x_value_center && history[0] + wind_x_value >= -2.00f + x_value_center) && (history[1] + wind_y_value >= -2.00f + y_value_center && history[1] + wind_y_value <= 2.00f + y_value_center))
                {
                    sum += 5f;
                }
                else
                {
                    if (variant == 0)
                    {
                        if ((history[0] + wind_x_value <= 3.00f + x_value_center && history[0] + wind_x_value >= -3.00f + x_value_center) && (history[1] + wind_y_value >= -3.00f + y_value_center && history[1] + wind_y_value <= 3.00f + y_value_center))
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
            Console.WriteLine("The center is locating x = {0} and y = {1}", x_value_center, y_value_center);
            Console.WriteLine("Your points are {0}!", sum);
            Console.WriteLine("Speed of wind is x = {0} and y = {1}", wind_x_value, wind_y_value);
        }
    }
}
