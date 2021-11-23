using System;

namespace The_7th_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напиши первый элемент последовательности.");
            int input_b = int.Parse(Console.ReadLine());
            Console.WriteLine("Напиши шаг прогрессии.");
            int input_s = int.Parse(Console.ReadLine());
            Console.WriteLine("Напиши, какой элемент хочешь вывести.");
            int input_e = int.Parse(Console.ReadLine());
            Progression solution = new Progression(input_b, input_s, input_e);
            int answer_g = solution.Geometric();
            Console.WriteLine("The result of Geometric Progression is {0}.", answer_g);
            int answer_a = solution.Algebraic();
            Console.WriteLine("The result of Algebraic Progression is {0}.", answer_a);
        }
    }
}
