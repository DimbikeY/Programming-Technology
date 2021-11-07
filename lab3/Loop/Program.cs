using System;

namespace Loop
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\nwhile: \t\t");
            int i = 1;
            while (i <= n)
            {
                Console.Write(" " + i);
                i += 2;
            }

            Console.Write("\ndo while: \t");
            i = 1;
            do
            {
                Console.Write(" " + i);
                i += 2;
            }
            while (i <= n);  // do выполняет хотя бы 1 раз даже при нарушении условия.

            Console.Write("\nFor: \t\t");
            for (i = 1; i <= n; i += 2)
            {
                Console.Write(" " + i);
            }

            // Используем цикл с постусловием.
            double x, x1, x2, y;  // Объявляем 4 переменных вещественного типа.
            Console.Write("\nWrite the left border of the interval = ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("Write the right border of the interval = ");
            x2 = double.Parse(Console.ReadLine());
            x = x1;
            do
            {
                y = Math.Sin(x);
                x += 0.01;
            }
            while (x <= x2);

            // Используем цикл с предусловием.
            int a, b, temp;
            Console.Write("\nWrite a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Write b = ");
            b = int.Parse(Console.ReadLine());
            temp = a; // Дальше будет алгоритм Евклида.
            while (temp != b) // Допустим, возьмем числа a = 3 b= 5; 3!=5
            {
                a = temp;  // temp = 3
                if (a < b)   // 3 < 5 -> true
                {
                    temp = a; // temp = 3
                    a = b;     // a = 5
                    b = temp;  // b = 3
                    temp = a - b; // 3 - 5 = -2
                    a = b;        // a = 3 как и b = 3. Условие выполнилось (нарушилось)
                }
            }
            // Реализуем задачу вывода значений функции с помощью цикла с предусловием
            // Задача наоборот то есть.
            double g, g1, g2, h;  // Объявляем 4 переменных вещественного типа.
            Console.Write("\nWrite the left border of the interval = ");
            g1 = double.Parse(Console.ReadLine());
            Console.Write("Write the right border of the interval = ");
            g2 = double.Parse(Console.ReadLine());
            g = g1;
            h = Math.Sin(g); // Так как судя по первому алгоритму один раз все равно должно выполниться
            while (g <= g2)
            {
                h = Math.Sin(g);
                g += 0.01;
            }
            // Второй алгоритм
            int m, j, temps;
            Console.Write("\nWrite a = ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Write b = ");
            j = int.Parse(Console.ReadLine());
            temps = m; // Дальше будет алгоритм Евклида.
                       // Допустим, возьмем числа a = 3 b= 5; 3!=5
            do
            {
                if (temps == j) // так как здесь не нужно выполнение даже одного случая в случае несоблюдения условия, то так
                {
                    break;
                }
                m = temps;  // temp = 3
                if (m < j)
                {
                    temps = m; // temp = 3
                    m = j;     // a = 5
                    j = temps;  // b = 3
                    temps = m - j; // 3 - 5 = -2
                    m = j;        // a = 3 как и b = 3. Условие выполнилось (нарушилось)
                }
            }
            while (temps != j);
        }
    }
}


