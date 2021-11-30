using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_hw
{
    abstract public class Person // Чтобы было понятно, о ком говорим!
                                 // Снизу добавляем то, что будем использовать для реализации списков по возрасту (age and difference).
    {
        public abstract void Move();
        public abstract void Print();
        public abstract void Age();
        public double difference;
    }
}
