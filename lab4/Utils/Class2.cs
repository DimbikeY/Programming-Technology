using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    class Operation
    {
        public static double Square(int a, int b, int c)
        {
            try
            {
                checked
                {
                    double p = (a + b + c) / 2;
                    double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    // var str = string.Format("{0:0.00}", square) 
                    bool Possibility() // модификаторы наследуются 
                    {                  // Сумма двух сторон треугольника должна быть больше одной всегда.
                        bool ok = true;
                        if ((a + b) <= c || (a + c) <= b || (b + c) <= a)
                        {
                            ok = false;
                        }
                        return ok;
                    }
                    bool bool_answer = Possibility();
                    if (bool_answer) // It makes sense like true!
                    {
                        Console.WriteLine("This triangle can exist! " + bool_answer);
                        return square;
                    }
                    else
                    {
                        Console.WriteLine("This triangle can't exist! " + bool_answer);
                        return 0;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Your number is out of range (int)");
                return 0;
            }
        }
    }
}
