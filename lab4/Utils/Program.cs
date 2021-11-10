using System;

namespace Utils
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int f;
            bool ok;
            Console.WriteLine("Write out the first number:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Write out the second number:");
            y = int.Parse(Console.ReadLine());

            // Так как метод статический, вызовем его на исполнение от имени класса
            int greater = Utils.Greater(x, y); // Присвоили выводу переменную
            Console.WriteLine("The highest of these numbers ({0} and {1}) is {2}.", x, y, greater);
            Console.WriteLine("Until swap: \t" + x + " " + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("After swap: \t" + x + " " + y);
            Console.WriteLine("**********************************");

            Console.WriteLine("Number for factorial:");
            x = int.Parse(Console.ReadLine());
            // Test the factorial function
            ok = Utils.Factorial(x, out f); // ожидаем возвращения результата f в namespace.
            if (ok) // = true 
            {
                Console.WriteLine("Factorial(" + x + ") = " + f);
            }
            else
            {
                Console.WriteLine("Cannot compute this factorial");
            }
            Console.WriteLine("******************************");

            Console.WriteLine("The 4th task");
            int a_side;
            int b_side;
            int c_side;
            Console.WriteLine("Specify, will you be looking for the area of a regular triangle? Write \"Yes\" or \"No\" ");
            string pleasure = Console.ReadLine();
            if (pleasure == "Yes")
            {
                Console.WriteLine("Write the size of triangle ");
                a_side = int.Parse(Console.ReadLine());
                b_side = a_side;
                c_side = a_side;
                double square = Operation.Square(a_side, b_side, c_side);
                Console.WriteLine("Square is {0}", square);
            }
            else
            {
                Console.WriteLine("Write out a =");
                a_side = int.Parse(Console.ReadLine());
                Console.WriteLine("Write out b =");
                b_side = int.Parse(Console.ReadLine());
                Console.WriteLine("Write out c = ");
                c_side = int.Parse(Console.ReadLine());
                double square = Operation.Square(a_side, b_side, c_side);
                Console.WriteLine("Square is {0}", square);
            }
            // Упражнение 5
            double x1; // 1
            double x2;
            double a;
            double b;
            double c;
            Console.WriteLine("***********************************");
            Console.WriteLine("The fifth task");
            Console.WriteLine("Write some parameters for quadratic quation.");
            Console.WriteLine("Write a = ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Write b = ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Write c = ");
            c = double.Parse(Console.ReadLine());
            double answer = Uravneniye.Urav(a, b, c, out x1, out x2); // аргумент функции, передаваемый по ссылке
            if (answer == -1)
            {
                Console.WriteLine("Корни уравнения с коэффициентами a = {0}, b = {1}, c = результата нет.", a, b, c); // 3
            }
            else if (answer == 0) {
                Console.WriteLine("Корень уравнения с коэффициентами a = {0}, b = {1}, c = {2} равны один x1 = x2 = {3}.", a, b, c, x1);
            }
            else
            {
                Console.WriteLine("Корни уравнения с коэффициентами a = {0}, b = {1}, c = {2} равны x1 = {3}, x2 = {4}.", a, b, c, x1, x2);
            }
            Console.WriteLine("That's all! **********************************************");
        }   
    }
}
