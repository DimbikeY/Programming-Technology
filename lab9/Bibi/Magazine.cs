using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    delegate void ProcessMagazineDelegate(Magazine mag, DateTime dt);
    class Magazine: Item, IPubs
    {
        public static event ProcessMagazineDelegate Subsrcibe = null;
        public void Subs()
        {
            IfSubs = true;
            if (Subsrcibe != null)
            {
                Subsrcibe(this, DateTime.Now);
            }
        }

        public bool IfSubs { get; set; }
        //public void Subs()
        //{
           // IfSubs = true;
        //}

        public string Volume { get; set; } // том
        public int Number { get; set; } // номер
        public string Title { get; set; } // название
        public int Year { get; set; } // год выпуска 

        public Magazine(string volume, int number, string title, int year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.Volume = volume;
            this.Number = number;
            this.Title = title;
            this.Year = year;
        }
        public Magazine()
        {

        }
        public override string ToString()
        {
            string bs = String.Format("\nЖурнал:\n Том: {0}\n Номер: {1}\n Название:" +
                " {2} \n Год выпуска: {3} \n Cтатус подписки: {4}.", Volume, Number, Title, Year, IfSubs);
            return bs;
        }
        public override void Print()
        {
            Console.WriteLine(this);
            base.Print();
        }
        public override void Return()
        {
            taken = true;
        }
    }
    
}
