using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Book: Item, IPr
    {
        public bool IfSubs { get; set; }
        public void Subs()
        {
            IfSubs = true;
        }

        public bool returnSrok { get; private set; } // private set = нельзя получить не из отсюда
        public void ReturnSrok()
        {
            returnSrok = true;
        }
        public string Author { get; set; } // автор
        public string Title { get; set; } // название
        //public string Publisher { get; set; } // издательство
        public Publisher Publ { get; set; }
        public int Pages { get; set; } // кол-во страниц
        public int Year { get; set; } // год издания
        private static double price = 9; // минимальная стоимость книги
    
        public static double Price // автоматическое свойство
        {
           get { return price; }
           set { if (value > 9) price = value; } // минималка
        }
        public void SetBook(string author, string title, Publisher publisher, int pages, int year)
        {
            this.Author = author;
            this.Title = title;
            this.Pages = pages;
            this.Year = year;
            this.Publ = publisher;
        }
        public void SetPrice(double price)
        {
            Book.Price = price;
        }
        public override string ToString()  // почему переопределяем метод
        {
            string bs = String.Format("\nКнига:\n Автор: {0}\n Название: {1} \n " +
                "Год издания: {2} \n {3} стр.\n Стоимость аренды: {4}\n Издательство{5}.", Author, Title, Year, Pages, Book.Price, Publ.ToString());
            return bs;
        }
        public override void Print()
        {
            Console.WriteLine(this);
            base.Print();
        }
        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }
        public Book(string author, string title, Publisher publisher, int pages, int year)
        {
            this.Author = author;
            this.Title = title;
            this.Pages = pages;
            this.Year = year;
            this.Publ = publisher;
        }
        // по умолчанию 
        public Book ()
        {

        }
        static Book() // вызывается до первого обращения
        {
            Price = 31;
        }
        public Book(string author, string title)
        {
            this.Author = author;
            this.Title = title;
        }
        
        public Book(string author, string title, Publisher publisher, int pages, int year, long invNumber, bool taken) 
            : base(invNumber, taken)
        {
            this.Author = author;
            this.Title = title;
            this.Publ = publisher;
            this.Pages = pages;
            this.Year = year;
        }
        public override void Return()
        {
            if (returnSrok == true)
            {
                taken = true;
            }
            else
            {
                taken = false;
            }

        }


    }
}
