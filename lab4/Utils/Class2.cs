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
            double p = (a + b + c) / 2;
            double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            // var str = string.Format("{0:0.00}", square) 
            return square;
        }
        // Сумма двух сторон треугольника должна быть больше одной всегда.
    }
}
