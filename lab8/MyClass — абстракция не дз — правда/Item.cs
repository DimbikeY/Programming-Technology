using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    abstract class Item: IComparable
    {
        int IComparable.CompareTo(object obj)
        {
            Item it = (Item)obj;
            if (this.invNumber == it.invNumber) return 0;
            else if (this.invNumber > it.invNumber) return 1;
            else return -1;
        }
        protected long invNumber;
        protected bool taken;
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
        public long GetInvNumber()
        {
            return invNumber;
        }
        public void TakeItem()
        {
            if (this.IsAvailable())
            {
                this.Take();
            }
        }
        private void Take()
        {
            taken = false;
        }
        public abstract void Return();
        public virtual void Print()
        {
            Console.WriteLine("Состояние единицы хранения:\n Инвентарный номер: {0}\n Наличие:" +
                " {1}.", invNumber, taken);
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
    }
}
