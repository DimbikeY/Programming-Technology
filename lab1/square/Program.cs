using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace square
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Write the perimeter of the triangle.");
                string info = Console.ReadLine();
                double perimeter = double.Parse(info);
                if (perimeter < 0 || info[0] == '-') {
                    Console.WriteLine("Use only positive numbers!");
                }
                else if (info.Length != 1 && info[0] == '0' && info[1] != ',')
                /// Проверяем. Потому что 0006 воспринимает как 6. Плюс info[1] в случае 0 выдаст ошибку доступа. Учитываем это. 
                {
                    Console.WriteLine("Man, the first char can't be 0. Cut off this.");
                }
                else
                {
                    double p = perimeter / 2;
                    double a = perimeter / 3;
                    double square = Math.Sqrt(p * (p - a) * (p - a) * (p - a));
                    string right_a = String.Format("{0:0.00}", a); // Формат числа
                    string right_square = String.Format("{0:0.00}", square); // Формат числа
                    List<string> names = new List<string>() { "Сторона", "Площадь", right_a, right_square };
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (i % 2 == 0 && i > 0) // 2 элемента в строчке
                            Console.WriteLine();  // после каждой пары элементов строчка меняется

                        Console.Write(names[i] + "\t"); // перемещение позиции печати к следующей позиции горизонтальной табуляции
                    }
                }
            }
            catch(FormatException e) // Когда используем буквы вместо чисел 
            {
                Console.WriteLine("You have error with format {0}. Use numbers only!", e.Message);
            }
        }   
    }
}
