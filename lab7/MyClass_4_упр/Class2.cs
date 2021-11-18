using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Triangle
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; } // Автоматически реализуемые свойства чтения из записи

        public Triangle(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;  // Конструктор, позволяющий создать экземпляр класса с заданными длинами

        }
        public override string ToString()
        {
            string output = String.Format("\nA: {0}, B: {1}, C: {2}.", this.A, this.B, this.C);
            return output;
        }
        public void Print()
        {
            Console.WriteLine(this);
        }
        public void Perimeter()
        {
            if (this.A + this.B > this.C && this.A + this.C > this.B && this.B + this.C > this.A)
            {
                int perimeter = this.A + this.B + this.C;
                Console.WriteLine("Perimeter of triangle is equal {0}.", perimeter);
            }
            else
            {
                Console.WriteLine("This triangle doesn't exist at all!");
            }
        }
        public void Square()
        {
            if (this.A + this.B > this.C && this.A + this.C > this.B && this.B + this.C > this.A)
            {
                double p = (this.A + this.B + this.C) / 2;
                double square = Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C));
                Console.WriteLine("Square of triangle is equal {0}.", square);
                string right_a = String.Format("{0:0.00}", square);
                Console.WriteLine("Square of triangle is equal {0}.", right_a);
            }
            else
            {
                Console.WriteLine("This triangle doesn't exist at all!");
            }
        }
    }
}
