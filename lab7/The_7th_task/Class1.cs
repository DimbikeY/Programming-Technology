using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_7th_task
{
    abstract class Progression
    {
        public abstract int GetElement();    // реализация в классе дочернем.
    }
    class Solution
    {
        public int GetElement(Progression k)
        {
            int answer = k.GetElement();
            return answer;
        }
    }
    class ArithmeticProgression: Progression
    {
        private int Input_b;
        private int Input_s;
        private int Input_e;

        public ArithmeticProgression(int input_b, int input_s, int input_e )  // get
        {
            this.Input_b = input_b;
            this.Input_s = input_s;
            this.Input_e = input_e;
        }
        public override int GetElement()
        {
            int begin = this.Input_b;
            for (int i = 1; i < this.Input_e; i++)
            {
                begin += this.Input_s;
            }
            return begin;
        }
    }
    class GeometricProgression: Progression
    {
        private int Input_b;
        private int Input_s;
        private int Input_e;

        public GeometricProgression(int input_b, int input_s, int input_e)  // get
        {
            this.Input_b = input_b;
            this.Input_s = input_s;
            this.Input_e = input_e;
        }
        public override int GetElement()
        {
            int begin = this.Input_b;
            for (int j = 1; j < this.Input_e; j++)
            {
                begin *= this.Input_s;
            }
            return begin;
        } 
    }
} // Хотя можно было общий конструктор сделать в абстрактном классе, а затем через base и override слепить
  // но в задании требовалось в каждом классе опеределить конструктор.
