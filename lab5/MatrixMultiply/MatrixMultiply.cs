using System;

namespace MatrixMultiply
{
    class MatrixMultiply
    {
        static void Main(string[] args) // Используем рефакторинг с извлечением метода
        {
            int[,] a = new int[2, 2];
            NewMethod(a);
            int[,] b = new int[2, 2];
            b[0, 0] = 5; b[0, 1] = 6;
            b[1, 0] = 7; b[1, 1] = 8;
            int[,] result = new int[2, 2];
            result[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0]; result[0, 1] = a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1];
            result[1, 0] = a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0]; result[1, 1] = a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1];
            Output(result); // вызов метода

        }

        private static void NewMethod(int[,] a)
        {
            a[0, 0] = 1; a[0, 1] = 2;
            a[1, 0] = 3; a[1, 1] = 4;
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
