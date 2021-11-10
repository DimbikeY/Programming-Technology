using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    class Uravneniye
    {
        public static double Urav(double a, double b, double c, out double x1, out double x2)
        {
            var discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("Квадратное уравнение не имеет действительных корней");
                x1 = 0;
                x2 = 0;
                return -1;
            }
            else
            {
                if (discriminant == 0) // квадратное уравнение имеет два одинаковых корня
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                    return 0;
                }
                else // уравнение имеет два разных корня
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    return 1;
                }
            };
        }
    }
}
