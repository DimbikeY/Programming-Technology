using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Item
    {   // целочисленный тип
        protected long invNumber;
        protected bool taken;
        public bool returnSrok { get; private set; }
        
        public bool IsAvailable()
        {
            if (taken == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public long GetInvNumber() // инвентарный номер
        {
            return invNumber;
        }
        private void Take() // взять
        {
            taken = false;
        }
        public virtual void Return() // вернуть
        {
            taken = true;
        }
        public virtual void Print()
        {
            Console.WriteLine("Состояние единицы хранения: \n Инвентарный номер: {0}\n Наличие: {1}", invNumber, taken);
        }
        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }
        public Item()
        {
            this.taken = true;
        }
        public void TakeItem()
        {
            if (this.IsAvailable())
            {
                this.Take(); // выполняется только внутри класса ---> private Take()
            }
        }
        public void ReturnSrok()
        {
            returnSrok = true;
        }
    }
}
