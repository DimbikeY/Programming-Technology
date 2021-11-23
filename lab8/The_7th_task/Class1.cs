using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_7th_task
{   
    class Progression: IProgression
    {
        private int Input_b { get; set; }
        private int Input_s { get; set; }
        private int Input_e { get; set; }

        public Progression(int input_b, int input_s, int input_e )  // get
        {
            this.Input_b = input_b;
            this.Input_s = input_s;
            this.Input_e = input_e;
        }
        public int Algebraic()
        {
            int begin = this.Input_b;
            for (int i = 1; i < this.Input_e; i++)
            {
                begin += this.Input_s;
            }
            return begin;
        }
       public int Geometric()
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
