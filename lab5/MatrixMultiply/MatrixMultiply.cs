using System;

namespace MatrixMultiply
{
    class MatrixMultiply
    {
        static void Main(string[] args) // Используем рефакторинг с извлечением метода
        {
            int min_index = 1;
            int max_index = 1;
            int[,] a = Input_a();
            int[,] b = Input_b();
            int[,] result = Multiply(a, b); // инициализация массива
            Output(result); // вызов метода
            Console.WriteLine("*************************************************"); // Следующее упражнение 
            Console.WriteLine("******************THE NEXT TASK******************"); // в виде класса
            Console.WriteLine("Are you ready to continue? (Yes or No)");
            string answer = Console.ReadLine();
            if (answer == "Yes" | answer == "YES")
            {
                int[] new_array = DataHandling.Enter();
                int summa = DataHandling.Summa(new_array);
                DataHandling.Average(new_array, summa);
                DataHandling.side_summa_difference(new_array);
                DataHandling.OddEven(new_array);                              // Не используя объекты класса, поскольку методы static.
                DataHandling.MaxMin(new_array, ref min_index, ref max_index); // Можно было и со связкой return - out, запихнув два индекса в массив, но скучно!
                DataHandling.Multipulti(new_array, max_index, min_index);
            }
            Console.WriteLine("That's all!");
        }

        private static int[,] Input_b()
        {
            int[,] b = new int[2, 2];
            for (int r = 0; r < b.GetLength(0); r++)
            {
                for (int c = 0; c < b.GetLength(1); c++)
                {
                    Console.Write("Enter value for [{0}, {1}] : ", r, c);
                    string s = System.Console.ReadLine(); // так как внутри другого метода
                    b[r, c] = int.Parse(s);
                }
            }
            Console.WriteLine();
            return b;
        }

        private static int[,] Input_a() 
        {
            int[,] a = new int[2, 2];
            for (int r = 0; r < a.GetLength(0); r++) 
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    Console.Write("Enter value for [{0}, {1}] : ", r, c);
                    string s = System.Console.ReadLine(); // так как внутри другого метода
                    a[r, c] = int.Parse(s);
                }
            }
            Console.WriteLine();
            return a;
        }

        private static int[,] Multiply(int[,] a, int[,] b)
        {
            int[,] result = new int[2, 2];
            for (int r = 0; r < result.GetLength(0); r++)
            {
                for (int c = 0; c < result.GetLength(1); c++)
                {
                    result[r, c] = a[r, 0] * b[0, c] + a[r, 1] * b[1, c];
                }
            }
            return result; // поиск переменной по правилу LEGB (сначала result от локала, потом перезапись на глобал)
        }
        private static void Output(int[,] result) // не выводит ничего, т.к. void
        {
            for (int r = 0; r < result.GetLength(0); r++) // для проверки верхней границы обоих массивов используем вызов метода GetLength
            {
                for (int c = 0; c < result.GetLength(1); c++)
                {
                    Console.Write("{0} ", result[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
