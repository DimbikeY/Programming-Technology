using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils // Общая банка памяти методов и классов и переменныъ
{
    class Utils // чтобы потом сослаться
    {
        public static int Greater(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static void Swap(ref int a, ref int b) // модификатор ref вместо 
            // невозможного множественного return, сохраняем переменные в namespace
        {
            int temp = a; // временная переменная для хранения значения переменной.
            a = b;
            b = temp;
        }
        public static bool Factorial(int n, out int answer) // out - для возвращения результаты в namespace
        {
            int k; // loop counter
            int f = 1; // Working value
            bool ok = true; // True if okay, false if not
            try
            {
                checked // ключевое слово для явной проверки перевыполнения
                {
                    for (k = 2; k <= n; ++k) // префиксный оператор ++k
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception) // Any exception (выход за пределы диапозона)
            {
                f = 0;
                ok = false;
            }
            answer = f;
            return ok;
        }
    }
}
