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
            Console.WriteLine("Write out a =");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Write out b =");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Write out c = ");
            int c = int.Parse(Console.ReadLine());
            double square = Operation.Square(a, b, c);
            Console.WriteLine("Square is {0}", square);


        }
    }
}
