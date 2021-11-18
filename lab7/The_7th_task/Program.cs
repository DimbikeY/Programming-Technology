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
            Solution solution = new Solution();
            ArithmeticProgression a_prog = new ArithmeticProgression(input_b, input_s, input_e);
            int answer_a = solution.GetElement(a_prog);
            Console.WriteLine("The result of Arithmetic Progression is {0}.", answer_a);
            GeometricProgression g_prog = new GeometricProgression(input_b, input_s, input_e);
            int answer_g = solution.GetElement(g_prog);
            Console.WriteLine("The result of Geometric Progression is {0}.", answer_g);
        }
    }
}
